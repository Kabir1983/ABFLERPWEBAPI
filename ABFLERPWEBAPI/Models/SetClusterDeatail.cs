using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class SetClusterDeatail
    {
        public int Id { get; set; }
        public int ClusterId { get; set; }
        public string ClusterName { get; set; } = null!;
        public string? ClusterCode { get; set; }
        public int? RouteId { get; set; }
        public bool IsActive { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
