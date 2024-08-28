using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsIncentiveDetail
    {
        public long Id { get; set; }
        public long IncentiveId { get; set; }
        public short ProductId { get; set; }
        public int Quantity { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual DmsIncentiveMaster Incentive { get; set; } = null!;
        public virtual SetProduct Product { get; set; } = null!;
    }
}
