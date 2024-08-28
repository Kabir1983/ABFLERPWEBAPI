using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class AccIncomeExpenseMaster
    {
        public AccIncomeExpenseMaster()
        {
            AccAdvances = new HashSet<AccAdvance>();
            AccBankDeposits = new HashSet<AccBankDeposit>();
            AccCashOrDepositReceives = new HashSet<AccCashOrDepositReceive>();
            AccCashTransfers = new HashSet<AccCashTransfer>();
            AccDepoDebits = new HashSet<AccDepoDebit>();
            AccHoDebits = new HashSet<AccHoDebit>();
            AccHouseRentMonthlies = new HashSet<AccHouseRentMonthly>();
            AccIncomeExpenseDetails = new HashSet<AccIncomeExpenseDetail>();
            AccOpeningBalances = new HashSet<AccOpeningBalance>();
            AccOthersIncomes = new HashSet<AccOthersIncome>();
            DmsAreaChallanWisePayments = new HashSet<DmsAreaChallanWisePayment>();
            DmsAreaDeliveryChallans = new HashSet<DmsAreaDeliveryChallan>();
            DmsDellarChallans = new HashSet<DmsDellarChallan>();
            DmsDepoDellarChallans = new HashSet<DmsDepoDellarChallan>();
        }

        public long Id { get; set; }
        public string? VoucherNo { get; set; }
        public int? ResponsibleId { get; set; }
        public int? AreaId { get; set; }
        public int? RegionId { get; set; }
        public int? DepoId { get; set; }
        public byte? FactoryId { get; set; }
        public bool IsHeadOffice { get; set; }
        public byte IeheaderId { get; set; }
        public decimal Amount { get; set; }
        public decimal Balance { get; set; }
        public DateTime PayDate { get; set; }
        public string? Description { get; set; }
        public DateTime? Iedate { get; set; }

        public virtual SetArea? Area { get; set; }
        public virtual SetDepo? Depo { get; set; }
        public virtual SetFactory? Factory { get; set; }
        public virtual SetRegion? Region { get; set; }
        public virtual ICollection<AccAdvance> AccAdvances { get; set; }
        public virtual ICollection<AccBankDeposit> AccBankDeposits { get; set; }
        public virtual ICollection<AccCashOrDepositReceive> AccCashOrDepositReceives { get; set; }
        public virtual ICollection<AccCashTransfer> AccCashTransfers { get; set; }
        public virtual ICollection<AccDepoDebit> AccDepoDebits { get; set; }
        public virtual ICollection<AccHoDebit> AccHoDebits { get; set; }
        public virtual ICollection<AccHouseRentMonthly> AccHouseRentMonthlies { get; set; }
        public virtual ICollection<AccIncomeExpenseDetail> AccIncomeExpenseDetails { get; set; }
        public virtual ICollection<AccOpeningBalance> AccOpeningBalances { get; set; }
        public virtual ICollection<AccOthersIncome> AccOthersIncomes { get; set; }
        public virtual ICollection<DmsAreaChallanWisePayment> DmsAreaChallanWisePayments { get; set; }
        public virtual ICollection<DmsAreaDeliveryChallan> DmsAreaDeliveryChallans { get; set; }
        public virtual ICollection<DmsDellarChallan> DmsDellarChallans { get; set; }
        public virtual ICollection<DmsDepoDellarChallan> DmsDepoDellarChallans { get; set; }
    }
}
