using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class HrmPayRollSalaryMaster
    {
        public HrmPayRollSalaryMaster()
        {
            HrmPayrollSalaryDetails = new HashSet<HrmPayrollSalaryDetail>();
        }

        public int Id { get; set; }
        public int ResponsibleId { get; set; }
        public byte Month { get; set; }
        public short Year { get; set; }
        public DateTime SalaryDate { get; set; }

        public virtual ICollection<HrmPayrollSalaryDetail> HrmPayrollSalaryDetails { get; set; }
    }
}
