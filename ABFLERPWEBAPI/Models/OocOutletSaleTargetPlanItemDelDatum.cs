using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class OocOutletSaleTargetPlanItemDelDatum
    {
        public long Id { get; set; }
        public long TplanItemId { get; set; }
        public long TplanId { get; set; }
        public short ProductId { get; set; }
        public int Qty { get; set; }
        public string? Remarks { get; set; }
        public int InsertUserId { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
