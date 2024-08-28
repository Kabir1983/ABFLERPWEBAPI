using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsFactoryProductionAllocation
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public byte Month { get; set; }
        public short Year { get; set; }
        public int FactoryId { get; set; }
        public short ProductId { get; set; }
        public long Qty { get; set; }
        public int EmployeeId { get; set; }
        public int Smid { get; set; }
        public string? Remarks { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
