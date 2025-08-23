using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class SetFreeSampleProgrammePolicy
    {
        public int ID { get; set; }
        public int? DepoID { get; set; }
        public int? RegionID { get; set; }
        public int? AreaID { get; set; }
        public int? TerritoryID { get; set; }
        public int? RouteID { get; set; }
        public short? Designation { get; set; }
        public short ProductID { get; set; }
        public string ProgrammeName { get; set; }
        public decimal FreeSampleQty { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool? IsDepo { get; set; }
        public bool? IsRegion { get; set; }
        public bool? IsArea { get; set; }
        public bool? IsTerritory { get; set; }
        public bool? IsRoute { get; set; }
        public bool IsActive { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
