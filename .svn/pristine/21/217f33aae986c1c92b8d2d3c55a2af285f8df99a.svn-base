using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsNapkinAreaReturn
    {
        public DmsNapkinAreaReturn()
        {
            DmsNapkinAreaReturnDetails = new HashSet<DmsNapkinAreaReturnDetail>();
        }

        public long ReturnId { get; set; }
        public long ReturnNo { get; set; }
        public DateTime ReturnDate { get; set; }
        public int AreaId { get; set; }
        public int DepoId { get; set; }
        public int ReturnBy { get; set; }
        public int DeliveryManId { get; set; }
        public byte ReceiveStatus { get; set; }
        public byte ReturnTypeId { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual DmsNapkinReturnType ReturnType { get; set; } = null!;
        public virtual ICollection<DmsNapkinAreaReturnDetail> DmsNapkinAreaReturnDetails { get; set; }
    }
}
