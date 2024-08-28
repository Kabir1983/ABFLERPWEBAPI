using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class AccHoCredit
    {
        public long Hcid { get; set; }
        public long? Bdid { get; set; }
        public long? Ctid { get; set; }
        public long Hlid { get; set; }
        public long Mrno { get; set; }
        public decimal Amount { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual AccBankDeposit? Bd { get; set; }
        public virtual AccCashTransfer? Ct { get; set; }
        public virtual AccHoLedger Hl { get; set; } = null!;
    }
}
