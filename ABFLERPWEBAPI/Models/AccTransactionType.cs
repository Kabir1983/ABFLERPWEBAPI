using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class AccTransactionType
    {
        public AccTransactionType()
        {
            AccBankDeposits = new HashSet<AccBankDeposit>();
            AccBankWiseAmouts = new HashSet<AccBankWiseAmout>();
        }

        public short TransactionTypeId { get; set; }
        public string TransactionTypeName { get; set; } = null!;
        public bool IsActive { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual ICollection<AccBankDeposit> AccBankDeposits { get; set; }
        public virtual ICollection<AccBankWiseAmout> AccBankWiseAmouts { get; set; }
    }
}
