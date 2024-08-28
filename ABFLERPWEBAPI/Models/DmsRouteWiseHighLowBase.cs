using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsRouteWiseHighLowBase
    {
        public long Id { get; set; }
        public long RouteId { get; set; }
        public long Srid { get; set; }
        public int HighestSales { get; set; }
        public int LowestSales { get; set; }
        public int? BaseAbr { get; set; }
        public int? BaseH25 { get; set; }
        public int? BaseH12 { get; set; }
        public int? BaseAb8 { get; set; }
        public int? BaseK20 { get; set; }
        public int? BaseGb { get; set; }
        public int? BasePb { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
