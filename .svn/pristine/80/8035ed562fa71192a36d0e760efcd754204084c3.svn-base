using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class AccDepoWiseBankAccount
    {
        public AccDepoWiseBankAccount()
        {
            AccBankDeposits = new HashSet<AccBankDeposit>();
            AccBankWiseAmouts = new HashSet<AccBankWiseAmout>();
        }

        public int BankAccountId { get; set; }
        public string AccountNo { get; set; } = null!;
        public string? AccountName { get; set; }
        public short BankBranchId { get; set; }
        public int? DepoId { get; set; }
        public int? AreaId { get; set; }
        public int? RegionId { get; set; }
        public bool? IsHeadOffice { get; set; }
        public int? FactoryId { get; set; }
        public bool IsActive { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual AccBankWiseBranch BankBranch { get; set; } = null!;
        public virtual SetDepo? Depo { get; set; }
        public virtual ICollection<AccBankDeposit> AccBankDeposits { get; set; }
        public virtual ICollection<AccBankWiseAmout> AccBankWiseAmouts { get; set; }
    }
}
