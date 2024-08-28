using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsBpacketDetail
    {
        public long Id { get; set; }
        public long BpacketMasterId { get; set; }
        public long Bpsid { get; set; }
        public short ProductId { get; set; }
        public int PacketQty { get; set; }
        public long StickQty { get; set; }

        public virtual DmsBpacketMaster BpacketMaster { get; set; } = null!;
        public virtual DmsBpacketStock Bps { get; set; } = null!;
    }
}
