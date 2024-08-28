using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsNapkinFactoryChallan
    {
        public DmsNapkinFactoryChallan()
        {
            DmsNapkinFactoryChallanDetails = new HashSet<DmsNapkinFactoryChallanDetail>();
        }

        public long ChallanId { get; set; }
        public string ChallanNo { get; set; } = null!;
        public long? IndentationId { get; set; }
        public byte FactoryId { get; set; }
        public byte Month { get; set; }
        public short Year { get; set; }
        public int DepoId { get; set; }
        public int ChalanById { get; set; }
        public string? Remarks { get; set; }
        public int? DriverId { get; set; }
        public string? DriverName { get; set; }
        public string? MobileNo { get; set; }
        public string? CarNo { get; set; }
        public DateTime ChallanDate { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual ICollection<DmsNapkinFactoryChallanDetail> DmsNapkinFactoryChallanDetails { get; set; }
    }
}
