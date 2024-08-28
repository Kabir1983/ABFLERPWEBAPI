using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class HrmEmployeeShiftPatternDetail
    {
        public long Id { get; set; }
        public long EmpPatternId { get; set; }
        public DateTime WorkingDay { get; set; }

        public virtual HrmEmployeeShiftPattern EmpPattern { get; set; } = null!;
    }
}
