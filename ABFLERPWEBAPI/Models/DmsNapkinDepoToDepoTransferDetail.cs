using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsNapkinDepoToDepoTransferDetail
    {
        public long TransferItemId { get; set; }
        public long TransferId { get; set; }
        public short ProductId { get; set; }
        public long Qty { get; set; }
        public long Dsid { get; set; }
        public string? Cause { get; set; }
        public bool Status { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual DmsNapkinDepoStock Ds { get; set; } = null!;
        public virtual SetNapkinProduct Product { get; set; } = null!;
        public virtual DmsNapkinDepoToDepoTransfer Transfer { get; set; } = null!;
    }
}
