using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class SetTerritory
    {
        public SetTerritory()
        {
            HrmPiemployements = new HashSet<HrmPiemployement>();
            HrmPitransfers = new HashSet<HrmPitransfer>();
            SetRoutes = new HashSet<SetRoute>();
        }

        public int TerritoryId { get; set; }
        public string TerritoryCode { get; set; } = null!;
        public string Name { get; set; } = null!;
        public int AreaId { get; set; }
        public string? Address { get; set; }
        public byte TerritoryTypeId { get; set; }
        public bool IsActive { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual SetArea Area { get; set; } = null!;
        public virtual ICollection<HrmPiemployement> HrmPiemployements { get; set; }
        public virtual ICollection<HrmPitransfer> HrmPitransfers { get; set; }
        public virtual ICollection<SetRoute> SetRoutes { get; set; }
    }
}
