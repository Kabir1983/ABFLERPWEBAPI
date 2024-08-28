using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsSrwiseNapkinPromotion
    {
        public long Id { get; set; }
        public long Srid { get; set; }
        public int AreaId { get; set; }
        public int TerritoryId { get; set; }
        public long RouteId { get; set; }
        public short ProductId { get; set; }
        public DateTime Date { get; set; }
        public int Qty { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }
        public long ResEmployeeId { get; set; }
        public DateTime LastUpdate { get; set; }
        public long? Asid { get; set; }
        public byte? PromotionTypeId { get; set; }
    }
}
