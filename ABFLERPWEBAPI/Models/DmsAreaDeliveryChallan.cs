using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsAreaDeliveryChallan
    {
        public DmsAreaDeliveryChallan()
        {
            DmsBpacketMasters = new HashSet<DmsBpacketMaster>();
            DmsSamples = new HashSet<DmsSample>();
        }

        public long ChallanId { get; set; }
        public long? Ieid { get; set; }
        public int Srid { get; set; }
        public int AreaId { get; set; }
        public string? Driver { get; set; }
        public string? VanNo { get; set; }
        public int RouteId { get; set; }
        public string ChallanNo { get; set; } = null!;
        public DateTime ChallanDate { get; set; }
        public string? Remarks { get; set; }
        public string? AlternetSr { get; set; }
        public int ChallanById { get; set; }
        public bool IsApprovedByAm { get; set; }
        public bool IsApprovedByAccounts { get; set; }
        public DateTime? LastUpdate { get; set; }
        public bool? IsOrderClosed { get; set; }

        public virtual SetArea Area { get; set; } = null!;
        public virtual AccIncomeExpenseMaster? Ie { get; set; }
        public virtual SetRoute Route { get; set; } = null!;
        public virtual HrmPiemployement Sr { get; set; } = null!;
        public virtual ICollection<DmsBpacketMaster> DmsBpacketMasters { get; set; }
        public virtual ICollection<DmsSample> DmsSamples { get; set; }
    }
}
