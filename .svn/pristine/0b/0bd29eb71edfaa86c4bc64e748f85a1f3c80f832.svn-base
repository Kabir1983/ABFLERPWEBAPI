using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class AccBank
    {
        public AccBank()
        {
            AccBankWiseBranches = new HashSet<AccBankWiseBranch>();
        }

        public byte BankId { get; set; }
        public string BankName { get; set; } = null!;
        public bool IsActive { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual ICollection<AccBankWiseBranch> AccBankWiseBranches { get; set; }
    }
}
