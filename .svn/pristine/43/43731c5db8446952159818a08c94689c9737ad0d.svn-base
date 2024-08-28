using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class SetSection
    {
        public SetSection()
        {
            HrmPiemployements = new HashSet<HrmPiemployement>();
            SetDepartmentWiseSections = new HashSet<SetDepartmentWiseSection>();
        }

        public byte SectionId { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual ICollection<HrmPiemployement> HrmPiemployements { get; set; }
        public virtual ICollection<SetDepartmentWiseSection> SetDepartmentWiseSections { get; set; }
    }
}
