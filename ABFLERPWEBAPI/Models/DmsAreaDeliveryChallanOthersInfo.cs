using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsAreaDeliveryChallanOthersInfo
    {
        public long Id { get; set; }
        public long ChallanId { get; set; }
        public byte PurposeId { get; set; }
        public decimal Amount { get; set; }

        public virtual SetChallanPurpose Purpose { get; set; } = null!;
    }
}
