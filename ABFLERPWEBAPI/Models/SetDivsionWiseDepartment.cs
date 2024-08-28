using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class SetDivsionWiseDepartment
    {
        public SetDivsionWiseDepartment()
        {
            SetDepartmentWiseSections = new HashSet<SetDepartmentWiseSection>();
        }

        public short Id { get; set; }
        public byte DivisionId { get; set; }
        public byte DepartmentId { get; set; }
        public bool IsActive { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual SetDepartment Department { get; set; } = null!;
        public virtual SetDivision Division { get; set; } = null!;
        public virtual ICollection<SetDepartmentWiseSection> SetDepartmentWiseSections { get; set; }
    }
}
