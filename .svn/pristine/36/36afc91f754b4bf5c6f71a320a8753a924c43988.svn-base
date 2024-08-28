using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsNapkinDepoStock
    {
        public DmsNapkinDepoStock()
        {
            DmsNapkinAreaReturnReceiveDetails = new HashSet<DmsNapkinAreaReturnReceiveDetail>();
            DmsNapkinDepoChallanItems = new HashSet<DmsNapkinDepoChallanItem>();
            DmsNapkinDepoOpeningStocks = new HashSet<DmsNapkinDepoOpeningStock>();
            DmsNapkinDepoToDepoTransferDetails = new HashSet<DmsNapkinDepoToDepoTransferDetail>();
            DmsNapkinDepoToDepoTransferReceiveDetails = new HashSet<DmsNapkinDepoToDepoTransferReceiveDetail>();
            DmsNapkinDmreceivedItemFromFactories = new HashSet<DmsNapkinDmreceivedItemFromFactory>();
        }

        public long Dsid { get; set; }
        public int DepoId { get; set; }
        public short ProductId { get; set; }
        public byte StockType { get; set; }
        public long Qty { get; set; }
        public long Balance { get; set; }
        public decimal Tp { get; set; }
        public DateTime StockDate { get; set; }

        public virtual ICollection<DmsNapkinAreaReturnReceiveDetail> DmsNapkinAreaReturnReceiveDetails { get; set; }
        public virtual ICollection<DmsNapkinDepoChallanItem> DmsNapkinDepoChallanItems { get; set; }
        public virtual ICollection<DmsNapkinDepoOpeningStock> DmsNapkinDepoOpeningStocks { get; set; }
        public virtual ICollection<DmsNapkinDepoToDepoTransferDetail> DmsNapkinDepoToDepoTransferDetails { get; set; }
        public virtual ICollection<DmsNapkinDepoToDepoTransferReceiveDetail> DmsNapkinDepoToDepoTransferReceiveDetails { get; set; }
        public virtual ICollection<DmsNapkinDmreceivedItemFromFactory> DmsNapkinDmreceivedItemFromFactories { get; set; }
    }
}
