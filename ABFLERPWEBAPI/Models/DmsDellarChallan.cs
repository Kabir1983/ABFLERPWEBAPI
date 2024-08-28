using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsDellarChallan
    {
        public DmsDellarChallan()
        {
            DmsDellarChallanItems = new HashSet<DmsDellarChallanItem>();
        }

        public long ChallanId { get; set; }
        public long? Ieid { get; set; }
        public int DellarId { get; set; }
        public int AreaId { get; set; }
        public string ChallanNo { get; set; } = null!;
        public DateTime ChallanDate { get; set; }
        public string? Remarks { get; set; }
        public int ChallanById { get; set; }
        public bool IsApprovedByAm { get; set; }
        public bool IsApprovedByAccounts { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual SetArea Area { get; set; } = null!;
        public virtual HrmPiemployement ChallanBy { get; set; } = null!;
        public virtual SetDellar Dellar { get; set; } = null!;
        public virtual AccIncomeExpenseMaster? Ie { get; set; }
        public virtual ICollection<DmsDellarChallanItem> DmsDellarChallanItems { get; set; }
    }
}
