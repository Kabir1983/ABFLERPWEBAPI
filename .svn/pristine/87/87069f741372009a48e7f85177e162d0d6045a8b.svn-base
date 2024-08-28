using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class SetLoanType
    {
        public SetLoanType()
        {
            HrmLoanApplications = new HashSet<HrmLoanApplication>();
        }

        public byte Id { get; set; }
        public string Name { get; set; } = null!;
        public bool IsActive { get; set; }

        public virtual ICollection<HrmLoanApplication> HrmLoanApplications { get; set; }
    }
}
