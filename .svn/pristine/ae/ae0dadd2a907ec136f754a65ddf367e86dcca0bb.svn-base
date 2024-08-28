using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class SetPostOffice
    {
        public int Id { get; set; }
        public string? PostCode { get; set; }
        public string Name { get; set; } = null!;
        public int DistrictId { get; set; }
        public bool? IsActive { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual SetDistrict District { get; set; } = null!;
    }
}
