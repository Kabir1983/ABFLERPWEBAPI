using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class SetHrleaveProfile
    {
        public SetHrleaveProfile()
        {
            HrmLeaveApplications = new HashSet<HrmLeaveApplication>();
        }

        public byte Id { get; set; }
        public byte? EmployeeCategoryId { get; set; }
        public byte? AgreementTypeId { get; set; }
        public byte LeaveTypeId { get; set; }
        public byte NumberOfDay { get; set; }
        public byte? GenderId { get; set; }
        public bool StartLvOnJoin { get; set; }
        public byte? StartLvMon { get; set; }
        public bool StartAfterProvisionPeriod { get; set; }
        public byte? UseAfter { get; set; }
        public short? MaxConsecuDay { get; set; }
        public bool AllowHalfDay { get; set; }
        public bool AllowPartialDay { get; set; }
        public bool AllowPartialAsHalfDay { get; set; }
        public bool RequireReason { get; set; }
        public bool CanAdjust { get; set; }
        public bool AllowAdvanceLv { get; set; }
        public bool AllowTotLvOnJoin { get; set; }
        public bool AllowPartLvOnJoin { get; set; }
        public short? AccrualPeriod { get; set; }
        public decimal? AccrualFactor { get; set; }
        public byte? EncashAmtPc1 { get; set; }
        public byte? EncashAmtPc2 { get; set; }
        public bool CanCarryForward { get; set; }
        public byte? CarryForwardNumb { get; set; }
        public byte? MaxEncash { get; set; }
        public bool AllowSuccDayLv { get; set; }
        public bool AllowPrecedDayLv { get; set; }
        public bool AllowInterDayLv { get; set; }
        public short? MaxEmployee { get; set; }
        public bool NeedDocApproval { get; set; }
        public short? DocApprConsecuDays { get; set; }

        public virtual FtAggreementType? AgreementType { get; set; }
        public virtual SetJobPosition? AgreementTypeNavigation { get; set; }
        public virtual FtGender? Gender { get; set; }
        public virtual FtHrleaveType LeaveType { get; set; } = null!;
        public virtual ICollection<HrmLeaveApplication> HrmLeaveApplications { get; set; }
    }
}
