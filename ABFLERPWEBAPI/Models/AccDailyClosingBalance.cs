using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class AccDailyClosingBalance
    {
        public long Id { get; set; }
        public long AccId { get; set; }
        public int? AreaId { get; set; }
        public int? DepoId { get; set; }
        public int? RegionId { get; set; }
        public byte? FactoryId { get; set; }
        public bool IsHeadOffice { get; set; }
        public decimal Balance { get; set; }
        public DateTime? PayDate { get; set; }
    }
}
