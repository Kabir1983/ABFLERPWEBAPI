using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsProductWiseMposalesTargetRawDatum
    {
        public long Id { get; set; }
        public string Mpocode { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public int TargetProductQty { get; set; }
        public string? ErrorMessage { get; set; }
        public bool IsActive { get; set; }
        public bool IsProcess { get; set; }
        public long ResEmployeeId { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
