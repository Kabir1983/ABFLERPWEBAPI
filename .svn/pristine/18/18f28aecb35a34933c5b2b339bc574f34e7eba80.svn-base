using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class SetOutlet
    {
        public SetOutlet()
        {
            DmsOrders = new HashSet<DmsOrder>();
            DmsOrdersForPoints = new HashSet<DmsOrdersForPoint>();
        }

        public int OutletId { get; set; }
        public string OutletCode { get; set; } = null!;
        public string OutletName { get; set; } = null!;
        public string? Owner { get; set; }
        public string? Address { get; set; }
        public int? ClusterId { get; set; }
        public string? ContactNo { get; set; }
        public int RouteId { get; set; }
        public int RouteOutletNo { get; set; }
        public bool IsActive { get; set; }
        public DateTime LastUpdate { get; set; }
        public bool IsNew { get; set; }
        public byte? BiriCigaretteStatus { get; set; }
        public int? UnionId { get; set; }
        public string? VillageName { get; set; }
        public string? MarketName { get; set; }
        public byte? OutletTypeID { get; set; }

        public virtual SetCluster? Cluster { get; set; }
        public virtual SetRoute Route { get; set; } = null!;
        public virtual ICollection<DmsOrder> DmsOrders { get; set; }
        public virtual ICollection<DmsOrdersForPoint> DmsOrdersForPoints { get; set; }
    }
}
