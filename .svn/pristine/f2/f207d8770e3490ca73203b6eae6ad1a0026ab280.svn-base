using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class SetModuleWiseSubmodule
    {
        public SetModuleWiseSubmodule()
        {
            SetRoleWisePages = new HashSet<SetRoleWisePage>();
            SetUserWisePages = new HashSet<SetUserWisePage>();
        }

        public int Id { get; set; }
        public int ModuleId { get; set; }
        public int SubmoduleId { get; set; }

        public virtual SetModule Module { get; set; } = null!;
        public virtual SetSubModule Submodule { get; set; } = null!;
        public virtual ICollection<SetRoleWisePage> SetRoleWisePages { get; set; }
        public virtual ICollection<SetUserWisePage> SetUserWisePages { get; set; }
    }
}
