using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsDamageReturnToDepo
    {
        public DmsDamageReturnToDepo()
        {
            DmsDamageReturnToDepoDetails = new HashSet<DmsDamageReturnToDepoDetail>();
        }

        public long Id { get; set; }
        public string ReturnNo { get; set; } = null!;
        public DateTime Date { get; set; }
        public int AreaId { get; set; }
        public int DepoId { get; set; }
        public int ReturnById { get; set; }
        public string? Remarks { get; set; }
        public int? DeliveryManId { get; set; }

        public virtual ICollection<DmsDamageReturnToDepoDetail> DmsDamageReturnToDepoDetails { get; set; }
    }
}
