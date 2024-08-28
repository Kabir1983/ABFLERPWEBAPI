using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class HrmAdvanceRepay
    {
        public long Id { get; set; }
        public int AdvanceId { get; set; }
        public decimal Amount { get; set; }
        public byte Month { get; set; }
        public short Year { get; set; }
        public int ApprovedById { get; set; }
        public bool IsActive { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual HrmAdvanceApplication Advance { get; set; } = null!;
    }
}
