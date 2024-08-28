using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsDepoToDepoChallan
    {
        public DmsDepoToDepoChallan()
        {
            DmsDepoToDepoChallanItems = new HashSet<DmsDepoToDepoChallanItem>();
        }

        public long ChallanId { get; set; }
        public int DepoId { get; set; }
        public int ToDepoId { get; set; }
        public byte Month { get; set; }
        public short Year { get; set; }
        public string ChallanNo { get; set; } = null!;
        public DateTime ChallanDate { get; set; }
        public string? Remarks { get; set; }
        public string? DriverName { get; set; }
        public string? MobileNo { get; set; }
        public string? CarNo { get; set; }
        public int? DriverId { get; set; }
        public int? ChallanById { get; set; }
        public DateTime? LastUpdate { get; set; }

        public virtual SetDepo Depo { get; set; } = null!;
        public virtual HrmPiemployement? Driver { get; set; }
        public virtual ICollection<DmsDepoToDepoChallanItem> DmsDepoToDepoChallanItems { get; set; }
    }
}
