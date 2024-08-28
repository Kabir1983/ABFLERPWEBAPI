using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsSampleItem
    {
        public DmsSampleItem()
        {
            DmsSampleItemSmokers = new HashSet<DmsSampleItemSmoker>();
        }

        public long SampleItemId { get; set; }
        public long SampleId { get; set; }
        public short ProductId { get; set; }
        public int Quantity { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual SetProduct Product { get; set; } = null!;
        public virtual DmsSample Sample { get; set; } = null!;
        public virtual ICollection<DmsSampleItemSmoker> DmsSampleItemSmokers { get; set; }
    }
}
