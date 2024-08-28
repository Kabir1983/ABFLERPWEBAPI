using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class AccDepoDebit
    {
        public long Id { get; set; }
        public int DepoId { get; set; }
        public long? ExpenseId { get; set; }
        public long? Bdid { get; set; }
        public long? Ctid { get; set; }
        public long Dlid { get; set; }
        public decimal Amount { get; set; }
        public DateTime LastUpdate { get; set; }
        public int ResponsibleId { get; set; }

        public virtual AccBankDeposit? Bd { get; set; }
        public virtual AccCashTransfer? Ct { get; set; }
        public virtual SetDepo Depo { get; set; } = null!;
        public virtual AccDepoLedger Dl { get; set; } = null!;
        public virtual AccIncomeExpenseMaster? Expense { get; set; }
    }
}
