using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class FtGender
    {
        public FtGender()
        {
            HrmPis = new HashSet<HrmPi>();
            SetHrleaveProfiles = new HashSet<SetHrleaveProfile>();
        }

        public byte Id { get; set; }
        public string Name { get; set; } = null!;
        public bool IsActive { get; set; }

        public virtual ICollection<HrmPi> HrmPis { get; set; }
        public virtual ICollection<SetHrleaveProfile> SetHrleaveProfiles { get; set; }
    }
}
