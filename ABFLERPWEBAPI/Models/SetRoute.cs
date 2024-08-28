using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class SetRoute
    {
        public SetRoute()
        {
            DmsAreaChallanForPoints = new HashSet<DmsAreaChallanForPoint>();
            DmsAreaDeliveryChallans = new HashSet<DmsAreaDeliveryChallan>();
            DmsRoutePlans = new HashSet<DmsRoutePlan>();
            SetClusters = new HashSet<SetCluster>();
            SetOutlets = new HashSet<SetOutlet>();
        }

        public int RouteId { get; set; }
        public string RouteCode { get; set; } = null!;
        public string RouteName { get; set; } = null!;
        public int? TerritoryId { get; set; }
        public bool IsActive { get; set; }
        public DateTime LastUpdate { get; set; }
        public string? MarketShare { get; set; }
        public string? DistanceFromArea { get; set; }

        public virtual SetTerritory? Territory { get; set; }
        public virtual ICollection<DmsAreaChallanForPoint> DmsAreaChallanForPoints { get; set; }
        public virtual ICollection<DmsAreaDeliveryChallan> DmsAreaDeliveryChallans { get; set; }
        public virtual ICollection<DmsRoutePlan> DmsRoutePlans { get; set; }
        public virtual ICollection<SetCluster> SetClusters { get; set; }
        public virtual ICollection<SetOutlet> SetOutlets { get; set; }
    }
}
