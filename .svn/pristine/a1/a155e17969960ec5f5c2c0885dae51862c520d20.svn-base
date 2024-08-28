using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsRoutePlan
    {
        public long PlanId { get; set; }
        public int EmployeeId { get; set; }
        public int RouteId { get; set; }
        public DateTime Date { get; set; }
        public byte Month { get; set; }
        public short Year { get; set; }
        public DateTime LastUpdate { get; set; }
        public bool? IsActive { get; set; }

        public virtual HrmPi Employee { get; set; } = null!;
        public virtual SetRoute Route { get; set; } = null!;
    }
}
