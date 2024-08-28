using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsAreaReturnReceive
    {
        public DmsAreaReturnReceive()
        {
            DmsAreaReturnReceiveDetails = new HashSet<DmsAreaReturnReceiveDetail>();
        }

        public long Id { get; set; }
        public string ReturnReceiveNo { get; set; } = null!;
        public int DepoId { get; set; }
        public int AreaId { get; set; }
        public byte Month { get; set; }
        public short Year { get; set; }
        public DateTime ReceiveDate { get; set; }
        public byte ReturnTypeId { get; set; }
        public int? ReceivedById { get; set; }

        public virtual ICollection<DmsAreaReturnReceiveDetail> DmsAreaReturnReceiveDetails { get; set; }
    }
}
