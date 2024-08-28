using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsNapkinDepoToDepoTransfer
    {
        public DmsNapkinDepoToDepoTransfer()
        {
            DmsNapkinDepoToDepoTransferDetails = new HashSet<DmsNapkinDepoToDepoTransferDetail>();
        }

        public long TransferId { get; set; }
        public long TransferNo { get; set; }
        public DateTime TransferDate { get; set; }
        public int SenderDepoId { get; set; }
        public int ReceiverDepoId { get; set; }
        public int TransferBy { get; set; }
        public string? DriverName { get; set; }
        public int? DriverId { get; set; }
        public string? DriverMobileNo { get; set; }
        public string? CarNo { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public int DeliveryManId { get; set; }
        public byte ReceiveStatus { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual ICollection<DmsNapkinDepoToDepoTransferDetail> DmsNapkinDepoToDepoTransferDetails { get; set; }
    }
}
