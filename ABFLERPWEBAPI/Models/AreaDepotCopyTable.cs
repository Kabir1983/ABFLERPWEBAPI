using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class AreaDepotCopyTable
    {
        public int AreaId { get; set; }
        public string AreaCode { get; set; } = null!;
        public string AreaName { get; set; } = null!;
        public string? AreaAddress { get; set; }
        public int RegionId { get; set; }
        public string? AccountCode { get; set; }
        public bool IsActive { get; set; }
        public DateTime LastUpdate { get; set; }
        public bool? AreaDepotType { get; set; }
    }
}
