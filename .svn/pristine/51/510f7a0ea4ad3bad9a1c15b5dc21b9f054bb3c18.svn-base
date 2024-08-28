using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsAreaRequisitionToRegion
    {
        public DmsAreaRequisitionToRegion()
        {
            DmsRequisitionToRegionApproveAndAssigns = new HashSet<DmsRequisitionToRegionApproveAndAssign>();
            DmsRequisitionToRegionDetails = new HashSet<DmsRequisitionToRegionDetail>();
        }

        public long RequisitionId { get; set; }
        public string RequisitionNo { get; set; } = null!;
        public byte Month { get; set; }
        public short Year { get; set; }
        public DateTime Date { get; set; }
        public int AreaId { get; set; }
        public int RequisitionById { get; set; }
        public string? Remarks { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual ICollection<DmsRequisitionToRegionApproveAndAssign> DmsRequisitionToRegionApproveAndAssigns { get; set; }
        public virtual ICollection<DmsRequisitionToRegionDetail> DmsRequisitionToRegionDetails { get; set; }
    }
}
