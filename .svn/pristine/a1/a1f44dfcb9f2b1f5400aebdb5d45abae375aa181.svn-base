using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class FacItemUnit
    {
        public FacItemUnit()
        {
            FacDailyTobaccoIssues = new HashSet<FacDailyTobaccoIssue>();
            FacFacToFacItemDistributionDetails = new HashSet<FacFacToFacItemDistributionDetail>();
            FacJarTamakFactoryItemStocks = new HashSet<FacJarTamakFactoryItemStock>();
            FacJarTobaccoIssueToChatals = new HashSet<FacJarTobaccoIssueToChatal>();
            FacReceiveItemFromHodetails = new HashSet<FacReceiveItemFromHodetail>();
        }

        public short Id { get; set; }
        public string Unit { get; set; } = null!;
        public string Description { get; set; } = null!;
        public bool? IsActive { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual ICollection<FacDailyTobaccoIssue> FacDailyTobaccoIssues { get; set; }
        public virtual ICollection<FacFacToFacItemDistributionDetail> FacFacToFacItemDistributionDetails { get; set; }
        public virtual ICollection<FacJarTamakFactoryItemStock> FacJarTamakFactoryItemStocks { get; set; }
        public virtual ICollection<FacJarTobaccoIssueToChatal> FacJarTobaccoIssueToChatals { get; set; }
        public virtual ICollection<FacReceiveItemFromHodetail> FacReceiveItemFromHodetails { get; set; }
    }
}
