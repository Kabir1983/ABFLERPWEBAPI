using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class HrLeaveCancelApplication
    {
        public int Id { get; set; }
        public int CancelledById { get; set; }
        public DateTime AppDate { get; set; }
        public int LevApplicationId { get; set; }
        public int? ApprovedById { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string? Comments { get; set; }

        public virtual HrmLeaveApplication LevApplication { get; set; } = null!;
    }
}
