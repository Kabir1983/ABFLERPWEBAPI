using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsNapkinDepoOpeningStock
    {
        public long Id { get; set; }
        public int DepoId { get; set; }
        public short ProductId { get; set; }
        public long Qty { get; set; }
        public long Dsid { get; set; }
        public int InsertUserId { get; set; }
        public DateTime CreateDate { get; set; }

        public virtual DmsNapkinDepoStock Ds { get; set; } = null!;
        public virtual SetNapkinProduct Product { get; set; } = null!;
    }
}
