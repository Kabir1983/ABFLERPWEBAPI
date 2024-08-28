using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class FacDailyWorkerWage
    {
        public long Id { get; set; }
        public long WorkerId { get; set; }
        public short ProductId { get; set; }
        public DateTime Date { get; set; }
        public int TotalProduction { get; set; }
        public decimal TotalWages { get; set; }
        public decimal? TotalIncentive { get; set; }
        public DateTime Lastupdate { get; set; }

        public virtual SetProduct Product { get; set; } = null!;
    }
}
