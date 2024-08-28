using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsNapkinDepoToDepoTransferReceive
    {
        public DmsNapkinDepoToDepoTransferReceive()
        {
            DmsNapkinDepoToDepoTransferReceiveDetails = new HashSet<DmsNapkinDepoToDepoTransferReceiveDetail>();
        }

        public long Id { get; set; }
        public string TransferReceiveNo { get; set; } = null!;
        public int ReceiverDepoId { get; set; }
        public int SenderDepoId { get; set; }
        public byte Month { get; set; }
        public short Year { get; set; }
        public DateTime ReceiveDate { get; set; }
        public int? ReceivedById { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual ICollection<DmsNapkinDepoToDepoTransferReceiveDetail> DmsNapkinDepoToDepoTransferReceiveDetails { get; set; }
    }
}
