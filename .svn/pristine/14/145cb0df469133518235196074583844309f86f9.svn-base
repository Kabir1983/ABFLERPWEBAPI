using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class HrmLoanApplication
    {
        public HrmLoanApplication()
        {
            HrmLoanApprovals = new HashSet<HrmLoanApproval>();
            HrmLoanInstallments = new HashSet<HrmLoanInstallment>();
            HrmLoanPaids = new HashSet<HrmLoanPaid>();
        }

        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public byte LoanTypeId { get; set; }
        public decimal GrossSalary { get; set; }
        public decimal LoanAmount { get; set; }
        public DateTime AppDate { get; set; }
        public DateTime LoanNeedDate { get; set; }
        public byte EffectiveMonth { get; set; }
        public short EffectiveYear { get; set; }
        public string? Note { get; set; }
        public int NoOfInstallment { get; set; }
        public int ApplyById { get; set; }
        public byte? PaidStatus { get; set; }

        public virtual HrmPi ApplyBy { get; set; } = null!;
        public virtual HrmPi Employee { get; set; } = null!;
        public virtual SetLoanType LoanType { get; set; } = null!;
        public virtual ICollection<HrmLoanApproval> HrmLoanApprovals { get; set; }
        public virtual ICollection<HrmLoanInstallment> HrmLoanInstallments { get; set; }
        public virtual ICollection<HrmLoanPaid> HrmLoanPaids { get; set; }
    }
}
