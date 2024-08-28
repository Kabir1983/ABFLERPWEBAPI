using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class HrmEtchoicePlace
    {
        public long Id { get; set; }
        public long Etid { get; set; }
        public byte ChoiceTypeId { get; set; }
        public int? DivisionId { get; set; }
        public int? DepoId { get; set; }
        public int? RegionId { get; set; }
        public int? AreaId { get; set; }
        public int? TerritoryId { get; set; }
        public bool IsActive { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual FtChoiceType ChoiceType { get; set; } = null!;
        public virtual HrmEmployeeTransfer Et { get; set; } = null!;
    }
}
