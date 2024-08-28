using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class HrmPfddinfo
    {
        public HrmPfddinfo()
        {
            HrmPfdddetails = new HashSet<HrmPfdddetail>();
        }

        public int Id { get; set; }
        public string Ddno { get; set; } = null!;
        public decimal Ddamount { get; set; }
        public DateTime Date { get; set; }
        public int ResponsibleId { get; set; }

        public virtual ICollection<HrmPfdddetail> HrmPfdddetails { get; set; }
    }
}
