using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsIncentiveMaster
    {
        public DmsIncentiveMaster()
        {
            DmsIncentiveDetails = new HashSet<DmsIncentiveDetail>();
        }

        public long IncentiveId { get; set; }
        public long ChallanId { get; set; }
        public int EmployeementId { get; set; }
        public DateTime IncentiveDate { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual HrmPiemployement Employeement { get; set; } = null!;
        public virtual ICollection<DmsIncentiveDetail> DmsIncentiveDetails { get; set; }
    }
}
