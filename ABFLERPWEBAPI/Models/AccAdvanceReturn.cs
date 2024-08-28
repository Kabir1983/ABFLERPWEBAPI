using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class AccAdvanceReturn
    {
        public long Id { get; set; }
        public long AdvanceId { get; set; }
        public decimal? AdjustAmountCash { get; set; }
        public decimal? AdjustAmountVoucher { get; set; }
        public decimal? DueAmount { get; set; }
        public DateTime AdjustDate { get; set; }
        public byte ReturnType { get; set; }
        public byte AdjustType { get; set; }
        public long? Iemid { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual AccAdvance Advance { get; set; } = null!;
    }
}
