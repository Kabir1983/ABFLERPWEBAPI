using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class AccHeader
    {
        public AccHeader()
        {
            AccPuposes = new HashSet<AccPupose>();
        }

        public byte HeaderId { get; set; }
        public string HeaderName { get; set; } = null!;
        public string? HeaderDescription { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<AccPupose> AccPuposes { get; set; }
    }
}
