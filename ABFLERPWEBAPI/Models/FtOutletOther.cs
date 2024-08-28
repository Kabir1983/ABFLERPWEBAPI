using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class FtOutletOther
    {
        public int OutletId { get; set; }
        public string OutletCode { get; set; } = null!;
        public string OutletName { get; set; } = null!;
        public string? Owner { get; set; }
        public string? Address { get; set; }
        public string? ContactNo { get; set; }
        public bool IsActive { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
