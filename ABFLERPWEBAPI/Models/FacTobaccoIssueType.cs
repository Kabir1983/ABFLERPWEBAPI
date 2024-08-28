using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class FacTobaccoIssueType
    {
        public FacTobaccoIssueType()
        {
            FacDailyTobaccoIssues = new HashSet<FacDailyTobaccoIssue>();
        }

        public byte Id { get; set; }
        public string IssueType { get; set; } = null!;

        public virtual ICollection<FacDailyTobaccoIssue> FacDailyTobaccoIssues { get; set; }
    }
}
