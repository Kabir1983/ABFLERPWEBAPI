using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsRegionSrwiseNapkinSalesTarget
    {
        public int Id { get; set; }
        public int RegionId { get; set; }
        public short ProductId { get; set; }
        public short TargetQty { get; set; }
        public bool? IsActive { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
