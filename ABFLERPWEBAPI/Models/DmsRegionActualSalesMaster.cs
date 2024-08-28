using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsRegionActualSalesMaster
    {
        public DmsRegionActualSalesMaster()
        {
            DmsRegionWiseActualSales = new HashSet<DmsRegionWiseActualSale>();
        }

        public long Id { get; set; }
        public int RegionId { get; set; }
        public DateTime SalesDate { get; set; }
        public int ExistingOutlet { get; set; }
        public int TargetOutlet { get; set; }
        public int SalesOutlet { get; set; }
        public decimal AverageMemo { get; set; }
        public byte Month { get; set; }
        public short Year { get; set; }
        public int EntryById { get; set; }
        public DateTime? LastUpdate { get; set; }

        public virtual ICollection<DmsRegionWiseActualSale> DmsRegionWiseActualSales { get; set; }
    }
}
