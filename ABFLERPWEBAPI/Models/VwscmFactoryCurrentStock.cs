using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class VwscmFactoryCurrentStock
    {
        public long Fsid { get; set; }
        public byte FactoryId { get; set; }
        public short ProductId { get; set; }
        public long Qty { get; set; }
        public long Balance { get; set; }
        public decimal Tp { get; set; }
        public byte StockType { get; set; }
        public DateTime StockDate { get; set; }
        public long? Rn { get; set; }
    }
}
