using Microsoft.EntityFrameworkCore;

namespace ABFLERPWEBAPI.Models
{
    [Keyless]
    public class AndroidAppsGetUserInfoByUserID
    {
        public string? EmployeeName { get; set; }
        public string? PFId { get; set; }
        public string? ParmanentCity { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? EMail { get; set; }
        public string FatherName { get; set; }
        public string? PresentAddress { get; set; }
        public string? ParmanentAddress { get; set; }
        public string EmployeeId { get; set; }
        public string? ContactNo { get; set; }
        public int PIID { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
        public int EmployementID { get; set; }
        public DateTime? JoiningDate { get; set; }
        public byte? DesignationId { get; set; }
        public decimal? Basic { get; set; }
        public string? PhotoPath { get; set; }
        public string? Designation { get; set; }
        public string? Division { get; set; }
        public byte? DivisionID { get; set; }
        public string? Department { get; set; }
        public string? Section { get; set; }
        public int? DepoId { get; set; }
        public string? Depo { get; set; }
        public int? RegionID { get; set; }
        public string? Region { get; set; }
        public int? AreaID { get; set; }
        public string? Area { get; set; }
        public int? TerritoryID { get; set; }
        public string? Territory { get; set; }
        public string Factory { get; set; }

    }
}
