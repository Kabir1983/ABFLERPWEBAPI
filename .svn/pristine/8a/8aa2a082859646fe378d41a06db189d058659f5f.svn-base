using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class OocVisibilityInfo
    {
        public OocVisibilityInfo()
        {
            OocOutletVisits = new HashSet<OocOutletVisit>();
        }

        public byte Id { get; set; }
        public string VisibilityInfoName { get; set; } = null!;
        public string? VisibilityInfoCode { get; set; }
        public string? ImageUrl { get; set; }
        public bool IsActive { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual ICollection<OocOutletVisit> OocOutletVisits { get; set; }
    }
}
