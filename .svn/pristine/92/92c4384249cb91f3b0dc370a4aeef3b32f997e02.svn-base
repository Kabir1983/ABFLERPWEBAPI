using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class OocOutletVisit
    {
        public OocOutletVisit()
        {
            OocSmokerContacts = new HashSet<OocSmokerContact>();
        }

        public long Id { get; set; }
        public DateTime VisitDate { get; set; }
        public int VisitShift { get; set; }
        public int EmployementId { get; set; }
        public long OutletId { get; set; }
        public byte? SalesRefuseTypeId { get; set; }
        public byte? VisibiltyInfoId { get; set; }
        public byte? VisitStatus { get; set; }
        public byte Day { get; set; }
        public byte Month { get; set; }
        public short Year { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual OocSalesRefuseType? SalesRefuseType { get; set; }
        public virtual OocVisibilityInfo? VisibiltyInfo { get; set; }
        public virtual ICollection<OocSmokerContact> OocSmokerContacts { get; set; }
    }
}
