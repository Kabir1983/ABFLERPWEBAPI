using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsDellarChallanItem
    {
        public long ChallanItemId { get; set; }
        public long ChallanId { get; set; }
        public long Asid { get; set; }
        public short ProductId { get; set; }
        public long? PromotionId { get; set; }
        public long ChallanQty { get; set; }
        public long? ReturnQty { get; set; }
        public decimal Tp { get; set; }
        public int? SampleQty { get; set; }
        public int? SampleReturn { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? PayableAmount { get; set; }
        public int InsertUserId { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual DmsAreaStock As { get; set; } = null!;
        public virtual DmsDellarChallan Challan { get; set; } = null!;
        public virtual SetProduct Product { get; set; } = null!;
    }
}
