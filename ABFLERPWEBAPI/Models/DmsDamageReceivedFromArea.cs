using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsDamageReceivedFromArea
    {
        public DmsDamageReceivedFromArea()
        {
            DmsDamageReceivedItemFromAreas = new HashSet<DmsDamageReceivedItemFromArea>();
        }

        public long Id { get; set; }
        public string ReceivedNo { get; set; } = null!;
        public int DepoId { get; set; }
        public int AreaId { get; set; }
        public DateTime ReceivedDate { get; set; }
        public string? Remarks { get; set; }
        public int ReceivedById { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual ICollection<DmsDamageReceivedItemFromArea> DmsDamageReceivedItemFromAreas { get; set; }
    }
}
