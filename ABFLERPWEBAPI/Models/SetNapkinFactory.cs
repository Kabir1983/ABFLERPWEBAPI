using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class SetNapkinFactory
    {
        public SetNapkinFactory()
        {
            DmsNapkinFactoryReceives = new HashSet<DmsNapkinFactoryReceive>();
        }

        public byte FactoryId { get; set; }
        public string FactoryName { get; set; } = null!;
        public string? FactoryCode { get; set; }
        public string Address { get; set; } = null!;
        public bool IsActive { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual ICollection<DmsNapkinFactoryReceive> DmsNapkinFactoryReceives { get; set; }
    }
}
