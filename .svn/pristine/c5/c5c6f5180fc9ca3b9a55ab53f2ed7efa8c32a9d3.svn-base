using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class OocSalesRefuseType
    {
        public OocSalesRefuseType()
        {
            OocOutletVisits = new HashSet<OocOutletVisit>();
        }

        public byte Id { get; set; }
        public string SalesRefuseType { get; set; } = null!;
        public string SalesRefuseTypeCode { get; set; } = null!;
        public bool IsActive { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual ICollection<OocOutletVisit> OocOutletVisits { get; set; }
    }
}
