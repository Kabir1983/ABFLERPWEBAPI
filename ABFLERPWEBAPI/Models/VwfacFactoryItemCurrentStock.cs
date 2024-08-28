using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class VwfacFactoryItemCurrentStock
    {
        public long Fisid { get; set; }
        public byte FactoryId { get; set; }
        public int ItemId { get; set; }
        public decimal Qty { get; set; }
        public decimal Balance { get; set; }
        public short UnitId { get; set; }
        public decimal? UnitPrice { get; set; }
        public short StockType { get; set; }
        public DateTime StockDate { get; set; }
        public DateTime LastUpdate { get; set; }
        public long? Rn { get; set; }
    }
}
