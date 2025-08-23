using Microsoft.EntityFrameworkCore;
using System.Net;

namespace ABFLERPWEBAPI.Models
{
    [Keyless]
    public class AndroidMKTSPGETTourPlanReport
    {
        public long ID { get; set; }
        public DateTime Date { get; set; }
        public int EmploymentID { get; set; }
        public Int16 RouteTypeID { get; set; }
        public string RouteType { get; set; }
        public int RouteID { get; set; }
        public string? RouteName { get; set; }
        public string? ContactNo { get; set; }
        public int ClusterID { get; set; }
        public string? ClusterName { get; set; }
        public long OutletID { get; set; }
        public string OutletName { get; set; }
        public Int16? VehicleTypeID { get; set; }
        public string? VehicleType { get; set; }
        public string? RouteDistance { get; set; }
        public bool VisitStatus { get; set; }
        public int ApprovedByID { get; set; }
        public bool? ApprovedStatus { get; set; }
        public bool IsActive { get; set; }
        public DateTime LastUpdate { get; set; }
        public bool? IsDraft { get; set; }

    }
}
