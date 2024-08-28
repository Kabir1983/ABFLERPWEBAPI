using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsAreaReceivedItem
    {
        public long AreaReceiveItemId { get; set; }
        public long AreaReceiveId { get; set; }
        public long? DepoChallanItemId { get; set; }
        public short ProductId { get; set; }
        public long Qty { get; set; }
        public long Asid { get; set; }
        public int InsertUserId { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual DmsAreaReceived AreaReceive { get; set; } = null!;
        public virtual DmsAreaStock As { get; set; } = null!;
        public virtual DmsDepoChallanItem? DepoChallanItem { get; set; }
        public virtual SetProduct Product { get; set; } = null!;
    }
}
