using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class SetDivisionWiseRegion
    {
        public int Drid { get; set; }
        public byte DivisionId { get; set; }
        public int RegionId { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsActive { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual SetDivision Division { get; set; } = null!;
        public virtual SetRegion Region { get; set; } = null!;
    }
}
