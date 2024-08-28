using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class AccIncomeExpenseMasterDelete
    {
        public long Id { get; set; }
        public string? VoucherNo { get; set; }
        public int? ResponsibleId { get; set; }
        public int? AreaId { get; set; }
        public int? RegionId { get; set; }
        public int? DepoId { get; set; }
        public byte? FactoryId { get; set; }
        public bool IsHeadOffice { get; set; }
        public byte IeheaderId { get; set; }
        public decimal Amount { get; set; }
        public decimal Balance { get; set; }
        public DateTime PayDate { get; set; }
        public string? Description { get; set; }
        public DateTime? Iedate { get; set; }
    }
}
