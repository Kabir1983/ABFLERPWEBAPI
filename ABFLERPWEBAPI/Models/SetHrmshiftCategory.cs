using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class SetHrmshiftCategory
    {
        public SetHrmshiftCategory()
        {
            SetHrmshiftTypes = new HashSet<SetHrmshiftType>();
        }

        public byte Id { get; set; }
        public string CategoryName { get; set; } = null!;
        public string? Description { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<SetHrmshiftType> SetHrmshiftTypes { get; set; }
    }
}
