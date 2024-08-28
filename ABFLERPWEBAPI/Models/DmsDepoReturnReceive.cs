using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsDepoReturnReceive
    {
        public DmsDepoReturnReceive()
        {
            DmsDepoReturnReceiveDetails = new HashSet<DmsDepoReturnReceiveDetail>();
        }

        public long Id { get; set; }
        public string ReturnReceiveNo { get; set; } = null!;
        public byte FactoryId { get; set; }
        public int DepoId { get; set; }
        public byte Month { get; set; }
        public short Year { get; set; }
        public DateTime ReceiveDate { get; set; }
        public byte ReturnTypeId { get; set; }
        public int? ReceivedById { get; set; }

        public virtual ICollection<DmsDepoReturnReceiveDetail> DmsDepoReturnReceiveDetails { get; set; }
    }
}
