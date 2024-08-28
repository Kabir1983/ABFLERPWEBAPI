using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class SetUserWiseRole
    {
        public int Id { get; set; }
        public byte RoleId { get; set; }
        public int UserId { get; set; }

        public virtual SetRole Role { get; set; } = null!;
        public virtual SetUser User { get; set; } = null!;
    }
}
