using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsNapkinFactoryStock
    {
        public DmsNapkinFactoryStock()
        {
            DmsNapkinFactoryChallanDetails = new HashSet<DmsNapkinFactoryChallanDetail>();
            DmsNapkinFactoryOpeningStocks = new HashSet<DmsNapkinFactoryOpeningStock>();
            DmsNapkinFactoryReceives = new HashSet<DmsNapkinFactoryReceive>();
        }

        public long Fsid { get; set; }
        public byte FactoryId { get; set; }
        public short ProductId { get; set; }
        public long Qty { get; set; }
        public long Balance { get; set; }
        public decimal Tp { get; set; }
        /// <summary>
        /// if 1 then fresh stock if 2 then damage stock
        /// </summary>
        public byte StockType { get; set; }
        public DateTime StockDate { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual SetFactory Factory { get; set; } = null!;
        public virtual SetNapkinProduct Product { get; set; } = null!;
        public virtual ICollection<DmsNapkinFactoryChallanDetail> DmsNapkinFactoryChallanDetails { get; set; }
        public virtual ICollection<DmsNapkinFactoryOpeningStock> DmsNapkinFactoryOpeningStocks { get; set; }
        public virtual ICollection<DmsNapkinFactoryReceive> DmsNapkinFactoryReceives { get; set; }
    }
}
