using ABFLERPWEBAPI.BO;
using ABFLERPWEBAPI.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Net;
using System.Text;

namespace ABFLERPWEBAPI.Controllers
{
    [EnableCors("devCorsPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private readonly AkijSCMSDBContext _dbContext;
        public LocationController(AkijSCMSDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        [Route("PostGPSData")]
        public Response PostGPSData(LocationModel locationModel)
        {
            Response response = new Response();
            var objUser = _dbContext.SetUsers.FirstOrDefault(m => m.UserId == locationModel.UserId);

            long maxID = _dbContext.Gpstrackings.Max(m => (long?)m.GpstracId) ?? 0;

            Gpstracking objGpstracking = new Gpstracking();

            objGpstracking.GpstracId = maxID+1;
            objGpstracking.Longitude = Convert.ToDecimal(locationModel.lng);
            objGpstracking.Latitude = Convert.ToDecimal(locationModel.lat);
            objGpstracking.Address = getLocationByGeoLocation(Convert.ToString(objGpstracking.Longitude), Convert.ToString(objGpstracking.Latitude));
            objGpstracking.EmployeeId = objUser.EmployeeId;
            objGpstracking.TrackingTime = DateTime.Now;
            objGpstracking.OrderId = 0;
            objGpstracking.ImageCaptureId = 0;
            objGpstracking.OutletId = 0;

            _dbContext.Gpstrackings.Add(objGpstracking);

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


        private string getLocationByGeoLocation(string longitude, string latitude)
        {
            string locationName = string.Empty;

            try
            {
                if (string.IsNullOrEmpty(longitude) || string.IsNullOrEmpty(latitude))
                    return "";

                string url = string.Format("https://maps.googleapis.com/maps/api/geocode/xml?latlng={0},{1}&sensor=false&key=AIzaSyBr0M-_4t6tGSVb87JidANh-ZfOQCX6u9k", latitude, longitude);


                WebRequest request = WebRequest.Create(url);

                using (WebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    using (StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
                    {
                        DataSet dsResult = new DataSet();
                        dsResult.ReadXml(reader);
                        try
                        {
                            foreach (DataRow row in dsResult.Tables["result"].Rows)
                            {
                                locationName = row["formatted_address"].ToString();
                            }
                            locationName = dsResult.Tables["result"].Rows[0]["formatted_address"].ToString();
                        }
                        catch (Exception)
                        {

                        }

                    }
                }
            }
            catch (Exception ex)
            {

            }

            return locationName;
        }
    }
}
