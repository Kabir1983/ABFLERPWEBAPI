using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsProductWiseMposalesTarget
    {
        public long Id { get; set; }
        public int EmployeeId { get; set; }
        public long ProductId { get; set; }
        public decimal SalesTarget { get; set; }
        public byte Month { get; set; }
        public short Year { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
