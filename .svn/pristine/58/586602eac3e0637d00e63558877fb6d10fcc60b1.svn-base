using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class SetHrdesignation
    {
        public SetHrdesignation()
        {
            HrmPiemployements = new HashSet<HrmPiemployement>();
        }

        public byte Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public byte? PositionId { get; set; }
        public bool IsActive { get; set; }

        public virtual SetJobPosition? Position { get; set; }
        public virtual ICollection<HrmPiemployement> HrmPiemployements { get; set; }
    }
}
