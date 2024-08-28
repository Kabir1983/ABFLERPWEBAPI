using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class FacWorkerWage
    {
        public int Id { get; set; }
        public byte FactoryId { get; set; }
        public byte Fwtype { get; set; }
        public short ProductId { get; set; }
        public decimal WagesPerTh { get; set; }
        public decimal? Incentive { get; set; }
        public bool? IsActive { get; set; }
        public DateTime Lastupdate { get; set; }

        public virtual SetFactory Factory { get; set; } = null!;
        public virtual SetProduct Product { get; set; } = null!;
    }
}
