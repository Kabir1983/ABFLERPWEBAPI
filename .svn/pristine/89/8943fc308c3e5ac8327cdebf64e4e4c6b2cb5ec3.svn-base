using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsDamageReturnToDepoDetail
    {
        public DmsDamageReturnToDepoDetail()
        {
            DmsDamageReceivedItemFromAreas = new HashSet<DmsDamageReceivedItemFromArea>();
        }

        public long Id { get; set; }
        public long Drdid { get; set; }
        public long Asid { get; set; }
        public short ProductId { get; set; }
        public long Qty { get; set; }
        public bool IsReceive { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual DmsAreaStock As { get; set; } = null!;
        public virtual DmsDamageReturnToDepo Drd { get; set; } = null!;
        public virtual ICollection<DmsDamageReceivedItemFromArea> DmsDamageReceivedItemFromAreas { get; set; }
    }
}
