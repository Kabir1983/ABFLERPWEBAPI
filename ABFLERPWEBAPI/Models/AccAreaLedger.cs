using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class AccAreaLedger
    {
        public AccAreaLedger()
        {
            AccAreaDebits = new HashSet<AccAreaDebit>();
        }

        public long Alid { get; set; }
        public int AreaId { get; set; }
        public decimal Amount { get; set; }
        public decimal Balance { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual SetArea Area { get; set; } = null!;
        public virtual ICollection<AccAreaDebit> AccAreaDebits { get; set; }
    }
}
