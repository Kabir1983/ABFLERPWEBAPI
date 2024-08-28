using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsAreaChallanWisePayment
    {
        public long Id { get; set; }
        public long ChallanId { get; set; }
        public long? Ieid { get; set; }
        public decimal PaidAmount { get; set; }
        public decimal? DueAmount { get; set; }
        public decimal Balance { get; set; }
        public string? Remarks { get; set; }
        public DateTime InsertDate { get; set; }
        public int ResponsibleId { get; set; }
        public byte? BlockStatus { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual AccIncomeExpenseMaster? Ie { get; set; }
    }
}
