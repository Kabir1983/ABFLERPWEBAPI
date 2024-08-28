using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsDmreceivedItemFromFactoryWithBarcode
    {
        public long Id { get; set; }
        public DateTime Date { get; set; }
        public DateTime? Pdate { get; set; }
        public byte FactoryId { get; set; }
        public short ProductId { get; set; }
        public int WorkerId { get; set; }
        public long Fcdwbc { get; set; }
        public long DmritemFfid { get; set; }
        public string Barcode { get; set; } = null!;
        public long Qty { get; set; }
        public decimal Weight { get; set; }
        public bool? IsActive { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
