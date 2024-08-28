using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class SetEmployeeInfo
    {
        public int EmploymentId { get; set; }
        public int EmployeeId { get; set; }
        public string? UserId { get; set; }
        public string EmployeeName { get; set; } = null!;
        public byte DesignationId { get; set; }
        public string DesignationName { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }
        public long ProximityId { get; set; }
        public string? PresentAddress { get; set; }
        public string? ContactNo1 { get; set; }
        public DateTime JoiningDate { get; set; }
        public string? Pfid { get; set; }
        public bool IsActive { get; set; }
        public bool InHeadOffice { get; set; }
        public byte? FactoryId { get; set; }
        public string? FactoryName { get; set; }
        public int? DepoId { get; set; }
        public string? DepoName { get; set; }
        public int? RegionId { get; set; }
        public string? RegionName { get; set; }
        public int? AreaId { get; set; }
        public string? AreaName { get; set; }
        public int? TerritoryId { get; set; }
        public string? TerritoryName { get; set; }
        public byte? DivisionId { get; set; }
        public string? DivisionName { get; set; }
    }
}
