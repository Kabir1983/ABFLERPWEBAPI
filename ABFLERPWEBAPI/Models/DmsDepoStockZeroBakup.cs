using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsDepoStockZeroBakup
    {
        public long Dsid { get; set; }
        public int DepoId { get; set; }
        public short ProductId { get; set; }
        public byte StockType { get; set; }
        public long Qty { get; set; }
        public long Balance { get; set; }
        public decimal Tp { get; set; }
        public DateTime StockDate { get; set; }
    }
}
