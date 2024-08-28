using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class FacFacToFacItemReceive
    {
        public FacFacToFacItemReceive()
        {
            FacFacToFacItemReceiveDetails = new HashSet<FacFacToFacItemReceiveDetail>();
        }

        public long Id { get; set; }
        public long Ffid { get; set; }
        public byte FromFactoryId { get; set; }
        public byte ToFactoryId { get; set; }
        public DateTime ChallanDate { get; set; }
        public DateTime ReceiveDate { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual FacFacToFacItemDistribution Ff { get; set; } = null!;
        public virtual SetFactory FromFactory { get; set; } = null!;
        public virtual SetFactory ToFactory { get; set; } = null!;
        public virtual ICollection<FacFacToFacItemReceiveDetail> FacFacToFacItemReceiveDetails { get; set; }
    }
}
