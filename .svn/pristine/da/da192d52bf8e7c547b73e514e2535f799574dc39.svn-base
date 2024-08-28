using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsAreaChallanAgainstAreaRequest
    {
        public DmsAreaChallanAgainstAreaRequest()
        {
            DmsAreaChallanToAreaRequestDetails = new HashSet<DmsAreaChallanToAreaRequestDetail>();
        }

        public long ChallanId { get; set; }
        public int AreaId { get; set; }
        public byte Month { get; set; }
        public short Year { get; set; }
        public string ChallanNo { get; set; } = null!;
        public DateTime ChallanDate { get; set; }
        public string? Remarks { get; set; }
        public string? DriverName { get; set; }
        public string? MobileNo { get; set; }
        public string? CarNo { get; set; }
        public int? DriverId { get; set; }
        public int? ChallanById { get; set; }
        public DateTime? LastUpdate { get; set; }

        public virtual ICollection<DmsAreaChallanToAreaRequestDetail> DmsAreaChallanToAreaRequestDetails { get; set; }
    }
}
