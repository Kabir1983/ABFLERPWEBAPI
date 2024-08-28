using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class SetDepo
    {
        public SetDepo()
        {
            AccDepoCredits = new HashSet<AccDepoCredit>();
            AccDepoDebits = new HashSet<AccDepoDebit>();
            AccDepoLedgers = new HashSet<AccDepoLedger>();
            AccDepoWiseBankAccounts = new HashSet<AccDepoWiseBankAccount>();
            AccIncomeExpenseMasters = new HashSet<AccIncomeExpenseMaster>();
            AccIncomeExpenses = new HashSet<AccIncomeExpense>();
            AccOthersIncomes = new HashSet<AccOthersIncome>();
            DmsDepoChallans = new HashSet<DmsDepoChallan>();
            DmsDepoDellarChallanToDamages = new HashSet<DmsDepoDellarChallanToDamage>();
            DmsDepoDellarChallans = new HashSet<DmsDepoDellarChallan>();
            DmsDepoRequisitions = new HashSet<DmsDepoRequisition>();
            DmsDepoStocks = new HashSet<DmsDepoStock>();
            DmsDepoToDepoChallans = new HashSet<DmsDepoToDepoChallan>();
            DmsDepoToDepoRequisitions = new HashSet<DmsDepoToDepoRequisition>();
            DmsDmreceivedFromDepos = new HashSet<DmsDmreceivedFromDepo>();
            DmsDmrecevedFromFactories = new HashSet<DmsDmrecevedFromFactory>();
            DmsFactoryChallans = new HashSet<DmsFactoryChallan>();
            DmsRequisionIndentations = new HashSet<DmsRequisionIndentation>();
            HrmPiemployements = new HashSet<HrmPiemployement>();
            HrmPitransfers = new HashSet<HrmPitransfer>();
            SetDeliveryMen = new HashSet<SetDeliveryMan>();
            SetDellars = new HashSet<SetDellar>();
            SetRegions = new HashSet<SetRegion>();
        }

        public int DepoId { get; set; }
        public int? Sln { get; set; }
        public string Name { get; set; } = null!;
        public string? Code { get; set; }
        public string? Address { get; set; }
        public bool? IsActive { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual ICollection<AccDepoCredit> AccDepoCredits { get; set; }
        public virtual ICollection<AccDepoDebit> AccDepoDebits { get; set; }
        public virtual ICollection<AccDepoLedger> AccDepoLedgers { get; set; }
        public virtual ICollection<AccDepoWiseBankAccount> AccDepoWiseBankAccounts { get; set; }
        public virtual ICollection<AccIncomeExpenseMaster> AccIncomeExpenseMasters { get; set; }
        public virtual ICollection<AccIncomeExpense> AccIncomeExpenses { get; set; }
        public virtual ICollection<AccOthersIncome> AccOthersIncomes { get; set; }
        public virtual ICollection<DmsDepoChallan> DmsDepoChallans { get; set; }
        public virtual ICollection<DmsDepoDellarChallanToDamage> DmsDepoDellarChallanToDamages { get; set; }
        public virtual ICollection<DmsDepoDellarChallan> DmsDepoDellarChallans { get; set; }
        public virtual ICollection<DmsDepoRequisition> DmsDepoRequisitions { get; set; }
        public virtual ICollection<DmsDepoStock> DmsDepoStocks { get; set; }
        public virtual ICollection<DmsDepoToDepoChallan> DmsDepoToDepoChallans { get; set; }
        public virtual ICollection<DmsDepoToDepoRequisition> DmsDepoToDepoRequisitions { get; set; }
        public virtual ICollection<DmsDmreceivedFromDepo> DmsDmreceivedFromDepos { get; set; }
        public virtual ICollection<DmsDmrecevedFromFactory> DmsDmrecevedFromFactories { get; set; }
        public virtual ICollection<DmsFactoryChallan> DmsFactoryChallans { get; set; }
        public virtual ICollection<DmsRequisionIndentation> DmsRequisionIndentations { get; set; }
        public virtual ICollection<HrmPiemployement> HrmPiemployements { get; set; }
        public virtual ICollection<HrmPitransfer> HrmPitransfers { get; set; }
        public virtual ICollection<SetDeliveryMan> SetDeliveryMen { get; set; }
        public virtual ICollection<SetDellar> SetDellars { get; set; }
        public virtual ICollection<SetRegion> SetRegions { get; set; }
    }
}
