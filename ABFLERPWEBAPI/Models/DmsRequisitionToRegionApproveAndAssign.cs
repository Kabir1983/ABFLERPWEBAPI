using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsRequisitionToRegionApproveAndAssign
    {
        public DmsRequisitionToRegionApproveAndAssign()
        {
            DmsRequisitionToRegionApproveAndAssignDetails = new HashSet<DmsRequisitionToRegionApproveAndAssignDetail>();
        }

        public long ApprovedId { get; set; }
        public long RequisitionId { get; set; }
        public int RequestToAreaId { get; set; }
        public byte Month { get; set; }
        public short Year { get; set; }
        public DateTime Date { get; set; }
        public int Rmid { get; set; }
        public string? Remarks { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual DmsAreaRequisitionToRegion Requisition { get; set; } = null!;
        public virtual ICollection<DmsRequisitionToRegionApproveAndAssignDetail> DmsRequisitionToRegionApproveAndAssignDetails { get; set; }
    }
}
