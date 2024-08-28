using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class ReturnType
    {
        public ReturnType()
        {
            DmsAreaReturnDetails = new HashSet<DmsAreaReturnDetail>();
            DmsDepoReturnDetails = new HashSet<DmsDepoReturnDetail>();
            DmsNapkinAreaReturnDetails = new HashSet<DmsNapkinAreaReturnDetail>();
            DmsReturnDetails = new HashSet<DmsReturnDetail>();
        }

        public byte Id { get; set; }
        public string TypeName { get; set; } = null!;

        public virtual ICollection<DmsAreaReturnDetail> DmsAreaReturnDetails { get; set; }
        public virtual ICollection<DmsDepoReturnDetail> DmsDepoReturnDetails { get; set; }
        public virtual ICollection<DmsNapkinAreaReturnDetail> DmsNapkinAreaReturnDetails { get; set; }
        public virtual ICollection<DmsReturnDetail> DmsReturnDetails { get; set; }
    }
}
