using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class SetPayGrade
    {
        public SetPayGrade()
        {
            HrmPiincrements = new HashSet<HrmPiincrement>();
        }

        public byte Id { get; set; }
        public string Name { get; set; } = null!;
        public decimal BasicFrom { get; set; }
        public decimal BasicTo { get; set; }
        public string? Description { get; set; }
        public double HouseRent { get; set; }
        public decimal? TransportAllowance { get; set; }
        public decimal? FoodAllowance { get; set; }
        public double MedicalAllowance { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<HrmPiincrement> HrmPiincrements { get; set; }
    }
}
