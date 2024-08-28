using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class SetUserWisePage
    {
        public long Id { get; set; }
        public int UserId { get; set; }
        public int ModuleSubMuduleId { get; set; }

        public virtual SetModuleWiseSubmodule ModuleSubMudule { get; set; } = null!;
        public virtual SetUser User { get; set; } = null!;
    }
}
