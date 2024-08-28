using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsDamageReturnToFactoryDetail
    {
        public DmsDamageReturnToFactoryDetail()
        {
            DmsDamageReceivedItemFromDepos = new HashSet<DmsDamageReceivedItemFromDepo>();
        }

        public long Id { get; set; }
        public long Drfid { get; set; }
        public long Dmsid { get; set; }
        public long BatchId { get; set; }
        public short ProductId { get; set; }
        public decimal Qty { get; set; }
        public byte ReceivedStatus { get; set; }
        public int InsertUserId { get; set; }
        public bool IsActive { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual DmsDepoStock Dms { get; set; } = null!;
        public virtual DmsDamageReturnToFactory Drf { get; set; } = null!;
        public virtual ICollection<DmsDamageReceivedItemFromDepo> DmsDamageReceivedItemFromDepos { get; set; }
    }
}
