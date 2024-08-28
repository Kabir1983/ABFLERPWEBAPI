using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsNapkinDepoChallanItem
    {
        public long ChallanItemId { get; set; }
        public long ChallanId { get; set; }
        public long Dsid { get; set; }
        public short ProductId { get; set; }
        public long Qty { get; set; }
        public int InsertUserId { get; set; }
        public DateTime LastUpdate { get; set; }
        public bool IsReceive { get; set; }
        public byte? Status { get; set; }

        public virtual DmsNapkinDepoChallan Challan { get; set; } = null!;
        public virtual DmsNapkinDepoStock Ds { get; set; } = null!;
        public virtual SetNapkinProduct Product { get; set; } = null!;
    }
}
