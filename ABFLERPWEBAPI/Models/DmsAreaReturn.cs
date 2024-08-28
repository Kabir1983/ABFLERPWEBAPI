using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsAreaReturn
    {
        public DmsAreaReturn()
        {
            DmsAreaReturnDetails = new HashSet<DmsAreaReturnDetail>();
        }

        public long ReturnId { get; set; }
        public long ReturnNo { get; set; }
        public DateTime ReturnDate { get; set; }
        public int AreaId { get; set; }
        public int DepoId { get; set; }
        public int ReturnBy { get; set; }
        public int DeliveryManId { get; set; }
        public byte ReceiveStatus { get; set; }

        public virtual ICollection<DmsAreaReturnDetail> DmsAreaReturnDetails { get; set; }
    }
}
