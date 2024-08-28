using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class HrmAdvanceApplication
    {
        public HrmAdvanceApplication()
        {
            HrmAdvanceApprovals = new HashSet<HrmAdvanceApproval>();
            HrmAdvanceRepays = new HashSet<HrmAdvanceRepay>();
        }

        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public decimal GrossSalary { get; set; }
        public decimal Amount { get; set; }
        public DateTime AppDate { get; set; }
        public DateTime NeedDate { get; set; }
        public byte EffectiveMonth { get; set; }
        public short EffectiveYear { get; set; }
        public string? Note { get; set; }
        public int ApplyById { get; set; }

        public virtual HrmPi ApplyBy { get; set; } = null!;
        public virtual HrmPi Employee { get; set; } = null!;
        public virtual ICollection<HrmAdvanceApproval> HrmAdvanceApprovals { get; set; }
        public virtual ICollection<HrmAdvanceRepay> HrmAdvanceRepays { get; set; }
    }
}
