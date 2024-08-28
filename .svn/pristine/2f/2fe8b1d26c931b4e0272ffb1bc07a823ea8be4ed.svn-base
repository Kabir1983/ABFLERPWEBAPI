using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class HrmTerminationApproval
    {
        public int Id { get; set; }
        public int TerminationId { get; set; }
        public byte ApprovalStatus { get; set; }
        public int ApprovedById { get; set; }

        public virtual HrmPi ApprovedBy { get; set; } = null!;
        public virtual HrmPitermination Termination { get; set; } = null!;
    }
}
