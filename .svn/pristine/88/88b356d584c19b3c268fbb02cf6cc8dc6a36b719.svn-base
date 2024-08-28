using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class SetNapkinOutletType
    {
        public SetNapkinOutletType()
        {
            SetNapkinOutlets = new HashSet<SetNapkinOutlet>();
        }

        public byte Id { get; set; }
        public string TypeName { get; set; } = null!;
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual ICollection<SetNapkinOutlet> SetNapkinOutlets { get; set; }
    }
}
