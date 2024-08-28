using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsSrprojectParameter
    {
        public DmsSrprojectParameter()
        {
            DmsSrprojectInfos = new HashSet<DmsSrprojectInfo>();
        }

        public short ParameterId { get; set; }
        public string ParameterName { get; set; } = null!;
        public bool? IsActive { get; set; }
        public DateTime Lastupdate { get; set; }

        public virtual ICollection<DmsSrprojectInfo> DmsSrprojectInfos { get; set; }
    }
}
