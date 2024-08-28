using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsDepoReturnDetail
    {
        public long ReturnItemId { get; set; }
        public long ReturnId { get; set; }
        public short ProductId { get; set; }
        public long Qty { get; set; }
        public long Dsid { get; set; }
        public string? Cause { get; set; }
        public byte ReturnTypeId { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual DmsDepoStock Ds { get; set; } = null!;
        public virtual SetProduct Product { get; set; } = null!;
        public virtual DmsDepoReturn Return { get; set; } = null!;
        public virtual ReturnType ReturnType { get; set; } = null!;
    }
}
