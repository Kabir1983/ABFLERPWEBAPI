using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ABFLERPWEBAPI.Models
{
    public partial class SetProductCategory
    {
        public SetProductCategory()
        {
            SetProducts = new HashSet<SetProduct>();
        }

        public byte ProductCategoryId { get; set; }
        public string CategoryName { get; set; } = null!;
        public string? Description { get; set; }
        public bool IsActive { get; set; }
        [JsonIgnore]
        public virtual ICollection<SetProduct> SetProducts { get; set; }
    }
}
