using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class HrmLeaveApproval
    {
        public int Id { get; set; }
        public int LeaveId { get; set; }
        public byte ApprovalStatus { get; set; }
        public int ApprovedById { get; set; }

        public virtual FtApprovalStatus ApprovalStatusNavigation { get; set; } = null!;
        public virtual HrmPi ApprovedBy { get; set; } = null!;
        public virtual HrmLeaveApplication Leave { get; set; } = null!;
    }
}
