using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class HrmLeaveApplication
    {
        public HrmLeaveApplication()
        {
            HrLeaveCancelApplications = new HashSet<HrLeaveCancelApplication>();
            HrmLeaveAppDetails = new HashSet<HrmLeaveAppDetail>();
            HrmLeaveApprovals = new HashSet<HrmLeaveApproval>();
        }

        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public byte LeaveProfileId { get; set; }
        public DateTime AppDate { get; set; }
        public DateTime LeaveFrom { get; set; }
        public DateTime LeaveTo { get; set; }
        public byte TotalLeave { get; set; }
        public string? Reason { get; set; }
        public string? AlternateConNo { get; set; }
        public int? AlternateEmployeeId { get; set; }
        public int ApplyById { get; set; }

        public virtual HrmPi Employee { get; set; } = null!;
        public virtual SetHrleaveProfile LeaveProfile { get; set; } = null!;
        public virtual ICollection<HrLeaveCancelApplication> HrLeaveCancelApplications { get; set; }
        public virtual ICollection<HrmLeaveAppDetail> HrmLeaveAppDetails { get; set; }
        public virtual ICollection<HrmLeaveApproval> HrmLeaveApprovals { get; set; }
    }
}
