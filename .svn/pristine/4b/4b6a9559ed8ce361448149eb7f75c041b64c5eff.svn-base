using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsDmreceivedItemFromFactory
    {
        public long DmritemFfid { get; set; }
        public long Dmrffid { get; set; }
        public long? ChallanDetailId { get; set; }
        public short ProductId { get; set; }
        public long Qty { get; set; }
        public long Dsid { get; set; }
        public int InsertUserId { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual DmsFactoryChallanDetail? ChallanDetail { get; set; }
        public virtual DmsDmrecevedFromFactory Dmrff { get; set; } = null!;
    }
}
