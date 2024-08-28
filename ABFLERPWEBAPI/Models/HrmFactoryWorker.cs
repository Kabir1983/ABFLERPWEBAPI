using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class HrmFactoryWorker
    {
        public long Id { get; set; }
        public long CardNo { get; set; }
        public string RegNo { get; set; } = null!;
        public long? FacAndWtcardNo { get; set; }
        public string WorkerName { get; set; } = null!;
        public string? FathersName { get; set; }
        public string? MothersName { get; set; }
        public string? MobileNo { get; set; }
        public string? Address { get; set; }
        public string? NationalIdno { get; set; }
        public long ProductSticks { get; set; }
        public byte FactoryId { get; set; }
        public string FactoryName { get; set; } = null!;
        public byte WorkerTypeId { get; set; }
        public string? ImageUrl { get; set; }
        public byte[]? WorkerPhoto { get; set; }
        public int ProductionCarton { get; set; }
        public string? VillageName { get; set; }
        public int? PostOfficeId { get; set; }
        public int? UnionId { get; set; }
        public DateTime? DateofBirth { get; set; }
        public string CardType { get; set; } = null!;
        public bool? IsActive { get; set; }
        public DateTime LastUpdate { get; set; }
        public string? PhotoType { get; set; }
        public short? ProductId { get; set; }
        public string? CheckerCode { get; set; }
        public int? PateeSticks { get; set; }
        public int? TotalPatee { get; set; }
        public string? CheckerName { get; set; }

        public virtual SetFactory Factory { get; set; } = null!;
    }
}
