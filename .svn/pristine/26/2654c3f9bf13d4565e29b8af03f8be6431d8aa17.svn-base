using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class FacFactoryItemStock
    {
        public FacFactoryItemStock()
        {
            FacDailyItemDisToWorkerDetails = new HashSet<FacDailyItemDisToWorkerDetail>();
            FacDailyTobaccoIssues = new HashSet<FacDailyTobaccoIssue>();
            FacFacToFacItemDistributionDetails = new HashSet<FacFacToFacItemDistributionDetail>();
            FacFacToFacItemReceiveDetails = new HashSet<FacFacToFacItemReceiveDetail>();
            FacReceiveItemFromHodetails = new HashSet<FacReceiveItemFromHodetail>();
        }

        public long Fisid { get; set; }
        public byte FactoryId { get; set; }
        public int ItemId { get; set; }
        public decimal Qty { get; set; }
        public decimal Balance { get; set; }
        public short UnitId { get; set; }
        public decimal? UnitPrice { get; set; }
        public short StockType { get; set; }
        public DateTime StockDate { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual SetFactory Factory { get; set; } = null!;
        public virtual FacItemInfo Item { get; set; } = null!;
        public virtual ICollection<FacDailyItemDisToWorkerDetail> FacDailyItemDisToWorkerDetails { get; set; }
        public virtual ICollection<FacDailyTobaccoIssue> FacDailyTobaccoIssues { get; set; }
        public virtual ICollection<FacFacToFacItemDistributionDetail> FacFacToFacItemDistributionDetails { get; set; }
        public virtual ICollection<FacFacToFacItemReceiveDetail> FacFacToFacItemReceiveDetails { get; set; }
        public virtual ICollection<FacReceiveItemFromHodetail> FacReceiveItemFromHodetails { get; set; }
    }
}
