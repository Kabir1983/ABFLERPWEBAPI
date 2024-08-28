using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class SetSrwiseRoute
    {
        public long Id { get; set; }
        public int RouteId { get; set; }
        public string? RouteCode { get; set; }
        public string PharmaSrcode { get; set; } = null!;
        public string AkijSrcode { get; set; } = null!;
        public int? Srid { get; set; }
        public int? TerritoryId { get; set; }
        public bool IsActive { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
