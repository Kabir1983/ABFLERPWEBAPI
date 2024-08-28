using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class AccVoucerDetail
    {
        public long Id { get; set; }
        public long MasterId { get; set; }
        public long IncExpId { get; set; }
        public int? PayToId { get; set; }

        public virtual AccIncomeExpense IncExp { get; set; } = null!;
        public virtual AccIncomExpenseMaster Master { get; set; } = null!;
    }
}
