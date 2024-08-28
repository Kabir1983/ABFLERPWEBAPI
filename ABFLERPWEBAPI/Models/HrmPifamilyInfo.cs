using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class HrmPifamilyInfo
    {
        public int Id { get; set; }
        public int Piid { get; set; }
        public string MemberName { get; set; } = null!;
        public string Relationship { get; set; } = null!;
        public string? OthersInfo { get; set; }

        public virtual HrmPi Pi { get; set; } = null!;
    }
}
