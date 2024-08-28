using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class SetOutletNumber
    {
        public int Id { get; set; }
        public int AreaId { get; set; }
        public int NoOfOutlet { get; set; }

        public virtual SetArea Area { get; set; } = null!;
    }
}
