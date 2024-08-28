using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class HrmPitransfer
    {
        public int TransferId { get; set; }
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
        public bool IsActive { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual SetDepo? Depo { get; set; }
        public virtual SetFactory? Factory { get; set; }
        public virtual HrmPi Pis { get; set; } = null!;
        public virtual SetTerritory? Territory { get; set; }
    }
}
