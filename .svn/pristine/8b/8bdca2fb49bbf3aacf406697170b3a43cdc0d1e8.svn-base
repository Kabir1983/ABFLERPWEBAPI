using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsDepoDellarChallanItem
    {
        public long ChallanItemId { get; set; }
        public long DchallanId { get; set; }
        public long Dsid { get; set; }
        public short ProductId { get; set; }
        public long? PromotionId { get; set; }
        public long ChallanQty { get; set; }
        public decimal Tp { get; set; }
        public decimal GrossTotal { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal PayableAmount { get; set; }
        public int InsertUserId { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual DmsDepoDellarChallan Dchallan { get; set; } = null!;
        public virtual DmsDepoStock Ds { get; set; } = null!;
        public virtual SetProduct Product { get; set; } = null!;
    }
}
