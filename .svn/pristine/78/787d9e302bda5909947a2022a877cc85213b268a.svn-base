using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class HrmAttendance
    {
        public long Id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime Date { get; set; }
        public byte Status { get; set; }
        public string SignInTime { get; set; } = null!;
        public string? SignOutTime { get; set; }
        public bool IsApproved { get; set; }
        public int InsertUserId { get; set; }
        public string? DeviceId { get; set; }

        public virtual FtAttendanceStatus StatusNavigation { get; set; } = null!;
    }
}
