using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class AccHouseRentMonthly
    {
        public long Id { get; set; }
        public DateTime Date { get; set; }
        public int? AreaId { get; set; }
        public int? DepoId { get; set; }
        public int HouseRentInfoId { get; set; }
        public long Iemid { get; set; }
        public byte Month { get; set; }
        public short Year { get; set; }
        public decimal CashAmount { get; set; }
        public decimal? AdvanceAmount { get; set; }
        public decimal AdvanceBalance { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual AccHouseRentInfo HouseRentInfo { get; set; } = null!;
        public virtual AccIncomeExpenseMaster Iem { get; set; } = null!;
    }
}
