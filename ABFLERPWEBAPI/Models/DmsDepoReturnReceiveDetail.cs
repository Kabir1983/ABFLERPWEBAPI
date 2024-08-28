using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsDepoReturnReceiveDetail
    {
        public long Id { get; set; }
        public long ReturnReceiveId { get; set; }
        public long Fsid { get; set; }
        public short ProductId { get; set; }
        public long Qty { get; set; }
        public long? ReturnItemId { get; set; }

        public virtual DmsFactoryStock Fs { get; set; } = null!;
        public virtual DmsDepoReturnReceive ReturnReceive { get; set; } = null!;
    }
}
