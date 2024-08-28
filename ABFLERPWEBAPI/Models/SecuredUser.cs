using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class SecuredUser
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string SecureWord { get; set; } = null!;
        public DateTime LastUpdate { get; set; }
    }
}
