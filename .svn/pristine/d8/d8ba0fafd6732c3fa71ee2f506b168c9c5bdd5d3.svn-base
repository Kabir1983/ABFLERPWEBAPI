using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class AccDepoCredit
    {
        public long Dcid { get; set; }
        public int DepoId { get; set; }
        public long? Ctid { get; set; }
        public int? OtherSaleId { get; set; }
        public decimal Amount { get; set; }
        public long Dlid { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual AccCashTransfer? Ct { get; set; }
        public virtual SetDepo Depo { get; set; } = null!;
        public virtual AccDepoLedger Dl { get; set; } = null!;
        public virtual AccOthersIncome? OtherSale { get; set; }
    }
}
