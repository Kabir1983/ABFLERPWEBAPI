using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class FacDailyTobaccoIssue
    {
        public FacDailyTobaccoIssue()
        {
            FacDailyToabaccoUses = new HashSet<FacDailyToabaccoUse>();
        }

        public long Id { get; set; }
        public long ChallanNo { get; set; }
        public DateTime IssueDate { get; set; }
        public byte IssueType { get; set; }
        public byte FactoryId { get; set; }
        public short ProductId { get; set; }
        public int ItemId { get; set; }
        public short UnitId { get; set; }
        public decimal? UnitPrice { get; set; }
        public long Fisid { get; set; }
        public decimal IssueQty { get; set; }
        public bool? IsUse { get; set; }
        public string? Remarks { get; set; }
        public DateTime Lastupdate { get; set; }

        public virtual FacFactoryItemStock Fis { get; set; } = null!;
        public virtual FacTobaccoIssueType IssueTypeNavigation { get; set; } = null!;
        public virtual FacItemInfo Item { get; set; } = null!;
        public virtual SetProduct Product { get; set; } = null!;
        public virtual FacItemUnit Unit { get; set; } = null!;
        public virtual ICollection<FacDailyToabaccoUse> FacDailyToabaccoUses { get; set; }
    }
}
