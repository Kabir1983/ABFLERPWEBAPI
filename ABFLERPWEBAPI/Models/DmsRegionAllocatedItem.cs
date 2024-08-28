using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsRegionAllocatedItem
    {
        public long Id { get; set; }
        public long TplanId { get; set; }
        public short ProductId { get; set; }
        public long PlanQty { get; set; }
        public long ApproveQty { get; set; }
        public int? Smid { get; set; }
        public string? Remarks { get; set; }
        public int InsertUserId { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual DmsRegionAllocatedTarget Tplan { get; set; } = null!;
    }
}
