using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class FacFacToFacItemReceiveDetail
    {
        public long Id { get; set; }
        public long Ffir { get; set; }
        public long Ffidd { get; set; }
        public long Fsid { get; set; }
        public int ItemId { get; set; }
        public short UnitId { get; set; }
        public decimal ChallanQty { get; set; }
        public decimal ReceiveQty { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual FacFacToFacItemDistributionDetail FfiddNavigation { get; set; } = null!;
        public virtual FacFacToFacItemReceive FfirNavigation { get; set; } = null!;
        public virtual FacFactoryItemStock Fs { get; set; } = null!;
    }
}
