using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class SetTourType
    {
        public SetTourType()
        {
            HrmTourAttendances = new HashSet<HrmTourAttendance>();
        }

        public byte Id { get; set; }
        public string TypeName { get; set; } = null!;
        public string? Description { get; set; }

        public virtual ICollection<HrmTourAttendance> HrmTourAttendances { get; set; }
    }
}
