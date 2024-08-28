using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class SetUnion
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int ThanaId { get; set; }
    }
}
