using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class SetNapkinOutlet
    {
        public int OutletId { get; set; }
        public byte OutletTypeId { get; set; }
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

        public virtual SetNapkinOutletType OutletType { get; set; } = null!;
    }
}
