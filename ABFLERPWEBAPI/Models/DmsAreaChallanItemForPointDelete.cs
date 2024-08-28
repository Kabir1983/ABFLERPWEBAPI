using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsAreaChallanItemForPointDelete
    {
        public long ChallanItemId { get; set; }
        public long ChallanId { get; set; }
        public short ProductId { get; set; }
        public long ChallanQty { get; set; }
        public decimal Tp { get; set; }
        public int InsertUserId { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
