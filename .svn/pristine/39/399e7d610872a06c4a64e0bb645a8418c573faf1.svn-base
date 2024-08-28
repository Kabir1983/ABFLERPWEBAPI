using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class SetChallanPurpose
    {
        public SetChallanPurpose()
        {
            DmsAreaDeliveryChallanOthersInfos = new HashSet<DmsAreaDeliveryChallanOthersInfo>();
        }

        public byte Id { get; set; }
        public string PurposeName { get; set; } = null!;
        public bool IsActive { get; set; }

        public virtual ICollection<DmsAreaDeliveryChallanOthersInfo> DmsAreaDeliveryChallanOthersInfos { get; set; }
    }
}
