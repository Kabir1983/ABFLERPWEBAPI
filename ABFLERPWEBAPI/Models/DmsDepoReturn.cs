using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsDepoReturn
    {
        public DmsDepoReturn()
        {
            DmsDepoReturnDetails = new HashSet<DmsDepoReturnDetail>();
        }

        public long ReturnId { get; set; }
        public long ReturnNo { get; set; }
        public DateTime ReturnDate { get; set; }
        public int DepoId { get; set; }
        public byte FactoryId { get; set; }
        public int ReturnBy { get; set; }
        public int DeliveryManId { get; set; }
        public byte ReceiveStatus { get; set; }

        public virtual ICollection<DmsDepoReturnDetail> DmsDepoReturnDetails { get; set; }
    }
}
