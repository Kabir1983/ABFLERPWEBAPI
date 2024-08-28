using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class SetRouteBackUp
    {
        public int RouteId { get; set; }
        public string RouteCode { get; set; } = null!;
        public string RouteName { get; set; } = null!;
        public int? TerritoryId { get; set; }
        public bool IsActive { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
