using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class SetBiriCigaretteStatus
    {
        public byte Id { get; set; }
        public string StatusName { get; set; } = null!;
        public string Color { get; set; } = null!;
        public bool? IsActive { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
