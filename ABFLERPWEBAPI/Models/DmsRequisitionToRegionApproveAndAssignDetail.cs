using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsRequisitionToRegionApproveAndAssignDetail
    {
        public long Id { get; set; }
        public long ApprovedId { get; set; }
        public long RequisitionItemId { get; set; }
        public long RmapprovalQty { get; set; }

        public virtual DmsRequisitionToRegionApproveAndAssign Approved { get; set; } = null!;
        public virtual DmsRequisitionToRegionDetail RequisitionItem { get; set; } = null!;
    }
}
