using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class AccBankDeposit
    {
        public AccBankDeposit()
        {
            AccCashOrDepositReceives = new HashSet<AccCashOrDepositReceive>();
            AccDepoDebits = new HashSet<AccDepoDebit>();
            AccHoCredits = new HashSet<AccHoCredit>();
            AccHoDebits = new HashSet<AccHoDebit>();
        }

        public long Id { get; set; }
        public long Ieid { get; set; }
        public DateTime Date { get; set; }
        public short TransactionTypeId { get; set; }
        public decimal Amount { get; set; }
        public int? ResponsibleId { get; set; }
        public short DepositBbid { get; set; }
        public int? ReceiveDbaid { get; set; }
        public short? ReceiveBbid { get; set; }
        public DateTime? DdPayOrderDate { get; set; }
        public string? DdPayOrderNo { get; set; }
        public int? AreaId { get; set; }
        public int? RegionId { get; set; }
        public int? DepoId { get; set; }
        public byte? FactoryId { get; set; }
        public bool IsHeadOffice { get; set; }
        public bool IsReceive { get; set; }
        public string? Remarks { get; set; }

        public virtual AccBankWiseBranch DepositBb { get; set; } = null!;
        public virtual AccIncomeExpenseMaster Ie { get; set; } = null!;
        public virtual AccDepoWiseBankAccount? ReceiveDba { get; set; }
        public virtual AccTransactionType TransactionType { get; set; } = null!;
        public virtual ICollection<AccCashOrDepositReceive> AccCashOrDepositReceives { get; set; }
        public virtual ICollection<AccDepoDebit> AccDepoDebits { get; set; }
        public virtual ICollection<AccHoCredit> AccHoCredits { get; set; }
        public virtual ICollection<AccHoDebit> AccHoDebits { get; set; }
    }
}
