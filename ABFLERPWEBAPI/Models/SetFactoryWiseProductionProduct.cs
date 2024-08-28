using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class SetFactoryWiseProductionProduct
    {
        public short Id { get; set; }
        public byte FactoryId { get; set; }
        public short ProductId { get; set; }
        public bool? IsActive { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
