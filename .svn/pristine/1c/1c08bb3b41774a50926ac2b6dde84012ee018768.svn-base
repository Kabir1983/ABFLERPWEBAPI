using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class FtHrleaveType
    {
        public FtHrleaveType()
        {
            SetHrleaveProfiles = new HashSet<SetHrleaveProfile>();
            SetLeaveTypes = new HashSet<SetLeaveType>();
        }

        public byte Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public bool IsActive { get; set; }
        public bool IsSpecial { get; set; }

        public virtual ICollection<SetHrleaveProfile> SetHrleaveProfiles { get; set; }
        public virtual ICollection<SetLeaveType> SetLeaveTypes { get; set; }
    }
}
