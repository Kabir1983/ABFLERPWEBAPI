using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsFactoryChallanDetail
    {
        public long ChallanDetailId { get; set; }
        public long ChallanId { get; set; }
        public short ProductId { get; set; }
        public long Asid { get; set; }
        public long Qty { get; set; }
        public int InsertUserId { get; set; }
        public bool IsReceive { get; set; }
        public byte? Status { get; set; }

        public virtual DmsFactoryStock As { get; set; } = null!;
        public virtual DmsFactoryChallan Challan { get; set; } = null!;
        public virtual DmsDmreceivedItemFromFactory? DmsDmreceivedItemFromFactory { get; set; }
    }
}
