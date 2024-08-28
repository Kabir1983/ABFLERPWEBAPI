using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class SetHrmshiftType
    {
        public SetHrmshiftType()
        {
            HrmShiftProfiles = new HashSet<HrmShiftProfile>();
        }

        public byte Id { get; set; }
        public byte CategoryId { get; set; }
        public string TypeName { get; set; } = null!;
        public string? Description { get; set; }
        public bool IsActive { get; set; }

        public virtual SetHrmshiftCategory Category { get; set; } = null!;
        public virtual ICollection<HrmShiftProfile> HrmShiftProfiles { get; set; }
    }
}
