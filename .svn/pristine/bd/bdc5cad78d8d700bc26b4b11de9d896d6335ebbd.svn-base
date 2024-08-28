using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class FacItemInfo
    {
        public FacItemInfo()
        {
            FacDailyItemDisToWorkerDetails = new HashSet<FacDailyItemDisToWorkerDetail>();
            FacDailyTobaccoIssues = new HashSet<FacDailyTobaccoIssue>();
            FacFacToFacItemDistributionDetails = new HashSet<FacFacToFacItemDistributionDetail>();
            FacFactoryItemStocks = new HashSet<FacFactoryItemStock>();
            FacJarTamakFactoryItemStocks = new HashSet<FacJarTamakFactoryItemStock>();
            FacJarTobaccoIssueToChatals = new HashSet<FacJarTobaccoIssueToChatal>();
            FacReceiveItemFromHodetails = new HashSet<FacReceiveItemFromHodetail>();
        }

        public int Id { get; set; }
        public string ItemName { get; set; } = null!;
        public byte? ItemTypeId { get; set; }
        public short? ProductId { get; set; }
        public short UnitId { get; set; }
        public decimal UnitPrice { get; set; }
        public string Description { get; set; } = null!;
        public bool IsActive { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual ICollection<FacDailyItemDisToWorkerDetail> FacDailyItemDisToWorkerDetails { get; set; }
        public virtual ICollection<FacDailyTobaccoIssue> FacDailyTobaccoIssues { get; set; }
        public virtual ICollection<FacFacToFacItemDistributionDetail> FacFacToFacItemDistributionDetails { get; set; }
        public virtual ICollection<FacFactoryItemStock> FacFactoryItemStocks { get; set; }
        public virtual ICollection<FacJarTamakFactoryItemStock> FacJarTamakFactoryItemStocks { get; set; }
        public virtual ICollection<FacJarTobaccoIssueToChatal> FacJarTobaccoIssueToChatals { get; set; }
        public virtual ICollection<FacReceiveItemFromHodetail> FacReceiveItemFromHodetails { get; set; }
    }
}
