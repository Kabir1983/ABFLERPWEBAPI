using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class FacDailyItemDisToWorkerDetail
    {
        public long Id { get; set; }
        public long Didw { get; set; }
        public long Fisid { get; set; }
        public int ItemId { get; set; }
        public decimal DisQty { get; set; }
        public short UnitId { get; set; }
        public decimal UnitPrice { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual FacDailyItemDisToWorker DidwNavigation { get; set; } = null!;
        public virtual FacFactoryItemStock Fis { get; set; } = null!;
        public virtual FacItemInfo Item { get; set; } = null!;
    }
}
