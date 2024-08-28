using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class AccPupose
    {
        public AccPupose()
        {
            AccIncomeExpenseDetails = new HashSet<AccIncomeExpenseDetail>();
            AccIncomeExpenses = new HashSet<AccIncomeExpense>();
        }

        public short PurposeId { get; set; }
        public byte HeaderId { get; set; }
        public string PurposeName { get; set; } = null!;
        public string? PurposeNameBengali { get; set; }
        public string? Description { get; set; }
        public bool IsActive { get; set; }

        public virtual AccHeader Header { get; set; } = null!;
        public virtual ICollection<AccIncomeExpenseDetail> AccIncomeExpenseDetails { get; set; }
        public virtual ICollection<AccIncomeExpense> AccIncomeExpenses { get; set; }
    }
}
