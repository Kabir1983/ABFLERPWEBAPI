using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class Log
    {
        public long LogId { get; set; }
        public string Message { get; set; } = null!;
        public DateTime LastUpdate { get; set; }
    }
}
