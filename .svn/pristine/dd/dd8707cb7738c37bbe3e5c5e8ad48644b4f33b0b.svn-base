using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class OocOutletSaleTargetPlanItem
    {
        public long TplanItemId { get; set; }
        public long TplanId { get; set; }
        public short ProductId { get; set; }
        public int Qty { get; set; }
        public string? Remarks { get; set; }
        public int InsertUserId { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual SetProduct Product { get; set; } = null!;
        public virtual OocOutletSaleTargetPlan Tplan { get; set; } = null!;
    }
}
