using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class FacReceiveItemFromHo
    {
        public FacReceiveItemFromHo()
        {
            FacReceiveItemFromHodetails = new HashSet<FacReceiveItemFromHodetail>();
        }

        public long Frihoid { get; set; }
        public DateTime ReceiveDate { get; set; }
        public DateTime ChallanDate { get; set; }
        public string ChallanNo { get; set; } = null!;
        public string? DriverName { get; set; }
        public string? DriverMobileNo { get; set; }
        public string? CarNo { get; set; }
        public short FactoryId { get; set; }
        public string? Remarks { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual ICollection<FacReceiveItemFromHodetail> FacReceiveItemFromHodetails { get; set; }
    }
}
