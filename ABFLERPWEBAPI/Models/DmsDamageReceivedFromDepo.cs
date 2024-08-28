using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsDamageReceivedFromDepo
    {
        public DmsDamageReceivedFromDepo()
        {
            DmsDamageReceivedItemFromDepos = new HashSet<DmsDamageReceivedItemFromDepo>();
        }

        public long Id { get; set; }
        public string ReceivedNo { get; set; } = null!;
        public byte FactoryId { get; set; }
        public int DepoId { get; set; }
        public DateTime ReceivedDate { get; set; }
        public string? Remarks { get; set; }
        public int ReceivedById { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual ICollection<DmsDamageReceivedItemFromDepo> DmsDamageReceivedItemFromDepos { get; set; }
    }
}
