using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class FacReceiveItemFromHodetail
    {
        public long FridetailId { get; set; }
        public long Frihoid { get; set; }
        public long Fisid { get; set; }
        public int ItemId { get; set; }
        public short UnitId { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal ReceiveQty { get; set; }
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
        public DateTime Lastupdate { get; set; }

        public virtual FacFactoryItemStock Fis { get; set; } = null!;
        public virtual FacReceiveItemFromHo Friho { get; set; } = null!;
        public virtual FacItemInfo Item { get; set; } = null!;
        public virtual FacItemUnit Unit { get; set; } = null!;
    }
}
