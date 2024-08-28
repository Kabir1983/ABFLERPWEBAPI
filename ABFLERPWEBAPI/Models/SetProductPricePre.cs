using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class SetProductPricePre
    {
        public short Ppid { get; set; }
        public short ProductId { get; set; }
        public decimal Mrp { get; set; }
        public decimal Vat { get; set; }
        public decimal Tp { get; set; }
        public bool IsActive { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
