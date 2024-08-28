using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class HrmLeaveAppDetail
    {
        public int Id { get; set; }
        public int LeaveAppId { get; set; }
        public DateTime Date { get; set; }
        public bool CancelAppvStatus { get; set; }
        public bool IsCancelRequest { get; set; }

        public virtual HrmLeaveApplication LeaveApp { get; set; } = null!;
    }
}
