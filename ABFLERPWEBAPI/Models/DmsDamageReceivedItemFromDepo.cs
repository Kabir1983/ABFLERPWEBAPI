using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsDamageReceivedItemFromDepo
    {
        public long Id { get; set; }
        public long Drfdid { get; set; }
        public long ReturnItemId { get; set; }
        public long Fmsid { get; set; }
        public short ProductId { get; set; }
        public decimal Qty { get; set; }
        public int InsertUserId { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual DmsDamageReceivedFromDepo Drfd { get; set; } = null!;
        public virtual DmsFactoryStock Fms { get; set; } = null!;
        public virtual DmsDamageReturnToFactoryDetail ReturnItem { get; set; } = null!;
    }
}
