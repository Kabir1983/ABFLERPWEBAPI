using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class HrmLoanApproval
    {
        public int Id { get; set; }
        public int LoanId { get; set; }
        public byte ApprovalStatus { get; set; }
        public int ApprovedById { get; set; }

        public virtual HrmPi ApprovedBy { get; set; } = null!;
        public virtual HrmLoanApplication Loan { get; set; } = null!;
    }
}
