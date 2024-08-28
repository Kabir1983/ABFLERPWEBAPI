using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class FacFacToFacItemDistribution
    {
        public FacFacToFacItemDistribution()
        {
            FacFacToFacItemDistributionDetails = new HashSet<FacFacToFacItemDistributionDetail>();
            FacFacToFacItemReceives = new HashSet<FacFacToFacItemReceive>();
        }

        public long Id { get; set; }
        public string ChallanNo { get; set; } = null!;
        public byte FromFactoryId { get; set; }
        public byte ToFactoryId { get; set; }
        public DateTime ChallanDate { get; set; }
        public string? DriverName { get; set; }
        public string? DriverMobileNo { get; set; }
        public string? CarNo { get; set; }
        public bool IsActive { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual SetFactory FromFactory { get; set; } = null!;
        public virtual SetFactory ToFactory { get; set; } = null!;
        public virtual ICollection<FacFacToFacItemDistributionDetail> FacFacToFacItemDistributionDetails { get; set; }
        public virtual ICollection<FacFacToFacItemReceive> FacFacToFacItemReceives { get; set; }
    }
}
