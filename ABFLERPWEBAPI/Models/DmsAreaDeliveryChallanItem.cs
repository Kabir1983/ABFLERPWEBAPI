using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsAreaDeliveryChallanItem
    {
        public long ChallanItemId { get; set; }
        public long ChallanId { get; set; }
        public long Asid { get; set; }
        public short ProductId { get; set; }
        public long ChallanQty { get; set; }
        public long? ReturnAsid { get; set; }
        public long? ReturnQty { get; set; }
        public decimal Tp { get; set; }
        public int? SampleQty { get; set; }
        public int? SampleReturn { get; set; }
        public int InsertUserId { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual DmsAreaStock As { get; set; } = null!;
        public virtual SetProduct Product { get; set; } = null!;
        public virtual DmsAreaStock? ReturnAs { get; set; }
    }
}
