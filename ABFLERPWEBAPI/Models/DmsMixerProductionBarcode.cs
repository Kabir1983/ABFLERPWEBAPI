using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsMixerProductionBarcode
    {
        public long Id { get; set; }
        public long WorkerId { get; set; }
        public string WorkerName { get; set; } = null!;
        public string WorkerCode { get; set; } = null!;
        public byte FactoryId { get; set; }
        public string FactoryCode { get; set; } = null!;
        public string FactoryName { get; set; } = null!;
        public string FactoryDivisionCode { get; set; } = null!;
        public DateTime Date { get; set; }
        public TimeSpan? Time { get; set; }
        public decimal Weight { get; set; }
        public int SlNo { get; set; }
        public long FactorySlNo { get; set; }
        public string Barcode { get; set; } = null!;
        public string BostaNo { get; set; } = null!;
        public short Pcno { get; set; }
        public bool? IsActive { get; set; }
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public bool DtransferStatus { get; set; }
        public bool PrintStatus { get; set; }
        public bool ChallanStatus { get; set; }
        public bool ProductionStatus { get; set; }
        public DateTime Lastupdate { get; set; }
    }
}
