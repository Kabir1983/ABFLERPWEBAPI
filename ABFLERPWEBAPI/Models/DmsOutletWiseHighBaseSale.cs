using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsOutletWiseHighBaseSale
    {
        public long Id { get; set; }
        public long OutletId { get; set; }
        public int HighestSalesQty { get; set; }
        public int BaseSalesQty { get; set; }
        public int Oct2019SalesQty { get; set; }
        public bool? IsActive { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
