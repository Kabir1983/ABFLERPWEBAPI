using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ABFLERPWEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DMSFactoryProductionBarcodeController : ControllerBase
    {

        private readonly AkijSCMSDBContext _dbContext;
        public DMSFactoryProductionBarcodeController(AkijSCMSDBContext dbContext)
        {
            _dbContext = dbContext;
        }


        // GET: api/<DMSFactoryProductionBarcodeController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
            
        }

        // GET api/<DMSFactoryProductionBarcodeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<DMSFactoryProductionBarcodeController>
        [HttpPost]
        [Route("DataUpload")]
        public Response Post(List<Models.DmsFactoryProductionBarcode> objFPBList)
        {

            Response response = new Response();
            long maxFPBID = _dbContext.DmsFactoryProductionBarcodes.Max(m => (long?)m.Id) ?? 0;

            if (objFPBList != null)
            {
                foreach (var objDMS_FactoryProductionBarcode in objFPBList)
                {
                    objDMS_FactoryProductionBarcode.Id = ++maxFPBID;
                    objDMS_FactoryProductionBarcode.UploadTime = DateTime.Now;
                    _dbContext.DmsFactoryProductionBarcodes.Add(objDMS_FactoryProductionBarcode);
                }
            }
            if (_dbContext.SaveChanges() > 0)
            {
                response.StatusCode = 200;
                response.StatusMessage = "Save Success";
            }
            else
            {
                response.StatusCode = 100;
                response.StatusMessage = "Failed";
            }
            return response;
        }

        // PUT api/<DMSFactoryProductionBarcodeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DMSFactoryProductionBarcodeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
