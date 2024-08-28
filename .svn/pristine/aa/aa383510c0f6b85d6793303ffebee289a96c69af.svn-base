using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsAreaChallanItemForPoint
    {
        public long ChallanItemId { get; set; }
        public long ChallanId { get; set; }
        public short ProductId { get; set; }
        public long ChallanQty { get; set; }
        public decimal Tp { get; set; }
        public int InsertUserId { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual DmsAreaChallanForPoint Challan { get; set; } = null!;
        public virtual SetProduct Product { get; set; } = null!;
    }
}
