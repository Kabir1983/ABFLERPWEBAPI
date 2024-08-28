using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class AccCashOrDepositReceive
    {
        public long Id { get; set; }
        public long Ieid { get; set; }
        public long? CashTranId { get; set; }
        public long? BdepoistId { get; set; }
        public int ReceivedById { get; set; }
        public long? ReceiveNo { get; set; }
        public DateTime? ReceiveDate { get; set; }

        public virtual AccBankDeposit? Bdepoist { get; set; }
        public virtual AccCashTransfer? CashTran { get; set; }
        public virtual AccIncomeExpenseMaster Ie { get; set; } = null!;
    }
}
