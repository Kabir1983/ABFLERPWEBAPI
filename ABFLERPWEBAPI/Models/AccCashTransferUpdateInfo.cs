﻿using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class AccCashTransferUpdateInfo
    {
        public long Id { get; set; }
        public long Ieid { get; set; }
        public long Iedid { get; set; }
        public long CashTransferId { get; set; }
        public int RefEmployeeId { get; set; }
        public string UpdateDeleteStatus { get; set; } = null!;
        public DateTime LastUpdate { get; set; }
    }
}
