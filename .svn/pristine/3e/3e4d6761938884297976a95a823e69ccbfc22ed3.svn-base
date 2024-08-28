using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsNapkinFactoryChallanDetail
    {
        public DmsNapkinFactoryChallanDetail()
        {
            DmsNapkinDmreceivedItemFromFactories = new HashSet<DmsNapkinDmreceivedItemFromFactory>();
        }

        public long ChallanDetailId { get; set; }
        public long ChallanId { get; set; }
        public short ProductId { get; set; }
        public long Asid { get; set; }
        public long Qty { get; set; }
        public int InsertUserId { get; set; }
        public bool IsReceive { get; set; }
        public byte? Status { get; set; }

        public virtual DmsNapkinFactoryStock As { get; set; } = null!;
        public virtual DmsNapkinFactoryChallan Challan { get; set; } = null!;
        public virtual SetNapkinProduct Product { get; set; } = null!;
        public virtual ICollection<DmsNapkinDmreceivedItemFromFactory> DmsNapkinDmreceivedItemFromFactories { get; set; }
    }
}
