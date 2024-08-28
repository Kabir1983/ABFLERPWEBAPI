using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsNapkinFactoryReceive
    {
        public long Fsrid { get; set; }
        public byte FactoryId { get; set; }
        public short ProductId { get; set; }
        public long Qty { get; set; }
        public long Fsid { get; set; }
        public DateTime ReceiveDate { get; set; }
        public long ReceiveById { get; set; }

        public virtual SetNapkinFactory Factory { get; set; } = null!;
        public virtual DmsNapkinFactoryStock Fs { get; set; } = null!;
        public virtual SetNapkinProduct Product { get; set; } = null!;
    }
}
