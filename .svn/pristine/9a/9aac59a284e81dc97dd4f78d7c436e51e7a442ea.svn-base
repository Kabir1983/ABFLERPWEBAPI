using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class HrmAdvanceApproval
    {
        public int Id { get; set; }
        public int AdvanceId { get; set; }
        public byte ApprovalStatus { get; set; }
        public int ApprovedById { get; set; }

        public virtual HrmAdvanceApplication Advance { get; set; } = null!;
        public virtual HrmPi ApprovedBy { get; set; } = null!;
    }
}
