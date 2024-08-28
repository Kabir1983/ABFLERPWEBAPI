using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsBpacketPromotion
    {
        public int PromotionId { get; set; }
        public short ProductId { get; set; }
        public short PacketQty { get; set; }
        public short StickQty { get; set; }
        public bool? IsActive { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual SetProduct Product { get; set; } = null!;
    }
}
