using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsNapkinAreaStock
    {
        public DmsNapkinAreaStock()
        {
            DmsNapkinAreaOpeningStocks = new HashSet<DmsNapkinAreaOpeningStock>();
            DmsNapkinAreaReceivedItems = new HashSet<DmsNapkinAreaReceivedItem>();
            DmsNapkinAreaReturnDetails = new HashSet<DmsNapkinAreaReturnDetail>();
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

        public virtual SetNapkinProduct Product { get; set; } = null!;
        public virtual ICollection<DmsNapkinAreaOpeningStock> DmsNapkinAreaOpeningStocks { get; set; }
        public virtual ICollection<DmsNapkinAreaReceivedItem> DmsNapkinAreaReceivedItems { get; set; }
        public virtual ICollection<DmsNapkinAreaReturnDetail> DmsNapkinAreaReturnDetails { get; set; }
    }
}
