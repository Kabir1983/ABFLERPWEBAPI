using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsImageCaptureType
    {
        public DmsImageCaptureType()
        {
            DmsImageCaptures = new HashSet<DmsImageCapture>();
        }

        public byte ImageTypeId { get; set; }
        public string? TypeName { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual ICollection<DmsImageCapture> DmsImageCaptures { get; set; }
    }
}
