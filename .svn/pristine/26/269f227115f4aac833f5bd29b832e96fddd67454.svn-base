using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsAreaChallanToAreaRequestDetail
    {
        public DmsAreaChallanToAreaRequestDetail()
        {
            DmsAreaRecvFromAreaDetails = new HashSet<DmsAreaRecvFromAreaDetail>();
        }

        public long ChallanItemId { get; set; }
        public long ChallanId { get; set; }
        public short ProductId { get; set; }
        public long Qty { get; set; }
        public long Asid { get; set; }
        public DateTime LastUpdate { get; set; }
        public bool IsReceive { get; set; }

        public virtual DmsAreaStock As { get; set; } = null!;
        public virtual DmsAreaChallanAgainstAreaRequest Challan { get; set; } = null!;
        public virtual ICollection<DmsAreaRecvFromAreaDetail> DmsAreaRecvFromAreaDetails { get; set; }
    }
}
