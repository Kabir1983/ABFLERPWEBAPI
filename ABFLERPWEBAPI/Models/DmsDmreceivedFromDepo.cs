using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsDmreceivedFromDepo
    {
        public DmsDmreceivedFromDepo()
        {
            DmsDmreceivedItemFromDepos = new HashSet<DmsDmreceivedItemFromDepo>();
        }

        public long Dmrfdid { get; set; }
        public string ReceivedNo { get; set; } = null!;
        public int DepoId { get; set; }
        public int? FromDepoId { get; set; }
        public DateTime ReceivedDate { get; set; }
        public string? Remarks { get; set; }
        public int ReceivedById { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual SetDepo Depo { get; set; } = null!;
        public virtual ICollection<DmsDmreceivedItemFromDepo> DmsDmreceivedItemFromDepos { get; set; }
    }
}
