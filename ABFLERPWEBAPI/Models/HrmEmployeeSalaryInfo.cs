using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class HrmEmployeeSalaryInfo
    {
        public int Id { get; set; }
        public int EmployeementId { get; set; }
        public decimal Basic { get; set; }
        public decimal? Ta { get; set; }
        public decimal? Da { get; set; }
        public decimal? HouseRent { get; set; }
        public decimal? Ma { get; set; }
        public decimal? GrossSalary { get; set; }
        public decimal TotalSalary { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual HrmPiemployement Employeement { get; set; } = null!;
    }
}
