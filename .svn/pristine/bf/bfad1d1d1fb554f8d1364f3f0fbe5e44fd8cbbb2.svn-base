using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsSample
    {
        public DmsSample()
        {
            DmsSampleItems = new HashSet<DmsSampleItem>();
        }

        public long SampleId { get; set; }
        public long ChallanId { get; set; }
        public int EmployeementId { get; set; }
        public DateTime SampleDate { get; set; }
        public byte Day { get; set; }
        public byte Month { get; set; }
        public short Year { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual DmsAreaDeliveryChallan Challan { get; set; } = null!;
        public virtual HrmPiemployement Employeement { get; set; } = null!;
        public virtual ICollection<DmsSampleItem> DmsSampleItems { get; set; }
    }
}
