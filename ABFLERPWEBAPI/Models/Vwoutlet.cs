using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class Vwoutlet
    {
        public int OutletId { get; set; }
        public string OutletCode { get; set; } = null!;
        public string OutletName { get; set; } = null!;
        public string? Owner { get; set; }
        public string? Address { get; set; }
        public int? ClusterId { get; set; }
        public string? ContactNo { get; set; }
        public int RouteId { get; set; }
        public int RouteOutletNo { get; set; }
        public bool IsActive { get; set; }
        public DateTime LastUpdate { get; set; }
        public bool IsNew { get; set; }
        public byte? BiriCigaretteStatus { get; set; }
        public int? UnionId { get; set; }
        public string? VillageName { get; set; }
        public string? MarketName { get; set; }
        public string RouteName { get; set; } = null!;
        public int TerritoryId { get; set; }
        public string TerrioryName { get; set; } = null!;
        public string UnionName { get; set; } = null!;
        public string ThanaName { get; set; } = null!;
        public string DistrictName { get; set; } = null!;
        public int IsLatLong { get; set; }
    }
}
