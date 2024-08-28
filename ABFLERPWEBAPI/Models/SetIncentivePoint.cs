using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class SetIncentivePoint
    {
        public int Id { get; set; }
        public byte MasterId { get; set; }
        public string Grade { get; set; } = null!;
        public string Parameter { get; set; } = null!;
        public string PointPurpose { get; set; } = null!;
        public int? MinValue { get; set; }
        public int? MaxValue { get; set; }
        public TimeSpan? MinTime { get; set; }
        public TimeSpan? MaxTime { get; set; }
        public byte CheckingType { get; set; }
        public byte? CheckingDay { get; set; }
        public byte Srpoint { get; set; }
        public byte Toampoint { get; set; }
        public byte Ammpoint { get; set; }
        public byte Mmpoint { get; set; }
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
