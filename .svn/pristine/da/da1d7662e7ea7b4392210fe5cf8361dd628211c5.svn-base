using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsAreaReceived
    {
        public DmsAreaReceived()
        {
            DmsAreaReceivedItems = new HashSet<DmsAreaReceivedItem>();
        }

        public long AreaRffid { get; set; }
        public string ReceivedNo { get; set; } = null!;
        public int AreaId { get; set; }
        public DateTime ReceivedDate { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public string? Remarks { get; set; }
        public int ReceivedById { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual ICollection<DmsAreaReceivedItem> DmsAreaReceivedItems { get; set; }
    }
}
