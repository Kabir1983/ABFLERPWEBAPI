using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class HrmPayrollSalaryDetail
    {
        public long Id { get; set; }
        public int SalaryMasterId { get; set; }
        public int EmployeeId { get; set; }
        public decimal BasicSalary { get; set; }
        public decimal MedicalAllowance { get; set; }
        public decimal HouseRent { get; set; }
        public decimal? Da { get; set; }
        public decimal? Ta { get; set; }
        public decimal? Bonus { get; set; }
        public decimal GrossSalary { get; set; }
        public decimal? Pf { get; set; }
        public decimal? LoanDeduction { get; set; }
        public decimal? AbsentDeduction { get; set; }
        public decimal? AdvanceSalaryDeduction { get; set; }
        public decimal NetSalary { get; set; }
        public decimal? Gratuity { get; set; }
        public decimal? Pfcompany { get; set; }
        public decimal TotalSalary { get; set; }
        public bool? IsPrinted { get; set; }

        public virtual HrmPi Employee { get; set; } = null!;
        public virtual HrmPayRollSalaryMaster SalaryMaster { get; set; } = null!;
    }
}
