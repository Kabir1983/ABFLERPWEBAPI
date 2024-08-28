using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsTargetPlan
    {
        public DmsTargetPlan()
        {
            DmsTargetPlanItems = new HashSet<DmsTargetPlanItem>();
        }

        public long TplanId { get; set; }
        public string TplanNo { get; set; } = null!;
        public byte Month { get; set; }
        public short Year { get; set; }
        public DateTime Date { get; set; }
        public int AreaId { get; set; }
        public int TplanById { get; set; }
        public string? Remarks { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual SetArea Area { get; set; } = null!;
        public virtual ICollection<DmsTargetPlanItem> DmsTargetPlanItems { get; set; }
    }
}
