using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class HrmPireference
    {
        public int Id { get; set; }
        public int Piid { get; set; }
        public string Name { get; set; } = null!;
        public string Designation { get; set; } = null!;
        public string Relationship { get; set; } = null!;
        public string MobileNo { get; set; } = null!;
        public string Organization { get; set; } = null!;
        public string? Address { get; set; }
        public string? Email { get; set; }
        public string Phone { get; set; } = null!;
    }
}
