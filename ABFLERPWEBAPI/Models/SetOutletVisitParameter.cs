using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class SetOutletVisitParameter
    {
        public Int16 ID { get; set; }
        public string ParameterCode { get; set; }
        public string ParameterName { get; set; }
        public string ParameterNameBangla { get; set; }
        public string? Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime Lastupdate { get; set; }
    }
}
