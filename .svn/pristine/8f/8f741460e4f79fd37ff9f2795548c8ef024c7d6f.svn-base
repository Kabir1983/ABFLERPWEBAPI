using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class FtWorkingDay
    {
        public FtWorkingDay()
        {
            HrmShiftPatternDetails = new HashSet<HrmShiftPatternDetail>();
        }

        public byte Id { get; set; }
        public string DayName { get; set; } = null!;

        public virtual ICollection<HrmShiftPatternDetail> HrmShiftPatternDetails { get; set; }
    }
}
