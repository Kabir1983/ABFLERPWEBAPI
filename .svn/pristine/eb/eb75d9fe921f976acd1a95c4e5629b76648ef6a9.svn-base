using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class HrmPiincrement
    {
        public int IncrementId { get; set; }
        public int Pisid { get; set; }
        public byte PayGradeId { get; set; }
        public decimal Basic { get; set; }
        public decimal? Hra { get; set; }
        public decimal? Ta { get; set; }
        public decimal? Da { get; set; }
        public decimal? Ma { get; set; }
        public byte EffectiveMonth { get; set; }
        public short EffectiveYear { get; set; }
        public bool? IsDefault { get; set; }
        public bool? IsActive { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual SetPayGrade PayGrade { get; set; } = null!;
        public virtual HrmPi Pis { get; set; } = null!;
    }
}
