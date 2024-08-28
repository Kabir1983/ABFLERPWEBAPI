using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsSrwiseDailyActivitiesItem
    {
        public int Id { get; set; }
        public string ActivitesItem { get; set; } = null!;
        public byte ItemType { get; set; }
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
