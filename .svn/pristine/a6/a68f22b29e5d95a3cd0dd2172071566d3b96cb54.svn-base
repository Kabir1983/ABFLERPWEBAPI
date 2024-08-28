using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsTargetPlanItem
    {
        public long TplanItemId { get; set; }
        public long TplanId { get; set; }
        public short ProductId { get; set; }
        public long Qty { get; set; }
        public bool IsApprovedByRm { get; set; }
        public long RmapprovalQty { get; set; }
        public int? Rmid { get; set; }
        public bool IsApprovedBySm { get; set; }
        public long SmapprovalQty { get; set; }
        public int? Smid { get; set; }
        public byte? FactoryId { get; set; }
        public string? Remarks { get; set; }
        public int InsertUserId { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual SetProduct Product { get; set; } = null!;
        public virtual HrmPiemployement? Rm { get; set; }
        public virtual DmsTargetPlan Tplan { get; set; } = null!;
    }
}
