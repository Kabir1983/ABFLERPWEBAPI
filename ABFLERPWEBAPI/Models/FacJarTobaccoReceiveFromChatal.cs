using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class FacJarTobaccoReceiveFromChatal
    {
        public long Id { get; set; }
        public byte FactoryId { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ReceiveDate { get; set; }
        public long Jtic { get; set; }
        public decimal IssueJarTobacco { get; set; }
        public decimal ReceiveJarTobacco { get; set; }
        public decimal ShortageJarTobacco { get; set; }
        public string? Remarks { get; set; }
        public DateTime Lastupdate { get; set; }

        public virtual SetFactory Factory { get; set; } = null!;
        public virtual FacJarTobaccoIssueToChatal JticNavigation { get; set; } = null!;
    }
}
