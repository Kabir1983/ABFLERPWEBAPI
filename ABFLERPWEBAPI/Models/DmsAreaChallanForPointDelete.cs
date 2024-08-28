﻿using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsAreaChallanForPointDelete
    {
        public long ChallanId { get; set; }
        public int Srid { get; set; }
        public int AreaId { get; set; }
        public string? Driver { get; set; }
        public string? VanNo { get; set; }
        public int RouteId { get; set; }
        public string ChallanNo { get; set; } = null!;
        public DateTime ChallanDate { get; set; }
        public string? Remarks { get; set; }
        public string? AlternetSr { get; set; }
        public int? ResSrid { get; set; }
        public int? ChallanById { get; set; }
        public bool IsReceived { get; set; }
        public DateTime? LastUpdate { get; set; }
        public bool? IsOrderClosed { get; set; }
        public long? Rn { get; set; }
    }
}
