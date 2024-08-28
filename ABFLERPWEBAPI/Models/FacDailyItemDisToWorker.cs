using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class FacDailyItemDisToWorker
    {
        public FacDailyItemDisToWorker()
        {
            FacDailyItemDisToWorkerDetails = new HashSet<FacDailyItemDisToWorkerDetail>();
            FacProductionReceiveFromWorkers = new HashSet<FacProductionReceiveFromWorker>();
        }

        public long Id { get; set; }
        public byte FactoryId { get; set; }
        public long WorkerId { get; set; }
        public DateTime Date { get; set; }
        public long ChallanNo { get; set; }
        public short ProductId { get; set; }
        public int Qty { get; set; }
        public bool IsReceive { get; set; }
        public bool IsActive { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual ICollection<FacDailyItemDisToWorkerDetail> FacDailyItemDisToWorkerDetails { get; set; }
        public virtual ICollection<FacProductionReceiveFromWorker> FacProductionReceiveFromWorkers { get; set; }
    }
}
