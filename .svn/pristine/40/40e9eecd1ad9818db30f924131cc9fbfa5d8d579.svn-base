using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class HrmShiftPattern
    {
        public HrmShiftPattern()
        {
            HrmEmployeeShiftPatterns = new HashSet<HrmEmployeeShiftPattern>();
            HrmShiftPatternDetails = new HashSet<HrmShiftPatternDetail>();
        }

        public short Id { get; set; }
        public short PatternCode { get; set; }
        public string PatternName { get; set; } = null!;
        public byte ShiftTypeId { get; set; }

        public virtual ICollection<HrmEmployeeShiftPattern> HrmEmployeeShiftPatterns { get; set; }
        public virtual ICollection<HrmShiftPatternDetail> HrmShiftPatternDetails { get; set; }
    }
}
