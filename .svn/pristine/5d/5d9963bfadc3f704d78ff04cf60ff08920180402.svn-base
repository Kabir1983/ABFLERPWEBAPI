using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsRegionWiseActualSale
    {
        public int Id { get; set; }
        public int RegionId { get; set; }
        public short ProductId { get; set; }
        public decimal SalesQty { get; set; }
        public decimal CurrentStock { get; set; }
        public DateTime SalesDate { get; set; }
        public byte Month { get; set; }
        public short Year { get; set; }
        public long? MasterId { get; set; }
        public int EntryById { get; set; }
        public DateTime? LastUpdate { get; set; }

        public virtual DmsRegionActualSalesMaster? Master { get; set; }
        public virtual SetProduct Product { get; set; } = null!;
        public virtual SetRegion Region { get; set; } = null!;
    }
}
