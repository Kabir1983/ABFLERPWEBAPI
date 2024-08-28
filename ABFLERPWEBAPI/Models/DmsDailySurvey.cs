using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsDailySurvey
    {
        public long Id { get; set; }
        public long EmployeementId { get; set; }
        public DateTime Date { get; set; }
        public int SurveyItemId { get; set; }
        public string? Remarks { get; set; }
        public bool HasProblem { get; set; }
        public bool IsSurveyComplete { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
