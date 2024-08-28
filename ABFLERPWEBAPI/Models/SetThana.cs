using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class SetThana
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int DistrictId { get; set; }

        public virtual SetDistrict District { get; set; } = null!;
    }
}
