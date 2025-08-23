using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class SetVisitFrequency
    {
        public Int16 ID { get; set; }
        public string VFrequency { get; set; }
        public string? Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
