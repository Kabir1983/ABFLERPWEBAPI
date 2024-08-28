using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsAreaRecvFromAreaDetail
    {
        public long AreaReceiveItemId { get; set; }
        public long AreaReceiveId { get; set; }
        public long ChallanItemId { get; set; }
        public short ProductId { get; set; }
        public long Qty { get; set; }
        public long Asid { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual DmsAreaRecvFromArea AreaReceive { get; set; } = null!;
        public virtual DmsAreaStock As { get; set; } = null!;
        public virtual DmsAreaChallanToAreaRequestDetail ChallanItem { get; set; } = null!;
    }
}
