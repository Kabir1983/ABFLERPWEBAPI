using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class SetFactoryWorkerType
    {
        public byte Id { get; set; }
        public string WorkerType { get; set; } = null!;
        public bool? IsActive { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
