using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class SetArea
    {
        public SetArea()
        {
            AccAreaDebits = new HashSet<AccAreaDebit>();
            AccAreaLedgers = new HashSet<AccAreaLedger>();
            AccIncomeExpenseMasters = new HashSet<AccIncomeExpenseMaster>();
            AccOthersIncomes = new HashSet<AccOthersIncome>();
            DmsAreaChallanForPoints = new HashSet<DmsAreaChallanForPoint>();
            DmsAreaDeliveryChallans = new HashSet<DmsAreaDeliveryChallan>();
            DmsAreaStocks = new HashSet<DmsAreaStock>();
            DmsDellarChallans = new HashSet<DmsDellarChallan>();
            DmsRequisitions = new HashSet<DmsRequisition>();
            DmsTargetPlans = new HashSet<DmsTargetPlan>();
            HrmPiemployements = new HashSet<HrmPiemployement>();
            SetOutletNumbers = new HashSet<SetOutletNumber>();
            SetTerritories = new HashSet<SetTerritory>();
        }

        public int AreaId { get; set; }
        public string AreaCode { get; set; } = null!;
        public string AreaName { get; set; } = null!;
        public string? AreaAddress { get; set; }
        public int RegionId { get; set; }
        public string? AccountCode { get; set; }
        public bool IsActive { get; set; }
        public DateTime LastUpdate { get; set; }
        /// <summary>
        /// DSC Point = 1, Dealer = 2, Sub Dealer = 3
        /// </summary>
        public byte? AreaTypeId { get; set; }

        public virtual SetRegion Region { get; set; } = null!;
        public virtual ICollection<AccAreaDebit> AccAreaDebits { get; set; }
        public virtual ICollection<AccAreaLedger> AccAreaLedgers { get; set; }
        public virtual ICollection<AccIncomeExpenseMaster> AccIncomeExpenseMasters { get; set; }
        public virtual ICollection<AccOthersIncome> AccOthersIncomes { get; set; }
        public virtual ICollection<DmsAreaChallanForPoint> DmsAreaChallanForPoints { get; set; }
        public virtual ICollection<DmsAreaDeliveryChallan> DmsAreaDeliveryChallans { get; set; }
        public virtual ICollection<DmsAreaStock> DmsAreaStocks { get; set; }
        public virtual ICollection<DmsDellarChallan> DmsDellarChallans { get; set; }
        public virtual ICollection<DmsRequisition> DmsRequisitions { get; set; }
        public virtual ICollection<DmsTargetPlan> DmsTargetPlans { get; set; }
        public virtual ICollection<HrmPiemployement> HrmPiemployements { get; set; }
        public virtual ICollection<SetOutletNumber> SetOutletNumbers { get; set; }
        public virtual ICollection<SetTerritory> SetTerritories { get; set; }
    }
}
