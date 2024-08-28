using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class TablePkid
    {
        public short Id { get; set; }
        public string TableName { get; set; } = null!;
        public string MaxId { get; set; } = null!;
        public DateTime LastUpdate { get; set; }
    }
}
