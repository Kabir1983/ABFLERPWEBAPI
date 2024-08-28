using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsDamageReceiveFromDepoDellar
    {
        public DmsDamageReceiveFromDepoDellar()
        {
            DmsDamageReceiveFromDepoDellarDetails = new HashSet<DmsDamageReceiveFromDepoDellarDetail>();
        }

        public long Id { get; set; }
        public string ReceiveNo { get; set; } = null!;
        public int DepoId { get; set; }
        public int DellarId { get; set; }
        public byte Month { get; set; }
        public short Year { get; set; }
        public DateTime ReceiveDate { get; set; }
        public int? ReceivedById { get; set; }

        public virtual SetDellar Dellar { get; set; } = null!;
        public virtual ICollection<DmsDamageReceiveFromDepoDellarDetail> DmsDamageReceiveFromDepoDellarDetails { get; set; }
    }
}
