using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class FtAttendanceStatus
    {
        public FtAttendanceStatus()
        {
            HrmAttendances = new HashSet<HrmAttendance>();
        }

        public byte Id { get; set; }
        public string Name { get; set; } = null!;
        public bool IsActive { get; set; }

        public virtual ICollection<HrmAttendance> HrmAttendances { get; set; }
    }
}
