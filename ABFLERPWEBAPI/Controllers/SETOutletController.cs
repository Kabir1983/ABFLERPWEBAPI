using ABFLERPWEBAPI.BO;
using ABFLERPWEBAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Linq.Expressions;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ABFLERPWEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SETOutletController : ControllerBase
    {

        private readonly AkijSCMSDBContext _dbContext;
        public SETOutletController(AkijSCMSDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        [Route("InsertOutLetInfo")]
        public Response PostOutletList(ArrayList arrayList)
        {
            List<BO.SET_Outlet> OutletList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<BO.SET_Outlet>>(arrayList[0].ToString());
            Response response = new Response();
            int maxOutletID = this._dbContext.SetOutlets.Max(m => (int?)m.OutletId) ?? 0;
            int maxClusterID = this._dbContext.SetClusters.Max(m => (int?)m.ClusterId) ?? 0;

            int routeId = 0;
            int num = 0;
            int maxRouteWiseMaxNo = 0;
            foreach (BO.SET_Outlet outlet in OutletList)
            {
                if (outlet.RouteID != routeId)
                {
                    routeId = outlet.RouteID;
                    maxRouteWiseMaxNo = _dbContext.SetOutlets.Where(m => m.RouteId == routeId).Max(m => (int?)m.RouteOutletNo) ?? 0;
                }
                SetOutlet objOutletData = new SetOutlet();
                if (outlet.Address != "")
                {
                    SetCluster setCluster = this._dbContext.SetClusters.FirstOrDefault(m => m.RouteId == outlet.RouteID && m.ClusterName.ToLower().Trim() == outlet.Address.ToLower().Trim());
                    if (setCluster == null)
                    {
                        SetCluster sET_Cluster = new SetCluster();
                        sET_Cluster.ClusterId = ++maxClusterID;
                        sET_Cluster.ClusterName = outlet.Address;
                        sET_Cluster.ClusterCode = "C-" + sET_Cluster.ClusterId.ToString();
                        sET_Cluster.RouteId = new int?(outlet.RouteID);
                        sET_Cluster.IsActive = true;
                        sET_Cluster.LastUpdate = DateTime.Now;
                        _dbContext.SetClusters.Add(sET_Cluster);
                        _dbContext.SaveChanges();
                        objOutletData.ClusterId = new int?(sET_Cluster.ClusterId);
                    }
                    else
                    {
                        objOutletData.ClusterId = new int?(setCluster.ClusterId);
                    }
                }

                if (outlet.RouteID > 0)
                {


                    objOutletData.OutletId = ++maxOutletID;
                    objOutletData.OutletCode = Convert.ToString(objOutletData.OutletId);
                    objOutletData.OutletName = outlet.OutletName;
                    objOutletData.Owner = outlet.Owner;
                    objOutletData.Address = outlet.Address;
                    objOutletData.ContactNo = outlet.ContactNo;
                    objOutletData.RouteId = outlet.RouteID;
                    objOutletData.RouteOutletNo = ++maxRouteWiseMaxNo;
                    objOutletData.IsActive = true;
                    objOutletData.LastUpdate = DateTime.Now;
                    objOutletData.IsNew = false;
                    objOutletData.BiriCigaretteStatus = 1;
                    objOutletData.UnionId = 0;
                    objOutletData.VillageName = "";
                    objOutletData.MarketName = "";
                    objOutletData.OutletTypeID = outlet.OutletTypeID;

                    _dbContext.SetOutlets.Add(objOutletData);
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
    }
}
