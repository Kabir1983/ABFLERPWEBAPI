﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ABFLERPWEBAPI.Models
{
    public partial class SetCluster
    {
        public SetCluster()
        {
            SetOutlets = new HashSet<SetOutlet>();
        }

        public int ClusterId { get; set; }
        public string ClusterName { get; set; } = null!;
        public string? ClusterCode { get; set; }
        public int? RouteId { get; set; }
        public bool IsActive { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual SetRoute? Route { get; set; }
        public virtual ICollection<SetOutlet> SetOutlets { get; set; }
    }
}
