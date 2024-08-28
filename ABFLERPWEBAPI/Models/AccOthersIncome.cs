using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class AccOthersIncome
    {
        public AccOthersIncome()
        {
            AccDepoCredits = new HashSet<AccDepoCredit>();
        }

        public int Id { get; set; }
        public long Ieid { get; set; }
        public DateTime Date { get; set; }
        public int? DepoId { get; set; }
        public int? AreaId { get; set; }
        public decimal Amount { get; set; }
        public int EntryBy { get; set; }
        public string? Description { get; set; }

        public virtual SetArea? Area { get; set; }
        public virtual SetDepo? Depo { get; set; }
        public virtual AccIncomeExpenseMaster Ie { get; set; } = null!;
        public virtual ICollection<AccDepoCredit> AccDepoCredits { get; set; }
    }
}
