using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class SetSurveyType
    {
        public byte Id { get; set; }
        public string SurveyType { get; set; } = null!;
        public bool? IsActive { get; set; }
        public DateTime Lastupdate { get; set; }
    }
}
