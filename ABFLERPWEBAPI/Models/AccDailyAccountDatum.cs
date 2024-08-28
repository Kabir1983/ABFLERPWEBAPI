using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class AccDailyAccountDatum
    {
        public long Id { get; set; }
        public DateTime? PayDate { get; set; }
        public DateTime? Iedate { get; set; }
        public short PurposeId { get; set; }
        public int? AreaId { get; set; }
        public int? RegionId { get; set; }
        public int? DepoId { get; set; }
        public byte? FactoryId { get; set; }
        public bool IsHeadOffice { get; set; }
        public byte IeheaderId { get; set; }
        public decimal? TotalAmount { get; set; }
    }
}
