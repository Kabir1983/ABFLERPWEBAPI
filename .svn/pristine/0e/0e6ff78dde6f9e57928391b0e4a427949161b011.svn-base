using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsAreaRecvFromArea
    {
        public DmsAreaRecvFromArea()
        {
            DmsAreaRecvFromAreaDetails = new HashSet<DmsAreaRecvFromAreaDetail>();
        }

        public long AreaRffid { get; set; }
        public string ReceivedNo { get; set; } = null!;
        public int AreaId { get; set; }
        public DateTime ReceivedDate { get; set; }
        public string? Remarks { get; set; }
        public int ReceivedById { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual ICollection<DmsAreaRecvFromAreaDetail> DmsAreaRecvFromAreaDetails { get; set; }
    }
}
