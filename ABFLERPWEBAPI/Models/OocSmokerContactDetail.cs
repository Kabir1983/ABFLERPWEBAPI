using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class OocSmokerContactDetail
    {
        public int Id { get; set; }
        public int SmokerId { get; set; }
        public DateTime ContactDate { get; set; }
        public int EmployementId { get; set; }
        public int? OutletId { get; set; }
        public int? UnionId { get; set; }
        public int? VisitId { get; set; }
        public byte? SmokerCategoryId { get; set; }
        public string? CurrentBrand { get; set; }
        public byte? CurrentBrandId { get; set; }
        public string? CompanyBrand { get; set; }
        public short? ProductId { get; set; }
        public int? DailyAmount { get; set; }
        public string? VillageRouteName { get; set; }
        public string? MarketName { get; set; }
        public string? Remarks { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
