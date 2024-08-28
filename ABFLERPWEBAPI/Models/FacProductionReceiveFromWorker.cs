using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class FacProductionReceiveFromWorker
    {
        public FacProductionReceiveFromWorker()
        {
            FacProductionReceiveFromWorkerDetials = new HashSet<FacProductionReceiveFromWorkerDetial>();
        }

        public long Id { get; set; }
        public long Didw { get; set; }
        public DateTime ReceiveDate { get; set; }
        public long WorkerId { get; set; }
        public byte FactoryId { get; set; }
        public short ProductId { get; set; }
        public int BiriQty { get; set; }
        public int ReceiveQty { get; set; }
        public int ReturnQty { get; set; }
        public int KataiBiriQty { get; set; }
        public int CheckBiriQty { get; set; }
        public string Remarks { get; set; } = null!;
        public bool IsActive { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual FacDailyItemDisToWorker DidwNavigation { get; set; } = null!;
        public virtual ICollection<FacProductionReceiveFromWorkerDetial> FacProductionReceiveFromWorkerDetials { get; set; }
    }
}
