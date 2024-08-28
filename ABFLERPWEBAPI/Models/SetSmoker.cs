using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class SetSmoker
    {
        public long Id { get; set; }
        public DateTime ContactDate { get; set; }
        public int EmployementId { get; set; }
        public long? OutletId { get; set; }
        public int? UnionId { get; set; }
        public string Name { get; set; } = null!;
        public string? Age { get; set; }
        public string? Profession { get; set; }
        public string? MobileNo { get; set; }
        public string? HabitYear { get; set; }
        public string? HabitMonth { get; set; }
        public string? HabitDay { get; set; }
        public byte? SmokerCategoryId { get; set; }
        public string? CurrentBrand { get; set; }
        public byte? CurrentBrandId { get; set; }
        public string? CompanyBrand { get; set; }
        public short? ProductId { get; set; }
        public int? DailyAmount { get; set; }
        public string? Remarks { get; set; }
        public string? ImageUrl { get; set; }
        public string? ImageName { get; set; }
        public DateTime LastUpdate { get; set; }
        public string? VillageRouteName { get; set; }
        public string? MarketName { get; set; }
    }
}
