using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class TblWeight
    {
        public int Id { get; set; }
        public short? FactoryId { get; set; }
        public short? ScaleId { get; set; }
        public string Weight { get; set; } = null!;
        public DateTime? LastUpdate { get; set; }
    }
}
