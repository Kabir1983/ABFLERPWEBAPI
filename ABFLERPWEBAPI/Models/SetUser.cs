using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class SetUser
    {
        public SetUser()
        {
            //SetSecuredUsers = new HashSet<SetSecuredUser>();
            //SetUserWisePages = new HashSet<SetUserWisePage>();
            //SetUserWiseRoles = new HashSet<SetUserWiseRole>();
        }

        public int Id { get; set; }
        public string UserId { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string? Token { get; set; } = null;
        public int? EmployeeId { get; set; }
        public bool IsActive { get; set; }
        public DateTime LastUpdate { get; set; }
        public DateTime? LoginTime { get; set; } = null;


        //public virtual HrmPi? Employee { get; set; }
        //public virtual ICollection<SetSecuredUser> SetSecuredUsers { get; set; }
        //public virtual ICollection<SetUserWisePage> SetUserWisePages { get; set; }
        //public virtual ICollection<SetUserWiseRole> SetUserWiseRoles { get; set; }
    }
}
