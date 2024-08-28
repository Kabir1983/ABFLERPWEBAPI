using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsDamageReceivedItemFromArea
    {
        public long Id { get; set; }
        public long Drfaid { get; set; }
        public long? AreaReturnItemId { get; set; }
        public long Dmsid { get; set; }
        public short ProductId { get; set; }
        public long Qty { get; set; }
        public int InsertUserId { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual DmsDamageReturnToDepoDetail? AreaReturnItem { get; set; }
        public virtual DmsDepoStock Dms { get; set; } = null!;
        public virtual DmsDamageReceivedFromArea Drfa { get; set; } = null!;
    }
}
