using Microsoft.EntityFrameworkCore;
using System;

namespace ABFLERPWEBAPI.Models
{
    [Keyless]
    public class AndroidSPGetSRWiseRoute
    {
        public long ID { get; set; }
        public int RouteID { get; set; }
        public string RouteName { get; set; }
        public string RouteCode { get; set; }
        public int SRID { get; set; }
        public int VPID { get; set; }
        public bool IsSat { get; set; }
        public bool IsSun { get; set; }
        public bool IsMon { get; set; }
        public bool IsTue { get; set; }
        public bool IsWed { get; set; }
        public bool IsThu { get; set; }
        public bool IsFri { get; set; }

    }
}
