using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsNapkinDepoToDepoTransferReceiveDetail
    {
        public long Id { get; set; }
        public long TransferReceiveId { get; set; }
        public long Dsid { get; set; }
        public short ProductId { get; set; }
        public long Qty { get; set; }
        public long? ReturnItemId { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual DmsNapkinDepoStock Ds { get; set; } = null!;
        public virtual SetNapkinProduct Product { get; set; } = null!;
        public virtual DmsNapkinDepoToDepoTransferReceive TransferReceive { get; set; } = null!;
    }
}
