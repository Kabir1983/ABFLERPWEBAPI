using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class HrmPiemployement
    {
        public HrmPiemployement()
        {
            DmsAreaChallanForPoints = new HashSet<DmsAreaChallanForPoint>();
            DmsAreaDeliveryChallans = new HashSet<DmsAreaDeliveryChallan>();
            DmsDellarChallans = new HashSet<DmsDellarChallan>();
            DmsDepoChallans = new HashSet<DmsDepoChallan>();
            DmsDepoToDepoChallans = new HashSet<DmsDepoToDepoChallan>();
            DmsFactoryChallans = new HashSet<DmsFactoryChallan>();
            DmsIncentiveMasters = new HashSet<DmsIncentiveMaster>();
            DmsOrders = new HashSet<DmsOrder>();
            DmsSamples = new HashSet<DmsSample>();
            DmsTargetPlanItems = new HashSet<DmsTargetPlanItem>();
            HrmEmployeeSalaryInfos = new HashSet<HrmEmployeeSalaryInfo>();
            HrmEmployeeTransfers = new HashSet<HrmEmployeeTransfer>();
        }

        public int Id { get; set; }
        public int Piid { get; set; }
        public byte? EmployeeCategoryId { get; set; }
        public byte? JobPositionId { get; set; }
        public byte? PayGradeId { get; set; }
        public bool InHeadOffice { get; set; }
        public byte? FactoryId { get; set; }
        public int? DepoId { get; set; }
        public int? RegionId { get; set; }
        public int? AreaId { get; set; }
        public int? TerritoryId { get; set; }
        public byte DesignationId { get; set; }
        public byte? DivisionId { get; set; }
        public byte? DepartmentId { get; set; }
        public byte? SectionId { get; set; }
        public DateTime JoiningDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? PpstartDate { get; set; }
        public DateTime? PpendDate { get; set; }
        public byte? AgreementTypeId { get; set; }
        public decimal Basic { get; set; }
        public decimal? HouseRent { get; set; }
        public decimal? MedicalAllowance { get; set; }
        public decimal? Conveyence { get; set; }
        public decimal? CityAllowance { get; set; }
        public bool? IsBonusApplicable { get; set; }
        public bool? IsActive { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual SetArea? Area { get; set; }
        public virtual SetDepartment? Department { get; set; }
        public virtual SetDepo? Depo { get; set; }
        public virtual SetHrdesignation Designation { get; set; } = null!;
        public virtual SetDivision? Division { get; set; }
        public virtual SetFactory? Factory { get; set; }
        public virtual HrmPi Pi { get; set; } = null!;
        public virtual SetRegion? Region { get; set; }
        public virtual SetSection? Section { get; set; }
        public virtual SetTerritory? Territory { get; set; }
        public virtual ICollection<DmsAreaChallanForPoint> DmsAreaChallanForPoints { get; set; }
        public virtual ICollection<DmsAreaDeliveryChallan> DmsAreaDeliveryChallans { get; set; }
        public virtual ICollection<DmsDellarChallan> DmsDellarChallans { get; set; }
        public virtual ICollection<DmsDepoChallan> DmsDepoChallans { get; set; }
        public virtual ICollection<DmsDepoToDepoChallan> DmsDepoToDepoChallans { get; set; }
        public virtual ICollection<DmsFactoryChallan> DmsFactoryChallans { get; set; }
        public virtual ICollection<DmsIncentiveMaster> DmsIncentiveMasters { get; set; }
        public virtual ICollection<DmsOrder> DmsOrders { get; set; }
        public virtual ICollection<DmsSample> DmsSamples { get; set; }
        public virtual ICollection<DmsTargetPlanItem> DmsTargetPlanItems { get; set; }
        public virtual ICollection<HrmEmployeeSalaryInfo> HrmEmployeeSalaryInfos { get; set; }
        public virtual ICollection<HrmEmployeeTransfer> HrmEmployeeTransfers { get; set; }
    }
}
