using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class SetSalah
    {
        public int TerritoryId { get; set; }
        public string TerritoryCode { get; set; } = null!;
        public string Name { get; set; } = null!;
        public int AreaId { get; set; }
        public string? Address { get; set; }
        public byte TerritoryTypeId { get; set; }
        public bool IsActive { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
