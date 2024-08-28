using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class HrmPfaccountDetail
    {
        public int Id { get; set; }
        public int PfaccId { get; set; }
        public DateTime CreatedDate { get; set; }
        public decimal SelfShareInPc { get; set; }
        public decimal CompanyShareInPc { get; set; }
        public bool IsActive { get; set; }

        public virtual HrmPfaccount Pfacc { get; set; } = null!;
    }
}
