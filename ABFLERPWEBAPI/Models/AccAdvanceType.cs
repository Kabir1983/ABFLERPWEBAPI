using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class AccAdvanceType
    {
        public AccAdvanceType()
        {
            AccAdvances = new HashSet<AccAdvance>();
        }

        public byte Id { get; set; }
        public string TypeName { get; set; } = null!; 
        public bool IsActive { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual ICollection<AccAdvance> AccAdvances { get; set; }
    }
}
