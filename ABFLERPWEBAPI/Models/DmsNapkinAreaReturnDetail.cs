using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsNapkinAreaReturnDetail
    {
        public long ReturnItemId { get; set; }
        public long ReturnId { get; set; }
        public short ProductId { get; set; }
        public long Qty { get; set; }
        public long Asid { get; set; }
        public string? Cause { get; set; }
        public byte ReturnTypeId { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual DmsNapkinAreaStock As { get; set; } = null!;
        public virtual SetNapkinProduct Product { get; set; } = null!;
        public virtual DmsNapkinAreaReturn Return { get; set; } = null!;
        public virtual ReturnType ReturnType { get; set; } = null!;
    }
}
