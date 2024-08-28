using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class HrmShiftProfileItem
    {
        public short Id { get; set; }
        public short ProfileId { get; set; }
        public byte ProfileItemId { get; set; }
        public TimeSpan StartFrom { get; set; }
        public TimeSpan? TolaranceBefore { get; set; }
        public TimeSpan? TolaranceAfter { get; set; }

        public virtual HrmShiftProfile Profile { get; set; } = null!;
        public virtual FtShiftProfileItem ProfileItem { get; set; } = null!;
    }
}
