using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class SetAreaWiseUnit
    {
        public int Id { get; set; }
        public int AreaId { get; set; }
        public int Unit { get; set; }
        public byte? ExtraUnit { get; set; }
        public string Description { get; set; } = null!;
        public bool? IsActive { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
