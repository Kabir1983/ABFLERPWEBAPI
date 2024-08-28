using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class HrmPipromotion
    {
        public int PromotionId { get; set; }
        public int Pisid { get; set; }
        public byte EmployeeCategoryId { get; set; }
        public byte JobPositionId { get; set; }
        public byte PayGradeId { get; set; }
        public byte DesignationId { get; set; }
        public byte EffectiveMonth { get; set; }
        public short EffectiveYear { get; set; }
        public bool? IsDefault { get; set; }
        public bool? IsActive { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual SetHrdesignation Designation { get; set; } = null!;
        public virtual SetHremployeeCategory EmployeeCategory { get; set; } = null!;
        public virtual SetJobPosition JobPosition { get; set; } = null!;
        public virtual SetPayGrade PayGrade { get; set; } = null!;
        public virtual HrmPi Pis { get; set; } = null!;
    }
}
