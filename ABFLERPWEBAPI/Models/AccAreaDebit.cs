using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class AccAreaDebit
    {
        public long Id { get; set; }
        public int AreaId { get; set; }
        public long? ExpenseId { get; set; }
        public long? Bdid { get; set; }
        public long? Ctid { get; set; }
        public long AreaLedgerId { get; set; }
        public decimal Amount { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual SetArea Area { get; set; } = null!;
        public virtual AccAreaLedger AreaLedger { get; set; } = null!;
    }
}
