using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class HrmShiftPatternDetail
    {
        public short Id { get; set; }
        public byte WorkingDayId { get; set; }
        public short? ShiftProfileId { get; set; }
        public short ShiftPatternId { get; set; }

        public virtual HrmShiftPattern ShiftPattern { get; set; } = null!;
        public virtual HrmShiftProfile? ShiftProfile { get; set; }
        public virtual FtWorkingDay WorkingDay { get; set; } = null!;
    }
}
