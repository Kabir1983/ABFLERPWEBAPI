using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class SetProductWiseIncentive
    {
        public short Piid { get; set; }
        public short ProductId { get; set; }
        public int MinProductQty { get; set; }
        public decimal IncentivePercentage { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime LastUpdate { get; set; }
        public bool IsActive { get; set; }

        public virtual SetProduct Product { get; set; } = null!;
    }
}
