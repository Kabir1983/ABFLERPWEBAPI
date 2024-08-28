using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class AccIncomExpenseMaster
    {
        public AccIncomExpenseMaster()
        {
            AccVoucerDetails = new HashSet<AccVoucerDetail>();
        }

        public long Id { get; set; }
        public string VoucherNo { get; set; } = null!;
        public int? ResponsibleId { get; set; }
        public short? IncomeExpenseTypeId { get; set; }
        public DateTime PayTime { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<AccVoucerDetail> AccVoucerDetails { get; set; }
    }
}
