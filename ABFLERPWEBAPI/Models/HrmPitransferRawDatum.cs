using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class HrmPitransferRawDatum
    {
        public int Id { get; set; }
        public int Pisid { get; set; }
        public bool InHeadOffice { get; set; }
        public byte? FactoryId { get; set; }
        public int? DepoId { get; set; }
        public int? RegionId { get; set; }
        public int? AreaId { get; set; }
        public int? TerritoryId { get; set; }
        public byte? DivisionId { get; set; }
        public byte? DepartmentId { get; set; }
        public byte? SectionId { get; set; }
        public DateTime TransferDate { get; set; }
        public bool IsProcess { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
