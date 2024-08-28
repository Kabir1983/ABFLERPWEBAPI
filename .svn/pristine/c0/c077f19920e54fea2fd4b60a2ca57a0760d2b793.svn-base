using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsNapkinAreaReturnReceive
    {
        public DmsNapkinAreaReturnReceive()
        {
            DmsNapkinAreaReturnReceiveDetails = new HashSet<DmsNapkinAreaReturnReceiveDetail>();
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

        public virtual ICollection<DmsNapkinAreaReturnReceiveDetail> DmsNapkinAreaReturnReceiveDetails { get; set; }
    }
}
