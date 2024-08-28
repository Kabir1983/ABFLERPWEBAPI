using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsAreaOpeningStock
    {
        public long Id { get; set; }
        public int AreaId { get; set; }
        public short ProductId { get; set; }
        public long Qty { get; set; }
        public long Asid { get; set; }
        public int InsertUserId { get; set; }
        public DateTime CreateDate { get; set; }

        public virtual DmsAreaStock As { get; set; } = null!;
    }
}
