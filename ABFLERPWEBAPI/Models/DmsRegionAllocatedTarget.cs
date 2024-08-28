using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsRegionAllocatedTarget
    {
        public DmsRegionAllocatedTarget()
        {
            DmsRegionAllocatedItems = new HashSet<DmsRegionAllocatedItem>();
        }

        public long TplanId { get; set; }
        public string TplanNo { get; set; } = null!;
        public byte Month { get; set; }
        public short Year { get; set; }
        public DateTime Date { get; set; }
        public int RegionId { get; set; }
        public int TplanById { get; set; }
        public string? Remarks { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual ICollection<DmsRegionAllocatedItem> DmsRegionAllocatedItems { get; set; }
    }
}
