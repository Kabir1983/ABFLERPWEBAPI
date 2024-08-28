using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class SetRole
    {
        public SetRole()
        {
            SetRoleWisePages = new HashSet<SetRoleWisePage>();
            SetUserWiseRoles = new HashSet<SetUserWiseRole>();
        }

        public byte RoleId { get; set; }
        public string RoleName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public bool IsActive { get; set; }

        public virtual ICollection<SetRoleWisePage> SetRoleWisePages { get; set; }
        public virtual ICollection<SetUserWiseRole> SetUserWiseRoles { get; set; }
    }
}
