using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsDepoDellarChallanItemToDamage
    {
        public long ChallanItemId { get; set; }
        public long DchallanId { get; set; }
        public long Dsid { get; set; }
        public short ProductId { get; set; }
        public long Qty { get; set; }
        public int InsertUserId { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual DmsDepoDellarChallanToDamage Dchallan { get; set; } = null!;
        public virtual DmsDepoStock Ds { get; set; } = null!;
    }
}
