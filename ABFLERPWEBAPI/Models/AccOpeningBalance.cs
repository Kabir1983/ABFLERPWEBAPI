using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class AccOpeningBalance
    {
        public int Id { get; set; }
        public long Ieid { get; set; }
        public int? AreaId { get; set; }
        public int? RegionId { get; set; }
        public int? DepoId { get; set; }
        public byte? FactoryId { get; set; }
        public bool IsHeadOffice { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreateDate { get; set; }

        public virtual AccIncomeExpenseMaster Ie { get; set; } = null!;
    }
}
