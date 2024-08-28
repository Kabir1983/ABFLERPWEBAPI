using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class SetDepartmentWiseSection
    {
        public short Id { get; set; }
        public short DivisionDeparmentId { get; set; }
        public byte SectionId { get; set; }
        public bool IsActive { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual SetDivsionWiseDepartment DivisionDeparment { get; set; } = null!;
        public virtual SetSection Section { get; set; } = null!;
    }
}
