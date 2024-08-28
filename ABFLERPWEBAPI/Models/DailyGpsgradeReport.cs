using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DailyGpsgradeReport
    {
        public long Id { get; set; }
        public long EmployeeId { get; set; }
        public string EmployeeName { get; set; } = null!;
        public string UserId { get; set; } = null!;
        public string Post { get; set; } = null!;
        public DateTime JoinDate { get; set; }
        public int TotalDay { get; set; }
        public int? DivisionId { get; set; }
        public string? DivisionName { get; set; }
        public int? DepoId { get; set; }
        public string? DepoName { get; set; }
        public int? RegionId { get; set; }
        public string? RegionName { get; set; }
        public int? AreaId { get; set; }
        public string? AreaName { get; set; }
        public int? TerritoryId { get; set; }
        public string? TerritoryName { get; set; }
        public int TotalGpshours { get; set; }
        public string Grade { get; set; } = null!;
        public DateTime Date { get; set; }
    }
}
