using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsFactoryStock
    {
        public DmsFactoryStock()
        {
            DmsDamageReceivedItemFromDepos = new HashSet<DmsDamageReceivedItemFromDepo>();
            DmsDepoReturnReceiveDetails = new HashSet<DmsDepoReturnReceiveDetail>();
            DmsFactoryChallanDetails = new HashSet<DmsFactoryChallanDetail>();
            DmsFactoryOpeningStocks = new HashSet<DmsFactoryOpeningStock>();
            DmsFactoryReceives = new HashSet<DmsFactoryReceive>();
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

        public virtual SetFactory Factory { get; set; } = null!;
        public virtual SetProduct Product { get; set; } = null!;
        public virtual ICollection<DmsDamageReceivedItemFromDepo> DmsDamageReceivedItemFromDepos { get; set; }
        public virtual ICollection<DmsDepoReturnReceiveDetail> DmsDepoReturnReceiveDetails { get; set; }
        public virtual ICollection<DmsFactoryChallanDetail> DmsFactoryChallanDetails { get; set; }
        public virtual ICollection<DmsFactoryOpeningStock> DmsFactoryOpeningStocks { get; set; }
        public virtual ICollection<DmsFactoryReceive> DmsFactoryReceives { get; set; }
    }
}
