using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsOutletWiseIncentive
    {
        public long ID { get; set; }
        public long OutletID { get; set; }
        public DateTime Date { get; set; }
        public string Day { get; set; }
        public int Week { get; set; }
        public int ProductID { get; set; }
        public int SalesQty { get; set; }
        public int PolicyID { get; set; }
        public decimal TotalDiscount { get; set; }
        public decimal LighterTaka { get; set; }
        public Int16 VisitFrequencyID { get; set; }
        public bool IsApplicable { get; set; }
        public bool IsActive { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
