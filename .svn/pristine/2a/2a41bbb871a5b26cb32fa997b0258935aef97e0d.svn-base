using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsDellarPromotion
    {
        public long Id { get; set; }
        public int DellarId { get; set; }
        public short ProductId { get; set; }
        public decimal? Percentage { get; set; }
        public int? MinValue { get; set; }
        public decimal? DiscountValue { get; set; }
        public bool IsActive { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual SetDellar Dellar { get; set; } = null!;
    }
}
