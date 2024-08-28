using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsFactoryReceive
    {
        public long Fsrid { get; set; }
        public byte FactoryId { get; set; }
        public short ProductId { get; set; }
        public long Qty { get; set; }
        public long Fsid { get; set; }
        public DateTime ReceiveDate { get; set; }
        public long ReceiveById { get; set; }

        public virtual SetFactory Factory { get; set; } = null!;
        public virtual DmsFactoryStock Fs { get; set; } = null!;
    }
}
