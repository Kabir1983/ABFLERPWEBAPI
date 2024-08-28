using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class HrmShiftProfile
    {
        public HrmShiftProfile()
        {
            HrmShiftPatternDetails = new HashSet<HrmShiftPatternDetail>();
            HrmShiftProfileItems = new HashSet<HrmShiftProfileItem>();
        }

        public short Id { get; set; }
        public string ProfileName { get; set; } = null!;
        public byte ShiftTypeId { get; set; }
        public bool IsActive { get; set; }

        public virtual SetHrmshiftType ShiftType { get; set; } = null!;
        public virtual ICollection<HrmShiftPatternDetail> HrmShiftPatternDetails { get; set; }
        public virtual ICollection<HrmShiftProfileItem> HrmShiftProfileItems { get; set; }
    }
}
