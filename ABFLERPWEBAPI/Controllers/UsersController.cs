using Azure.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Cors;
using ABFLERPWEBAPI.BO;

namespace ABFLERPWEBAPI.Controllers
{

    [EnableCors("devCorsPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly AkijSCMSDBContext _dbContext;
        public UsersController(AkijSCMSDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllUser()
        {
            return Ok(await _dbContext.SetUsers.Take(1000).ToListAsync());
        }


        [HttpPost]
        [Route("Registration")]
        public Response Registration(SetUser setUser)
        {
            Response response = new Response();
            string decriptPass = Common.HashValue.Encrypt(setUser.Password);
            int maxId = _dbContext.SetUsers.Max(m => (int?)m.Id) ?? 0;
            setUser.Id = maxId + 1;
            setUser.Password = decriptPass;
            setUser.IsActive = true;
            setUser.LastUpdate = DateTime.UtcNow;
            setUser.EmployeeId = 1;

            _dbContext.SetUsers.Add(setUser);
            if (_dbContext.SaveChanges() > 0)
            {
                response.StatusCode = 200;
                response.StatusMessage = "Login Success";
                SetUser objUser = new SetUser();
                objUser.UserId = setUser.UserId;
                objUser.Password = setUser.Password;
                objUser.IsActive = setUser.IsActive;
                objUser.LastUpdate = setUser.LastUpdate;

                response.SetUser = setUser;
            }
            else
            {
                response.StatusCode = 100;
                response.StatusMessage = "Login Faild";
                response.SetUser = null;
            }
            return response;
        }

        [HttpPost]
        [Route("Login")]
        public Response Login(string userid, string password)
        {
            string decriptPass = Common.HashValue.Encrypt(password);

            var objUser = _dbContext.SetUsers.FirstOrDefault(m => m.UserId == userid && m.Password == decriptPass);
            Response response = new Response();
            if (objUser == null)
            {
                response.StatusCode = 100;
                response.StatusMessage = "Login Faild";
                response.SetUser = null;
            }
            else
            {
                string tokenString = GetRandomAlphanumericString(15);
                objUser.Token = tokenString;
                objUser.LoginTime = DateTime.Now;
                response.StatusCode = 200;
                response.StatusMessage = "Login Success";
                SetUser setUser = new SetUser();
                setUser.UserId = objUser.UserId;
                setUser.Password = objUser.Password;
                setUser.IsActive = objUser.IsActive;
                setUser.LastUpdate = objUser.LastUpdate;
                setUser.Token = objUser.Token;
                setUser.LoginTime = objUser.LoginTime;
                response.SetUser = setUser;
            }
            return response;
        }

        [HttpPost]
        [Route("GPSAppLogin")]
        public Response GPSAppLogin(LoginModel loginModel)
        {
            Response response = new Response();
            if (loginModel != null)
            {
                var objSearchUser = _dbContext.SetUsers.FirstOrDefault(m => m.UserId == loginModel.UserName);

                string decriptPass = Common.HashValue.Encrypt(loginModel.Password);


                var objValidUser = _dbContext.SecuredUsers.Where(m => m.EmployeeId == objSearchUser.EmployeeId && m.SecureWord == decriptPass).OrderByDescending(m => m.Id).FirstOrDefault();

                if(objValidUser == null)
                {
                    var objUser = _dbContext.SetUsers.FirstOrDefault(m => m.UserId == loginModel.UserName && m.Password == decriptPass);

                    if (objUser == null)
                    {
                        response.StatusCode = 100;
                        response.StatusMessage = "Login Faild";
                        response.SetUser = null;
                    }
                    else
                    {
                        string tokenString = GetRandomAlphanumericString(15);
                        objUser.Token = tokenString;
                        objUser.LoginTime = DateTime.Now;
                        response.StatusCode = 200;
                        response.StatusMessage = "Login Success";
                        SetUser setUser = new SetUser();
                        setUser.UserId = objUser.UserId;
                        setUser.Password = objUser.Password;
                        setUser.IsActive = objUser.IsActive;
                        setUser.LastUpdate = objUser.LastUpdate;
                        setUser.Token = objUser.Token;
                        setUser.LoginTime = objUser.LoginTime;
                        response.SetUser = setUser;
                    }
                }
                else
                {
                    string tokenString = GetRandomAlphanumericString(15);
                    string token = tokenString;
                    response.StatusCode = 200;
                    response.StatusMessage = "Login Success";
                    SetUser setUser = new SetUser();
                    setUser.UserId = objSearchUser.UserId;
                    setUser.Password = objValidUser.SecureWord;
                    setUser.IsActive = objSearchUser.IsActive;
                    setUser.LastUpdate = objSearchUser.LastUpdate;
                    setUser.Token = token;
                    setUser.LoginTime = DateTime.Now;
                    response.SetUser = setUser;
                }                
            }
            else
            {

                response.StatusCode = 100;
                response.StatusMessage = "Login Faild";
                response.SetUser = null;
            }
            return response;
        }

        public static string GetRandomAlphanumericString(int length)
        {
            const string alphanumericCharacters =
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "abcdefghijklmnopqrstuvwxyz" +
                "0123456789" +
                "*#%&";
            return GetRandomString(length, alphanumericCharacters);
        }

        public static string GetRandomString(int length, IEnumerable<char> characterSet)
        {
            if (length < 0)
                throw new ArgumentException("length must not be negative", "length");
            if (length > int.MaxValue / 8) // 250 million chars ought to be enough for anybody
                throw new ArgumentException("length is too big", "length");
            if (characterSet == null)
                throw new ArgumentNullException("characterSet");
            var characterArray = characterSet.Distinct().ToArray();
            if (characterArray.Length == 0)
                throw new ArgumentException("characterSet must not be empty", "characterSet");

            var bytes = new byte[length * 8];
            var result = new char[length];
            using (var cryptoProvider = new RNGCryptoServiceProvider())
            {
                cryptoProvider.GetBytes(bytes);
            }
            for (int i = 0; i < length; i++)
            {
                ulong value = BitConverter.ToUInt64(bytes, i * 8);
                result[i] = characterArray[value % (uint)characterArray.Length];
            }
            return new string(result);
        }
    }
}
