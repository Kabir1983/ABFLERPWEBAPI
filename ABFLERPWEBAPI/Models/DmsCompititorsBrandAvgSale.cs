using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsCompititorsBrandAvgSale
    {
        public int Id { get; set; }
        public int? AreaId { get; set; }
        public int? Territory { get; set; }
        public int Unit { get; set; }
        public int ComBrandId { get; set; }
        public decimal AvgSales { get; set; }
        public short ComBrandType { get; set; }
        public long ResEmployeeId { get; set; }
        public bool IsActive { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
