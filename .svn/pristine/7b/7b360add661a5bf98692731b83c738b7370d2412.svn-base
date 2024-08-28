using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class AccHoLedger
    {
        public AccHoLedger()
        {
            AccHoCredits = new HashSet<AccHoCredit>();
            AccHoDebits = new HashSet<AccHoDebit>();
        }

        public long Hlid { get; set; }
        public decimal Amount { get; set; }
        public decimal Balance { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual ICollection<AccHoCredit> AccHoCredits { get; set; }
        public virtual ICollection<AccHoDebit> AccHoDebits { get; set; }
    }
}
