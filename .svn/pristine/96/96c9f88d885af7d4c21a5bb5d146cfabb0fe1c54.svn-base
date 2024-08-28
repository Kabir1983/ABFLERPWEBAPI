using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsNapkinReturnType
    {
        public DmsNapkinReturnType()
        {
            DmsNapkinAreaReturns = new HashSet<DmsNapkinAreaReturn>();
        }

        public byte ReturnTypeId { get; set; }
        public string ReturnType { get; set; } = null!;
        public bool? IsActive { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual ICollection<DmsNapkinAreaReturn> DmsNapkinAreaReturns { get; set; }
    }
}
