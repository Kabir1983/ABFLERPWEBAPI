using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class AccIncomeExpense
    {
        public AccIncomeExpense()
        {
            AccVoucerDetails = new HashSet<AccVoucerDetail>();
        }

        public long Id { get; set; }
        public long IemasterId { get; set; }
        public short PurposeId { get; set; }
        public int? PayToId { get; set; }
        public int? DepoId { get; set; }
        public int? AreaId { get; set; }
        public int? RegionId { get; set; }
        public int? FactoryId { get; set; }
        public bool? IsHeadOffice { get; set; }
        public decimal? Amount { get; set; }

        public virtual SetDepo? Depo { get; set; }
        public virtual AccPupose Purpose { get; set; } = null!;
        public virtual ICollection<AccVoucerDetail> AccVoucerDetails { get; set; }
    }
}
