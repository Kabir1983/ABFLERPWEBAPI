using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class SetModule
    {
        public SetModule()
        {
            SetModuleWiseSubmodules = new HashSet<SetModuleWiseSubmodule>();
        }

        public int ModuleId { get; set; }
        public string ModuleName { get; set; } = null!;
        public bool IsActive { get; set; }

        public virtual ICollection<SetModuleWiseSubmodule> SetModuleWiseSubmodules { get; set; }
    }
}
