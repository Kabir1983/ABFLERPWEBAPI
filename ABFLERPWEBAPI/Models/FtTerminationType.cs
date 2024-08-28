using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class FtTerminationType
    {
        public FtTerminationType()
        {
            HrmPiterminations = new HashSet<HrmPitermination>();
        }

        public byte Id { get; set; }
        public string Name { get; set; } = null!;
        public bool IsActive { get; set; }

        public virtual ICollection<HrmPitermination> HrmPiterminations { get; set; }
    }
}
