using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class HrmLoanInstallment
    {
        public long Id { get; set; }
        public int LoanId { get; set; }
        public decimal InstallmentAmount { get; set; }
        public byte Month { get; set; }
        public short Year { get; set; }
        public int ApprovedById { get; set; }
        public bool IsActive { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual HrmLoanApplication Loan { get; set; } = null!;
    }
}
