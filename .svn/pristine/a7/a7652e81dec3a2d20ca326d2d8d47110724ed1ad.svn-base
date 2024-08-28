using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class AccDepoLedger
    {
        public AccDepoLedger()
        {
            AccDepoCredits = new HashSet<AccDepoCredit>();
            AccDepoDebits = new HashSet<AccDepoDebit>();
        }

        public long Dlid { get; set; }
        public int DepoId { get; set; }
        public decimal Amount { get; set; }
        public decimal Balance { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual SetDepo Depo { get; set; } = null!;
        public virtual ICollection<AccDepoCredit> AccDepoCredits { get; set; }
        public virtual ICollection<AccDepoDebit> AccDepoDebits { get; set; }
    }
}
