using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsBpacketStock
    {
        public DmsBpacketStock()
        {
            DmsBpacketDetails = new HashSet<DmsBpacketDetail>();
        }

        public long Bpsid { get; set; }
        public int AreaId { get; set; }
        public int ProductId { get; set; }
        public int Qty { get; set; }
        public int Balance { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual ICollection<DmsBpacketDetail> DmsBpacketDetails { get; set; }
    }
}
