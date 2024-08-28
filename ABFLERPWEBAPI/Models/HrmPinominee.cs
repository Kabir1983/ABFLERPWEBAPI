using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class HrmPinominee
    {
        public int Id { get; set; }
        public int Piid { get; set; }
        public string Name { get; set; } = null!;
        public string Relationship { get; set; } = null!;
        public string? MobileNo { get; set; }
        public string? Address { get; set; }
        public string? NationalId { get; set; }

        public virtual HrmPi Pi { get; set; } = null!;
    }
}
