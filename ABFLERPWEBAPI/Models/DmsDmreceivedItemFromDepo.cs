using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsDmreceivedItemFromDepo
    {
        public long Id { get; set; }
        public long Dmrfdid { get; set; }
        public long? ChallanItemId { get; set; }
        public short ProductId { get; set; }
        public long Qty { get; set; }
        public long Dsid { get; set; }
        public int? InsertUserId { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual DmsDepoToDepoChallanItem? ChallanItem { get; set; }
        public virtual DmsDmreceivedFromDepo Dmrfd { get; set; } = null!;
    }
}
