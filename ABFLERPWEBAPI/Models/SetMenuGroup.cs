using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class SetMenuGroup
    {
        public SetMenuGroup()
        {
            SetSubModules = new HashSet<SetSubModule>();
        }

        public byte MenuGroupId { get; set; }
        public string MenuGroupName { get; set; } = null!;

        public virtual ICollection<SetSubModule> SetSubModules { get; set; }
    }
}
