using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsDellarOrderDetail
    {
        public long OrderDetailId { get; set; }
        public long OrderId { get; set; }
        public short ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Tp { get; set; }
        public decimal GrossTotal { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual DmsDellarOrder Order { get; set; } = null!;
        public virtual SetProduct Product { get; set; } = null!;
    }
}
