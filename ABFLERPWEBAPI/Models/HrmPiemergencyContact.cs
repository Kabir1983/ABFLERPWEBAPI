using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class HrmPiemergencyContact
    {
        public int Id { get; set; }
        public int Piid { get; set; }
        public string ContactName { get; set; } = null!;
        public string Relationship { get; set; } = null!;
        public string? HomeTele { get; set; }
        public string Mobile { get; set; } = null!;
        public string? WorkTele { get; set; }
    }
}
