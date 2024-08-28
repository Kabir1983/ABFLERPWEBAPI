using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsOrderDetailForPoint
    {
        public long OrderDetailId { get; set; }
        public long OrderId { get; set; }
        public short ProductId { get; set; }
        public int Quantity { get; set; }
        public int? BpacketMax { get; set; }
        public int? Fqty { get; set; }
        public int? DamageQty { get; set; }
        public decimal? IncentiveQty { get; set; }
        public decimal Tp { get; set; }
        public decimal GrossTotal { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual DmsOrdersForPoint Order { get; set; } = null!;
    }
}
