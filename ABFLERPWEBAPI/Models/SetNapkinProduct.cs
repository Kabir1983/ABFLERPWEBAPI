using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class SetNapkinProduct
    {
        public SetNapkinProduct()
        {
            DmsNapkinAreaOpeningStocks = new HashSet<DmsNapkinAreaOpeningStock>();
            DmsNapkinAreaReceivedItems = new HashSet<DmsNapkinAreaReceivedItem>();
            DmsNapkinAreaReturnDetails = new HashSet<DmsNapkinAreaReturnDetail>();
            DmsNapkinAreaStocks = new HashSet<DmsNapkinAreaStock>();
            DmsNapkinDepoChallanItems = new HashSet<DmsNapkinDepoChallanItem>();
            DmsNapkinDepoOpeningStocks = new HashSet<DmsNapkinDepoOpeningStock>();
            DmsNapkinDepoToDepoTransferDetails = new HashSet<DmsNapkinDepoToDepoTransferDetail>();
            DmsNapkinDepoToDepoTransferReceiveDetails = new HashSet<DmsNapkinDepoToDepoTransferReceiveDetail>();
            DmsNapkinDmreceivedItemFromFactories = new HashSet<DmsNapkinDmreceivedItemFromFactory>();
            DmsNapkinFactoryChallanDetails = new HashSet<DmsNapkinFactoryChallanDetail>();
            DmsNapkinFactoryOpeningStocks = new HashSet<DmsNapkinFactoryOpeningStock>();
            DmsNapkinFactoryReceives = new HashSet<DmsNapkinFactoryReceive>();
            DmsNapkinFactoryStocks = new HashSet<DmsNapkinFactoryStock>();
        }

        public short ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public string? Description { get; set; }
        public byte ProductCategory { get; set; }
        public byte Sticks { get; set; }
        public string? ShortName { get; set; }
        public bool IsActive { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual ICollection<DmsNapkinAreaOpeningStock> DmsNapkinAreaOpeningStocks { get; set; }
        public virtual ICollection<DmsNapkinAreaReceivedItem> DmsNapkinAreaReceivedItems { get; set; }
        public virtual ICollection<DmsNapkinAreaReturnDetail> DmsNapkinAreaReturnDetails { get; set; }
        public virtual ICollection<DmsNapkinAreaStock> DmsNapkinAreaStocks { get; set; }
        public virtual ICollection<DmsNapkinDepoChallanItem> DmsNapkinDepoChallanItems { get; set; }
        public virtual ICollection<DmsNapkinDepoOpeningStock> DmsNapkinDepoOpeningStocks { get; set; }
        public virtual ICollection<DmsNapkinDepoToDepoTransferDetail> DmsNapkinDepoToDepoTransferDetails { get; set; }
        public virtual ICollection<DmsNapkinDepoToDepoTransferReceiveDetail> DmsNapkinDepoToDepoTransferReceiveDetails { get; set; }
        public virtual ICollection<DmsNapkinDmreceivedItemFromFactory> DmsNapkinDmreceivedItemFromFactories { get; set; }
        public virtual ICollection<DmsNapkinFactoryChallanDetail> DmsNapkinFactoryChallanDetails { get; set; }
        public virtual ICollection<DmsNapkinFactoryOpeningStock> DmsNapkinFactoryOpeningStocks { get; set; }
        public virtual ICollection<DmsNapkinFactoryReceive> DmsNapkinFactoryReceives { get; set; }
        public virtual ICollection<DmsNapkinFactoryStock> DmsNapkinFactoryStocks { get; set; }
    }
}
