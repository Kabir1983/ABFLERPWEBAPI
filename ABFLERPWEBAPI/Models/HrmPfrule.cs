using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class HrmPfrule
    {
        public byte Id { get; set; }
        public decimal CompanyShareInPc { get; set; }
        public decimal SelfShareInPc { get; set; }
        public decimal GraturityInPc { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public bool IsActive { get; set; }
    }
}
