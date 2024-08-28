using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class AccCashTransferDelete
    {
        public long Id { get; set; }
        public long Ieid { get; set; }
        public DateTime PayDate { get; set; }
        public decimal? Amount { get; set; }
        public int? AreaId { get; set; }
        public int? RegionId { get; set; }
        public int? DepoId { get; set; }
        public byte? FactoryId { get; set; }
        public bool IsHeadOffice { get; set; }
        public bool? IsAtal { get; set; }
        public bool IsReceive { get; set; }
    }
}
