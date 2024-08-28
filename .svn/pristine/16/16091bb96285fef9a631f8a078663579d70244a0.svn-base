using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class SetDivision
    {
        public SetDivision()
        {
            HrmPiemployements = new HashSet<HrmPiemployement>();
            SetDivisionWiseRegions = new HashSet<SetDivisionWiseRegion>();
            SetDivsionWiseDepartments = new HashSet<SetDivsionWiseDepartment>();
        }

        public byte DivisionId { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime LastUpdate { get; set; }

        public virtual ICollection<HrmPiemployement> HrmPiemployements { get; set; }
        public virtual ICollection<SetDivisionWiseRegion> SetDivisionWiseRegions { get; set; }
        public virtual ICollection<SetDivsionWiseDepartment> SetDivsionWiseDepartments { get; set; }
    }
}
