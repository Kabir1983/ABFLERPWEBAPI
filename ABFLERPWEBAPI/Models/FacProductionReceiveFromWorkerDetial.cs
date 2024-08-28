using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class FacProductionReceiveFromWorkerDetial
    {
        public long Id { get; set; }
        public long Prfwid { get; set; }
        public int ItemId { get; set; }
        public decimal Qty { get; set; }
        public decimal ReceiveQty { get; set; }
        public decimal ReturnQty { get; set; }
        public short UnitId { get; set; }
        public decimal UnitPrice { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual FacProductionReceiveFromWorker Prfw { get; set; } = null!;
    }
}
