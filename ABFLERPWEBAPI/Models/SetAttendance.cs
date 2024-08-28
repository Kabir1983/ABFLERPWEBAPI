using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class SetAttendance
    {
        public long Id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime Date { get; set; }
        public byte Status { get; set; }
        public string SignInTime { get; set; } = null!;
        public string? SignOutTime { get; set; }
        public byte? IsApproved { get; set; }
        public string? SignInLatitude { get; set; }
        public string? SignInLongitude { get; set; }
        public string? SignInAddress { get; set; }
        public string? SignOutLatitude { get; set; }
        public string? SignOutLongitude { get; set; }
        public string? SignOutAddress { get; set; }
        public int InsertUserId { get; set; }
        public string? DeviceId { get; set; }
    }
}
