using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class FtMeritalStatus
    {
        public byte Id { get; set; }
        public string Name { get; set; } = null!;
        public bool IsActive { get; set; }
    }
}
