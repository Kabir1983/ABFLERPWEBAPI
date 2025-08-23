using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class MKTTourPlan
    {
        public long ID { get; set; }
        public DateTime Date { get; set; }
        public int EmploymentID { get; set; }
        public short RouteTypeID { get; set; }
        public string RouteType { get; set; }
        public int RouteID { get; set; }
        public int ClusterID { get; set; }
        public long OutletID { get; set; }
        public string OutletName { get; set; }
        public short VehicleTypeID { get; set; }
        public string VehicleType { get; set; }
        public string RouteDistance { get; set; }
        public bool VisitStatus { get; set; }
        public bool IsActive { get; set; }
        public int? ApprovedByID { get; set; }
        public bool? ApprovedStatus { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
