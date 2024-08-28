using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class AccIncomeExpenseDetailDelete
    {
        public long Id { get; set; }
        public long Emid { get; set; }
        public short PurposeId { get; set; }
        public decimal Amount { get; set; }
    }
}
