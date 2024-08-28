using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class HrmPi
    {
        public HrmPi()
        {
            DmsRoutePlans = new HashSet<DmsRoutePlan>();
            HrmAdvanceApplicationApplyBies = new HashSet<HrmAdvanceApplication>();
            HrmAdvanceApplicationEmployees = new HashSet<HrmAdvanceApplication>();
            HrmAdvanceApprovals = new HashSet<HrmAdvanceApproval>();
            HrmLeaveApplications = new HashSet<HrmLeaveApplication>();
            HrmLeaveApprovals = new HashSet<HrmLeaveApproval>();
            HrmLoanApplicationApplyBies = new HashSet<HrmLoanApplication>();
            HrmLoanApplicationEmployees = new HashSet<HrmLoanApplication>();
            HrmLoanApprovals = new HashSet<HrmLoanApproval>();
            HrmPayrollSalaryDetails = new HashSet<HrmPayrollSalaryDetail>();
            HrmPiemployements = new HashSet<HrmPiemployement>();
            HrmPifamilyInfos = new HashSet<HrmPifamilyInfo>();
            HrmPiincrements = new HashSet<HrmPiincrement>();
            HrmPijobExperiences = new HashSet<HrmPijobExperience>();
            HrmPinominees = new HashSet<HrmPinominee>();
            HrmPiqualifications = new HashSet<HrmPiqualification>();
            HrmPiterminationApplyBies = new HashSet<HrmPitermination>();
            HrmPiterminationPis = new HashSet<HrmPitermination>();
            HrmPitransfers = new HashSet<HrmPitransfer>();
            HrmTerminationApprovals = new HashSet<HrmTerminationApproval>();
            //SetUsers = new HashSet<SetUser>();
        }

        public int Id { get; set; }
        public string EmployeeId { get; set; } = null!;
        public long ProximityId { get; set; }
        public string FirstName { get; set; } = null!;
        public string? LastName { get; set; }
        public string? MiddleName { get; set; }
        public string? NickName { get; set; }
        public string FatherName { get; set; } = null!;
        public string? MotherName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public byte GenderId { get; set; }
        public byte? BloodGroupId { get; set; }
        public byte? MeritalStatusId { get; set; }
        public byte? ReligionId { get; set; }
        public string Nationality { get; set; } = null!;
        public string? ParmanentAddress { get; set; }
        public string? ParmanentCity { get; set; }
        public short? ParmanentCountryId { get; set; }
        public string? ParmanentZip { get; set; }
        public string? PresentAddress { get; set; }
        public string? PresentCity { get; set; }
        public short? PresentCountryId { get; set; }
        public string? PresentZip { get; set; }
        public string? ContactNo1 { get; set; }
        public string? ContactNo2 { get; set; }
        public string? HomePhone { get; set; }
        public string? Email { get; set; }
        public string? NationalIdno { get; set; }
        public string? PassportNo { get; set; }
        public byte Status { get; set; }
        public string? PhotoPath { get; set; }
        public DateTime? JoinDate { get; set; }
        public string? Pfid { get; set; }
        public int? ResponsiblePerson { get; set; }

        public virtual FtGender Gender { get; set; } = null!;
        public virtual ICollection<DmsRoutePlan> DmsRoutePlans { get; set; }
        public virtual ICollection<HrmAdvanceApplication> HrmAdvanceApplicationApplyBies { get; set; }
        public virtual ICollection<HrmAdvanceApplication> HrmAdvanceApplicationEmployees { get; set; }
        public virtual ICollection<HrmAdvanceApproval> HrmAdvanceApprovals { get; set; }
        public virtual ICollection<HrmLeaveApplication> HrmLeaveApplications { get; set; }
        public virtual ICollection<HrmLeaveApproval> HrmLeaveApprovals { get; set; }
        public virtual ICollection<HrmLoanApplication> HrmLoanApplicationApplyBies { get; set; }
        public virtual ICollection<HrmLoanApplication> HrmLoanApplicationEmployees { get; set; }
        public virtual ICollection<HrmLoanApproval> HrmLoanApprovals { get; set; }
        public virtual ICollection<HrmPayrollSalaryDetail> HrmPayrollSalaryDetails { get; set; }
        public virtual ICollection<HrmPiemployement> HrmPiemployements { get; set; }
        public virtual ICollection<HrmPifamilyInfo> HrmPifamilyInfos { get; set; }
        public virtual ICollection<HrmPiincrement> HrmPiincrements { get; set; }
        public virtual ICollection<HrmPijobExperience> HrmPijobExperiences { get; set; }
        public virtual ICollection<HrmPinominee> HrmPinominees { get; set; }
        public virtual ICollection<HrmPiqualification> HrmPiqualifications { get; set; }
        public virtual ICollection<HrmPitermination> HrmPiterminationApplyBies { get; set; }
        public virtual ICollection<HrmPitermination> HrmPiterminationPis { get; set; }
        public virtual ICollection<HrmPitransfer> HrmPitransfers { get; set; }
        public virtual ICollection<HrmTerminationApproval> HrmTerminationApprovals { get; set; }
        //public virtual ICollection<SetUser> SetUsers { get; set; }
    }
}
