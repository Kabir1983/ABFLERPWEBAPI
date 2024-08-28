using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsImageCapture
    {
        public long Id { get; set; }
        public byte ImageTypeId { get; set; }
        public int? OutletId { get; set; }
        public int EmployeeId { get; set; }
        public string ImageUrl { get; set; } = null!;
        public string? ImageName { get; set; }
        public DateTime CaptureDate { get; set; }
        public string? Remarks { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual DmsImageCaptureType ImageType { get; set; } = null!;
    }
}
