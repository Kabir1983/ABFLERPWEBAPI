using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class FacItemUnitWisePackSize
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public short ItemUnitId { get; set; }
        public int ItemUnitQty { get; set; }
        public short AssignItemUnitId { get; set; }
        public int AssignItemUnitQty { get; set; }
        public string Description { get; set; } = null!;
        public bool? IsActive { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
