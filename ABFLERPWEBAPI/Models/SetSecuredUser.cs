using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class SetSecuredUser
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string SecureWord { get; set; } = null!;
        public DateTime LastUpdate { get; set; }

        public virtual SetUser User { get; set; } = null!;
    }
}
