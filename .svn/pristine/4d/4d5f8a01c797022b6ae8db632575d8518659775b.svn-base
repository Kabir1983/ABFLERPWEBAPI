using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class AccHouseRentInfo
    {
        public AccHouseRentInfo()
        {
            AccHouseRentMonthlies = new HashSet<AccHouseRentMonthly>();
        }

        public int Id { get; set; }
        public long AdvanceId { get; set; }
        public string HouseOwnerName { get; set; } = null!;
        public string? HouseAddress { get; set; }
        public string? MobileNo { get; set; }
        public decimal MonthlyRent { get; set; }
        public byte AgreementDuration { get; set; }
        public decimal MonthlyReduceAmount { get; set; }
        public string? Remarks { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual AccAdvance Advance { get; set; } = null!;
        public virtual ICollection<AccHouseRentMonthly> AccHouseRentMonthlies { get; set; }
    }
}
