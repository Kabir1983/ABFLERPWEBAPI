using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsDepoRequisition
    {
        public DmsDepoRequisition()
        {
            DmsDepoRequisitionItems = new HashSet<DmsDepoRequisitionItem>();
        }

        public long RequisitionId { get; set; }
        public string RequisitionNo { get; set; } = null!;
        public byte Month { get; set; }
        public short Year { get; set; }
        public DateTime Date { get; set; }
        public int DepoId { get; set; }
        public int RequisitionById { get; set; }
        public string? Remarks { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual SetDepo Depo { get; set; } = null!;
        public virtual ICollection<DmsDepoRequisitionItem> DmsDepoRequisitionItems { get; set; }
    }
}
