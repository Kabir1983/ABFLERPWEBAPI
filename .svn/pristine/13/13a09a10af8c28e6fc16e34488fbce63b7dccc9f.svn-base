using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsRequisitionItem
    {
        public long RequisitionItemId { get; set; }
        public long RequisitionId { get; set; }
        public short ProductId { get; set; }
        public long Qty { get; set; }
        public bool IsApprovedByRm { get; set; }
        public long RmapprovalQty { get; set; }
        public int Rmid { get; set; }
        public int InsertUserId { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual SetProduct Product { get; set; } = null!;
        public virtual DmsRequisition Requisition { get; set; } = null!;
    }
}
