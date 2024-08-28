using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class AccIncomeExpenseDetail
    {
        public long Id { get; set; }
        public long Emid { get; set; }
        public short PurposeId { get; set; }
        public decimal Amount { get; set; }

        public virtual AccIncomeExpenseMaster Em { get; set; } = null!;
        public virtual AccPupose Purpose { get; set; } = null!;
    }
}
