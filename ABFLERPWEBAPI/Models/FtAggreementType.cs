using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class FtAggreementType
    {
        public FtAggreementType()
        {
            SetHrleaveProfiles = new HashSet<SetHrleaveProfile>();
        }

        public byte Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<SetHrleaveProfile> SetHrleaveProfiles { get; set; }
    }
}
