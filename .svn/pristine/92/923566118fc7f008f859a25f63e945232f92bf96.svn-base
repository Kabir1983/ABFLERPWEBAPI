using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsRequisitionToRegionDetail
    {
        public DmsRequisitionToRegionDetail()
        {
            DmsRequisitionToRegionApproveAndAssignDetails = new HashSet<DmsRequisitionToRegionApproveAndAssignDetail>();
        }

        public long RequisitionItemId { get; set; }
        public long RequisitionId { get; set; }
        public short ProductId { get; set; }
        public long Qty { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual DmsAreaRequisitionToRegion Requisition { get; set; } = null!;
        public virtual ICollection<DmsRequisitionToRegionApproveAndAssignDetail> DmsRequisitionToRegionApproveAndAssignDetails { get; set; }
    }
}
