using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class Gpstracking
    {
        public long GpstracId { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public string? Address { get; set; }
        public DateTime? TrackingTime { get; set; }
        public long? EmployeeId { get; set; }
        public long? OrderId { get; set; }
        public long? ImageCaptureId { get; set; }
        public int? OutletId { get; set; }
    }
}
