using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsFactoryChallanDetialsWithBarcode
    {
        public long Id { get; set; }
        public DateTime Date { get; set; }
        public byte FactoryId { get; set; }
        public long? Dwsl { get; set; }
        public int? DepoId { get; set; }
        public string? ChallanNo { get; set; }
        public short ProductId { get; set; }
        public int WorkerId { get; set; }
        public long Frdwbcid { get; set; }
        public long ChallanDetailId { get; set; }
        public string Barcode { get; set; } = null!;
        public long Qty { get; set; }
        public decimal Weight { get; set; }
        public bool ReceiveStatus { get; set; }
        public bool? IsProcess { get; set; }
        public bool? IsActive { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual SetFactory Factory { get; set; } = null!;
    }
}
