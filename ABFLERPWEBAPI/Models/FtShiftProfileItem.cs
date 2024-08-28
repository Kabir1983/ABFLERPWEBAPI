using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class FtShiftProfileItem
    {
        public FtShiftProfileItem()
        {
            HrmShiftProfileItems = new HashSet<HrmShiftProfileItem>();
        }

        public byte Id { get; set; }
        public string ProfileItemName { get; set; } = null!;

        public virtual ICollection<HrmShiftProfileItem> HrmShiftProfileItems { get; set; }
    }
}
