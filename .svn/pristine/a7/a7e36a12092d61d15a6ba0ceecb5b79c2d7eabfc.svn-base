using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class HrmPiqualification
    {
        public int Id { get; set; }
        public int Piid { get; set; }
        public byte EducationLevel { get; set; }
        public string DegreeTitle { get; set; } = null!;
        public string Institute { get; set; } = null!;
        public string? MajorOrSpecialization { get; set; }
        public short PassingYear { get; set; }
        public string GpaorClass { get; set; } = null!;
        public string Duration { get; set; } = null!;
        public string? Achievement { get; set; }

        public virtual HrmPi Pi { get; set; } = null!;
    }
}
