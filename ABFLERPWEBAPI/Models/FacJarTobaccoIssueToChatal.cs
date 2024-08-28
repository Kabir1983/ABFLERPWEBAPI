using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class FacJarTobaccoIssueToChatal
    {
        public FacJarTobaccoIssueToChatal()
        {
            FacJarTobaccoReceiveFromChatals = new HashSet<FacJarTobaccoReceiveFromChatal>();
        }

        public long Id { get; set; }
        public byte FactoryId { get; set; }
        public long ChallanNo { get; set; }
        public DateTime Date { get; set; }
        public decimal JarTobaccoStock { get; set; }
        public decimal JarTobaccoIssue { get; set; }
        public short ProductId { get; set; }
        public int ItemId { get; set; }
        public short UnitId { get; set; }
        public decimal? UnitPrice { get; set; }
        public string? Remarks { get; set; }
        public bool? IsUse { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual SetFactory Factory { get; set; } = null!;
        public virtual FacItemInfo Item { get; set; } = null!;
        public virtual SetProduct Product { get; set; } = null!;
        public virtual FacItemUnit Unit { get; set; } = null!;
        public virtual ICollection<FacJarTobaccoReceiveFromChatal> FacJarTobaccoReceiveFromChatals { get; set; }
    }
}
