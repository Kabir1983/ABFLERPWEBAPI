using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsDellarOrder
    {
        public DmsDellarOrder()
        {
            DmsDellarOrderDetails = new HashSet<DmsDellarOrderDetail>();
        }

        public long OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public int ChallanId { get; set; }
        public int DellarId { get; set; }
        public byte Day { get; set; }
        public byte Month { get; set; }
        public short Year { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual SetDellar Dellar { get; set; } = null!;
        public virtual ICollection<DmsDellarOrderDetail> DmsDellarOrderDetails { get; set; }
    }
}
