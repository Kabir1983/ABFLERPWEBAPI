using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsBpacketMaster
    {
        public DmsBpacketMaster()
        {
            DmsBpacketDetails = new HashSet<DmsBpacketDetail>();
        }

        public long Id { get; set; }
        public long ChallanId { get; set; }
        public int EmployementId { get; set; }
        public int? OutletId { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual DmsAreaDeliveryChallan Challan { get; set; } = null!;
        public virtual ICollection<DmsBpacketDetail> DmsBpacketDetails { get; set; }
    }
}
