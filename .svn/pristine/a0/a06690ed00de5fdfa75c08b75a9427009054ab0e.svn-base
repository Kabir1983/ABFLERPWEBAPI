using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsDepoToDepoRequisition
    {
        public DmsDepoToDepoRequisition()
        {
            DmsDepoToDepoRequisitionItems = new HashSet<DmsDepoToDepoRequisitionItem>();
        }

        public long RequisitionId { get; set; }
        public string RequisitionNo { get; set; } = null!;
        public int Month { get; set; }
        public int Year { get; set; }
        public DateTime Date { get; set; }
        public int DepoId { get; set; }
        public int ToDepoId { get; set; }
        public int RequisitionById { get; set; }
        public string? Remarks { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual SetDepo Depo { get; set; } = null!;
        public virtual ICollection<DmsDepoToDepoRequisitionItem> DmsDepoToDepoRequisitionItems { get; set; }
    }
}
