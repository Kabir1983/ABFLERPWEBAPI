using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class AccBankWiseBranch
    {
        public AccBankWiseBranch()
        {
            AccBankDeposits = new HashSet<AccBankDeposit>();
            AccDepoWiseBankAccounts = new HashSet<AccDepoWiseBankAccount>();
        }

        public short BranchId { get; set; }
        public byte BankId { get; set; }
        public string BranchName { get; set; } = null!;
        public string? Code { get; set; }
        public int? AreaId { get; set; }
        public int? DepoId { get; set; }
        public string? BranchAddress { get; set; }
        public bool IsActive { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual AccBank Bank { get; set; } = null!;
        public virtual ICollection<AccBankDeposit> AccBankDeposits { get; set; }
        public virtual ICollection<AccDepoWiseBankAccount> AccDepoWiseBankAccounts { get; set; }
    }
}
