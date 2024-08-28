using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class SetSubModule
    {
        public SetSubModule()
        {
            InverseParent = new HashSet<SetSubModule>();
            SetModuleWiseSubmodules = new HashSet<SetModuleWiseSubmodule>();
        }

        public int SmoduleId { get; set; }
        public int? ParentId { get; set; }
        public string Name { get; set; } = null!;
        public string? PageTitle { get; set; }
        public byte? MenuLevel { get; set; }
        public byte? MenuGroup { get; set; }
        public short SerialNo { get; set; }
        public bool? IsPageOrMenu { get; set; }
        public bool IsParent { get; set; }
        public string? Url { get; set; }

        public virtual SetMenuGroup? MenuGroupNavigation { get; set; }
        public virtual SetSubModule? Parent { get; set; }
        public virtual ICollection<SetSubModule> InverseParent { get; set; }
        public virtual ICollection<SetModuleWiseSubmodule> SetModuleWiseSubmodules { get; set; }
    }
}
