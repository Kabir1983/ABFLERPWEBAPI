using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsNapkinDmrecevedFromFactory
    {
        public DmsNapkinDmrecevedFromFactory()
        {
            DmsNapkinDmreceivedItemFromFactories = new HashSet<DmsNapkinDmreceivedItemFromFactory>();
        }

        public long Dmrffid { get; set; }
        public string ReceivedNo { get; set; } = null!;
        public int DepoId { get; set; }
        public int? FactoryId { get; set; }
        public DateTime ReceivedDate { get; set; }
        public string? Remarks { get; set; }
        public int ReceivedById { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual ICollection<DmsNapkinDmreceivedItemFromFactory> DmsNapkinDmreceivedItemFromFactories { get; set; }
    }
}
