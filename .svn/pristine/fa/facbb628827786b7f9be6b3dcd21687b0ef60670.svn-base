using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class SetDepartment
    {
        public SetDepartment()
        {
            HrmPiemployements = new HashSet<HrmPiemployement>();
            SetDivsionWiseDepartments = new HashSet<SetDivsionWiseDepartment>();
        }

        public byte DepartmentId { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual ICollection<HrmPiemployement> HrmPiemployements { get; set; }
        public virtual ICollection<SetDivsionWiseDepartment> SetDivsionWiseDepartments { get; set; }
    }
}
