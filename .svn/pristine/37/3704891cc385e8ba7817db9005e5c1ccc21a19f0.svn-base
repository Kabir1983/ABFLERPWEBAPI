using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class HrmPijobExperience
    {
        public int Id { get; set; }
        public int Piid { get; set; }
        public string Company { get; set; } = null!;
        public string Designation { get; set; } = null!;
        public string? Responsibility { get; set; }
        public DateTime FromDt { get; set; }
        public DateTime ToDt { get; set; }
        public string? Comments { get; set; }

        public virtual HrmPi Pi { get; set; } = null!;
    }
}
