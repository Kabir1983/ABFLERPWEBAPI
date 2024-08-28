using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsDamageReturnToFactory
    {
        public DmsDamageReturnToFactory()
        {
            DmsDamageReturnToFactoryDetails = new HashSet<DmsDamageReturnToFactoryDetail>();
        }

        public long Id { get; set; }
        public string ReturnNo { get; set; } = null!;
        public DateTime Date { get; set; }
        public int DepoId { get; set; }
        public byte FactoryId { get; set; }
        public int ReturnById { get; set; }
        public string? Remarks { get; set; }
        public DateTime LastUpdate { get; set; }
        public int? DeliveryManId { get; set; }

        public virtual ICollection<DmsDamageReturnToFactoryDetail> DmsDamageReturnToFactoryDetails { get; set; }
    }
}
