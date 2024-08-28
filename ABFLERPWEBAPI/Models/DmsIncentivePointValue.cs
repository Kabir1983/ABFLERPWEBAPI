using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsIncentivePointValue
    {
        public long Id { get; set; }
        public int IncentiveId { get; set; }
        public int? EmployementId { get; set; }
        public int? PointValue { get; set; }
        public DateTime Date { get; set; }
        public DateTime Lastupdate { get; set; }
    }
}
