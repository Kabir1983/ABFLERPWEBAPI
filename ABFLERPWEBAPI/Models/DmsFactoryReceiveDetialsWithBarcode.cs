using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsFactoryReceiveDetialsWithBarcode
    {
        public long Id { get; set; }
        public DateTime Date { get; set; }
        public byte FactoryId { get; set; }
        public short ProductId { get; set; }
        public int WorkerId { get; set; }
        public long Fpbcid { get; set; }
        public long Fsrid { get; set; }
        public string Barcode { get; set; } = null!;
        public long Qty { get; set; }
        public decimal Weight { get; set; }
        public bool ChallanStatus { get; set; }
        public bool? IsActive { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
