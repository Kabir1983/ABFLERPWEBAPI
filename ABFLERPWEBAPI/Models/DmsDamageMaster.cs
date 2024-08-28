using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsDamageMaster
    {
        public long Id { get; set; }
        public long ChallanId { get; set; }
        public int EmployementId { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
