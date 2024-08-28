using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class HrmPftransaction
    {
        public HrmPftransaction()
        {
            HrmPfdddetails = new HashSet<HrmPfdddetail>();
            HrmPfopeningBalances = new HashSet<HrmPfopeningBalance>();
        }

        public long Id { get; set; }
        public int PfaccId { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public decimal Balance { get; set; }

        public virtual HrmPfaccount Pfacc { get; set; } = null!;
        public virtual ICollection<HrmPfdddetail> HrmPfdddetails { get; set; }
        public virtual ICollection<HrmPfopeningBalance> HrmPfopeningBalances { get; set; }
    }
}
