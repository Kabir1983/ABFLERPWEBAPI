using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsNapkinFactoryOpeningStock
    {
        public long Id { get; set; }
        public byte FactoryId { get; set; }
        public short ProductId { get; set; }
        public long Qty { get; set; }
        public long Fsid { get; set; }
        public int InsertUserId { get; set; }
        public DateTime CreateDate { get; set; }

        public virtual DmsNapkinFactoryStock Fs { get; set; } = null!;
        public virtual SetNapkinProduct Product { get; set; } = null!;
    }
}
