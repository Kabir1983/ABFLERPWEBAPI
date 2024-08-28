using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class FacDailyToabaccoUse
    {
        public long Id { get; set; }
        public DateTime Date { get; set; }
        public long Dtiid { get; set; }
        public byte FactoryId { get; set; }
        public decimal UseQty { get; set; }
        public decimal JarTamakQty { get; set; }
        public long Jtfsid { get; set; }
        public string Remarks { get; set; } = null!;
        public DateTime Lastupdate { get; set; }

        public virtual FacDailyTobaccoIssue Dti { get; set; } = null!;
    }
}
