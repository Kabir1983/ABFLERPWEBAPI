using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class HrmPfaccount
    {
        public HrmPfaccount()
        {
            HrmPfaccountDetails = new HashSet<HrmPfaccountDetail>();
            HrmPfdddetails = new HashSet<HrmPfdddetail>();
            HrmPfopeningBalances = new HashSet<HrmPfopeningBalance>();
            HrmPftransactions = new HashSet<HrmPftransaction>();
        }

        public int Id { get; set; }
        public string Pfno { get; set; } = null!;
        public int EmployeeId { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsApplyPersonalSetting { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<HrmPfaccountDetail> HrmPfaccountDetails { get; set; }
        public virtual ICollection<HrmPfdddetail> HrmPfdddetails { get; set; }
        public virtual ICollection<HrmPfopeningBalance> HrmPfopeningBalances { get; set; }
        public virtual ICollection<HrmPftransaction> HrmPftransactions { get; set; }
    }
}
