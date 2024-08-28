using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsNapkinDmreceivedItemFromFactory
    {
        public long DmritemFfid { get; set; }
        public long Dmrffid { get; set; }
        public long? ChallanDetailId { get; set; }
        public short ProductId { get; set; }
        public long Qty { get; set; }
        public long Dsid { get; set; }
        public int InsertUserId { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual DmsNapkinFactoryChallanDetail? ChallanDetail { get; set; }
        public virtual DmsNapkinDmrecevedFromFactory Dmrff { get; set; } = null!;
        public virtual DmsNapkinDepoStock Ds { get; set; } = null!;
        public virtual SetNapkinProduct Product { get; set; } = null!;
    }
}
