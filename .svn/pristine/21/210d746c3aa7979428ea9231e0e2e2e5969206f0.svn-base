using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class OocOutletSaleTargetPlan
    {
        public OocOutletSaleTargetPlan()
        {
            OocOutletSaleTargetPlanItems = new HashSet<OocOutletSaleTargetPlanItem>();
        }

        public long PlanId { get; set; }
        public int EmploymentId { get; set; }
        public int OutletId { get; set; }
        public DateTime Date { get; set; }
        public byte? Shift { get; set; }
        public short Month { get; set; }
        public short Year { get; set; }
        public bool? PackfacingVisibility { get; set; }
        public bool? SmokerContact { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual ICollection<OocOutletSaleTargetPlanItem> OocOutletSaleTargetPlanItems { get; set; }
    }
}
