using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class HrmEmployeeShiftPattern
    {
        public HrmEmployeeShiftPattern()
        {
            HrmEmployeeShiftPatternDetails = new HashSet<HrmEmployeeShiftPatternDetail>();
        }

        public long Id { get; set; }
        public long AssignPatternId { get; set; }
        public short ShiftPatternId { get; set; }
        public byte WeekNo { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual HrmAssignEmployeeShiftPattern AssignPattern { get; set; } = null!;
        public virtual HrmShiftPattern ShiftPattern { get; set; } = null!;
        public virtual ICollection<HrmEmployeeShiftPatternDetail> HrmEmployeeShiftPatternDetails { get; set; }
    }
}
