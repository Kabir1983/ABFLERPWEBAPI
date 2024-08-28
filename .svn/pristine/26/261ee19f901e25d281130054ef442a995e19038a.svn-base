using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsAreaReturnReceiveDetail
    {
        public long Id { get; set; }
        public long ReturnReceiveId { get; set; }
        public long Dsid { get; set; }
        public short ProductId { get; set; }
        public long Qty { get; set; }
        public long? ReturnItemId { get; set; }

        public virtual DmsDepoStock Ds { get; set; } = null!;
        public virtual DmsAreaReturnReceive ReturnReceive { get; set; } = null!;
    }
}
