using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsSrandRouteWiseSalesTarget
    {
        public long Id { get; set; }
        public int RouteId { get; set; }
        public int Srid { get; set; }
        public short ProductId { get; set; }
        public long TargetQty { get; set; }
        public short Outlet { get; set; }
        public short Memo { get; set; }
        public short SmokerContact { get; set; }
        public short Month { get; set; }
        public short Year { get; set; }
        public bool? IsActive { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
