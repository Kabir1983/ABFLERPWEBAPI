using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsAreaStock
    {
        public DmsAreaStock()
        {
            DmsAreaChallanToAreaRequestDetails = new HashSet<DmsAreaChallanToAreaRequestDetail>();
            DmsAreaDeliveryChallanItemAs = new HashSet<DmsAreaDeliveryChallanItem>();
            DmsAreaDeliveryChallanItemReturnAs = new HashSet<DmsAreaDeliveryChallanItem>();
            DmsAreaOpeningStocks = new HashSet<DmsAreaOpeningStock>();
            DmsAreaReceivedItems = new HashSet<DmsAreaReceivedItem>();
            DmsAreaRecvFromAreaDetails = new HashSet<DmsAreaRecvFromAreaDetail>();
            DmsAreaReturnDetails = new HashSet<DmsAreaReturnDetail>();
            DmsDamageDetails = new HashSet<DmsDamageDetail>();
            DmsDamageReturnToDepoDetails = new HashSet<DmsDamageReturnToDepoDetail>();
            DmsDellarChallanItems = new HashSet<DmsDellarChallanItem>();
        }

        public long Asid { get; set; }
        public int AreaId { get; set; }
        public short ProductId { get; set; }
        public long Qty { get; set; }
        public long Balance { get; set; }
        public decimal Tp { get; set; }
        public byte StockType { get; set; }
        public DateTime? StockDate { get; set; }
        public DateTime? TransactionDate { get; set; }

        public virtual SetArea Area { get; set; } = null!;
        public virtual SetProduct Product { get; set; } = null!;
        public virtual ICollection<DmsAreaChallanToAreaRequestDetail> DmsAreaChallanToAreaRequestDetails { get; set; }
        public virtual ICollection<DmsAreaDeliveryChallanItem> DmsAreaDeliveryChallanItemAs { get; set; }
        public virtual ICollection<DmsAreaDeliveryChallanItem> DmsAreaDeliveryChallanItemReturnAs { get; set; }
        public virtual ICollection<DmsAreaOpeningStock> DmsAreaOpeningStocks { get; set; }
        public virtual ICollection<DmsAreaReceivedItem> DmsAreaReceivedItems { get; set; }
        public virtual ICollection<DmsAreaRecvFromAreaDetail> DmsAreaRecvFromAreaDetails { get; set; }
        public virtual ICollection<DmsAreaReturnDetail> DmsAreaReturnDetails { get; set; }
        public virtual ICollection<DmsDamageDetail> DmsDamageDetails { get; set; }
        public virtual ICollection<DmsDamageReturnToDepoDetail> DmsDamageReturnToDepoDetails { get; set; }
        public virtual ICollection<DmsDellarChallanItem> DmsDellarChallanItems { get; set; }
    }
}
