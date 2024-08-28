using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class FtApprovalStatus
    {
        public FtApprovalStatus()
        {
            HrmLeaveApprovals = new HashSet<HrmLeaveApproval>();
        }

        public byte Id { get; set; }
        public string StatusName { get; set; } = null!;

        public virtual ICollection<HrmLeaveApproval> HrmLeaveApprovals { get; set; }
    }
}
