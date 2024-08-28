using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class SetDistrict
    {
        public SetDistrict()
        {
            SetPostOffices = new HashSet<SetPostOffice>();
            SetThanas = new HashSet<SetThana>();
        }

        public int Id { get; set; }
        public string DistrictName { get; set; } = null!;
        public string? Description { get; set; }
        public byte DivisionId { get; set; }

        public virtual ICollection<SetPostOffice> SetPostOffices { get; set; }
        public virtual ICollection<SetThana> SetThanas { get; set; }
    }
}
