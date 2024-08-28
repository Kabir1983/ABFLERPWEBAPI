using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class AccCashTransfer
    {
        public AccCashTransfer()
        {
            AccCashOrDepositReceives = new HashSet<AccCashOrDepositReceive>();
            AccDepoCredits = new HashSet<AccDepoCredit>();
            AccDepoDebits = new HashSet<AccDepoDebit>();
            AccHoCredits = new HashSet<AccHoCredit>();
        }

        public long Id { get; set; }
        public long Ieid { get; set; }
        public DateTime PayDate { get; set; }
        public decimal? Amount { get; set; }
        public int? AreaId { get; set; }
        public int? RegionId { get; set; }
        public int? DepoId { get; set; }
        public byte? FactoryId { get; set; }
        public bool IsHeadOffice { get; set; }
        public bool? IsAtal { get; set; }
        public bool IsReceive { get; set; }

        public virtual AccIncomeExpenseMaster Ie { get; set; } = null!;
        public virtual ICollection<AccCashOrDepositReceive> AccCashOrDepositReceives { get; set; }
        public virtual ICollection<AccDepoCredit> AccDepoCredits { get; set; }
        public virtual ICollection<AccDepoDebit> AccDepoDebits { get; set; }
        public virtual ICollection<AccHoCredit> AccHoCredits { get; set; }
    }
}
