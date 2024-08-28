using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class FacJarTamakFactoryItemStock
    {
        public long Jtfisid { get; set; }
        public byte FactoryId { get; set; }
        public int ItemId { get; set; }
        public decimal Qty { get; set; }
        public decimal Balance { get; set; }
        public short UnitId { get; set; }
        public decimal? UnitPrice { get; set; }
        public short StockType { get; set; }
        public DateTime StockDate { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual SetFactory Factory { get; set; } = null!;
        public virtual FacItemInfo Item { get; set; } = null!;
        public virtual FacItemUnit Unit { get; set; } = null!;
    }
}
