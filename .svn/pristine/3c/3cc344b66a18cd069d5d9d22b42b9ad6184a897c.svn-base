using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class HrmPitermination
    {
        public HrmPitermination()
        {
            HrmTerminationApprovals = new HashSet<HrmTerminationApproval>();
        }

        public int Id { get; set; }
        public int Piid { get; set; }
        public byte TerminationType { get; set; }
        public DateTime ApplyDate { get; set; }
        public DateTime EffectiveFromDate { get; set; }
        public string Reason { get; set; } = null!;
        public int ApplyById { get; set; }

        public virtual HrmPi ApplyBy { get; set; } = null!;
        public virtual HrmPi Pi { get; set; } = null!;
        public virtual FtTerminationType TerminationTypeNavigation { get; set; } = null!;
        public virtual ICollection<HrmTerminationApproval> HrmTerminationApprovals { get; set; }
    }
}
