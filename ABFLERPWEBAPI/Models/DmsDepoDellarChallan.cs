using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsDepoDellarChallan
    {
        public DmsDepoDellarChallan()
        {
            DmsDepoDellarChallanItems = new HashSet<DmsDepoDellarChallanItem>();
        }

        public long DchallanId { get; set; }
        public long? Ieid { get; set; }
        public int DellarId { get; set; }
        public int DepoId { get; set; }
        public string ChallanNo { get; set; } = null!;
        public DateTime ChallanDate { get; set; }
        public string? Remarks { get; set; }
        public string? DriverName { get; set; }
        public string? MobileNo { get; set; }
        public string? CarNo { get; set; }
        public int? DriverId { get; set; }
        public int? ChallanById { get; set; }
        public bool? IsApprovedBySdm { get; set; }
        public bool IsApprovedByAccounts { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual SetDellar Dellar { get; set; } = null!;
        public virtual SetDepo Depo { get; set; } = null!;
        public virtual AccIncomeExpenseMaster? Ie { get; set; }
        public virtual ICollection<DmsDepoDellarChallanItem> DmsDepoDellarChallanItems { get; set; }
    }
}
