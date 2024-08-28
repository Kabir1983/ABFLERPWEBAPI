using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class HrmAssignEmployeeShiftPattern
    {
        public HrmAssignEmployeeShiftPattern()
        {
            HrmEmployeeShiftPatterns = new HashSet<HrmEmployeeShiftPattern>();
        }

        public long Id { get; set; }
        public int EmployeeId { get; set; }
        public byte ShiftTypeId { get; set; }
        public DateTime AssignDate { get; set; }
        public int? AssignById { get; set; }
        public byte WeekFrom { get; set; }
        public byte WeekTo { get; set; }
        public bool IsContinue { get; set; }

        public virtual ICollection<HrmEmployeeShiftPattern> HrmEmployeeShiftPatterns { get; set; }
    }
}
