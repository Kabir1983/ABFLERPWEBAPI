using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class AccHoDebit
    {
        public long Id { get; set; }
        public long? ExpenseId { get; set; }
        public long? Bdid { get; set; }
        public long Hlid { get; set; }
        public decimal Amount { get; set; }
        public int ResponsibleId { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual AccBankDeposit? Bd { get; set; }
        public virtual AccIncomeExpenseMaster? Expense { get; set; }
        public virtual AccHoLedger Hl { get; set; } = null!;
    }
}
