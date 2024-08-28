using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class FacFacToFacItemDistributionDetail
    {
        public FacFacToFacItemDistributionDetail()
        {
            FacFacToFacItemReceiveDetails = new HashSet<FacFacToFacItemReceiveDetail>();
        }

        public long Id { get; set; }
        public long Ffid { get; set; }
        public long Fisid { get; set; }
        public int ItemId { get; set; }
        public short UnitId { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Qty { get; set; }
        public string Remarks { get; set; } = null!;
        public bool IsReceive { get; set; }
        public bool IsActive { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual FacFacToFacItemDistribution Ff { get; set; } = null!;
        public virtual FacFactoryItemStock Fis { get; set; } = null!;
        public virtual FacItemInfo Item { get; set; } = null!;
        public virtual FacItemUnit Unit { get; set; } = null!;
        public virtual ICollection<FacFacToFacItemReceiveDetail> FacFacToFacItemReceiveDetails { get; set; }
    }
}
