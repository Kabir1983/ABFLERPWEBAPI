using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsReturnDetail
    {
        public long ReturnItemId { get; set; }
        public long ReturnId { get; set; }
        public short Ppid { get; set; }
        public long? BatchId { get; set; }
        public decimal Qty { get; set; }
        public string? Cause { get; set; }
        public decimal? ReturnAmount { get; set; }
        public byte ReturnTypeId { get; set; }
        public int? EditBy { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual SetProductPrice Pp { get; set; } = null!;
        public virtual ReturnType ReturnType { get; set; } = null!;
    }
}
