using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class SetRegion
    {
        public SetRegion()
        {
            AccIncomeExpenseMasters = new HashSet<AccIncomeExpenseMaster>();
            DmsRegionWiseActualSales = new HashSet<DmsRegionWiseActualSale>();
            HrmPiemployements = new HashSet<HrmPiemployement>();
            SetAreas = new HashSet<SetArea>();
            SetDivisionWiseRegions = new HashSet<SetDivisionWiseRegion>();
        }

        public int RegionId { get; set; }
        public int Sln { get; set; }
        public string Name { get; set; } = null!;
        public string? Code { get; set; }
        public string? Description { get; set; }
        public int DepoId { get; set; }
        public bool? IsActive { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual SetDepo Depo { get; set; } = null!;
        public virtual ICollection<AccIncomeExpenseMaster> AccIncomeExpenseMasters { get; set; }
        public virtual ICollection<DmsRegionWiseActualSale> DmsRegionWiseActualSales { get; set; }
        public virtual ICollection<HrmPiemployement> HrmPiemployements { get; set; }
        public virtual ICollection<SetArea> SetAreas { get; set; }
        public virtual ICollection<SetDivisionWiseRegion> SetDivisionWiseRegions { get; set; }
    }
}
