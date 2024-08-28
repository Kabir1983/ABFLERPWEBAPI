using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class HrmLoanPaid
    {
        public long Id { get; set; }
        public int LoanId { get; set; }
        public decimal InstallmentAmount { get; set; }
        public byte Month { get; set; }
        public short Year { get; set; }
        public DateTime PayDate { get; set; }

        public virtual HrmLoanApplication Loan { get; set; } = null!;
    }
}
