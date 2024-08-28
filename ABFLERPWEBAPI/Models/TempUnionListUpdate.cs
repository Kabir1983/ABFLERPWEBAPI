using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class TempUnionListUpdate
    {
        public long Id { get; set; }
        public string Divison { get; set; } = null!;
        public string District { get; set; } = null!;
        public string Thana { get; set; } = null!;
        public string UnionName { get; set; } = null!;
        public bool IsProcess { get; set; }
    }
}
