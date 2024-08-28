using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class HrmPfopeningBalance
    {
        public int Id { get; set; }
        public int PfaccId { get; set; }
        public long TransactionId { get; set; }
        public decimal GraturityAmount { get; set; }
        public decimal Pfamount { get; set; }
        public int ResponsibleId { get; set; }
        public DateTime Date { get; set; }
        public byte TranStatus { get; set; }

        public virtual HrmPfaccount Pfacc { get; set; } = null!;
        public virtual HrmPftransaction Transaction { get; set; } = null!;
    }
}
