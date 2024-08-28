using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class SetDellar
    {
        public SetDellar()
        {
            DmsDamageReceiveFromDepoDellars = new HashSet<DmsDamageReceiveFromDepoDellar>();
            DmsDellarChallans = new HashSet<DmsDellarChallan>();
            DmsDellarOrders = new HashSet<DmsDellarOrder>();
            DmsDellarPromotions = new HashSet<DmsDellarPromotion>();
            DmsDepoDellarChallanToDamages = new HashSet<DmsDepoDellarChallanToDamage>();
            DmsDepoDellarChallans = new HashSet<DmsDepoDellarChallan>();
        }

        public int DellarId { get; set; }
        public string DellarCode { get; set; } = null!;
        public string DellarName { get; set; } = null!;
        public string? Address { get; set; }
        public string? ContactNo { get; set; }
        public int? AreaId { get; set; }
        public int? DepoId { get; set; }
        public bool IsActive { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual SetDepo? Depo { get; set; }
        public virtual ICollection<DmsDamageReceiveFromDepoDellar> DmsDamageReceiveFromDepoDellars { get; set; }
        public virtual ICollection<DmsDellarChallan> DmsDellarChallans { get; set; }
        public virtual ICollection<DmsDellarOrder> DmsDellarOrders { get; set; }
        public virtual ICollection<DmsDellarPromotion> DmsDellarPromotions { get; set; }
        public virtual ICollection<DmsDepoDellarChallanToDamage> DmsDepoDellarChallanToDamages { get; set; }
        public virtual ICollection<DmsDepoDellarChallan> DmsDepoDellarChallans { get; set; }
    }
}
