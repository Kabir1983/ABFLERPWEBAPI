﻿using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class AccZeroBalanceReportItem
    {

        public int ID { get; set; }
        public string ItemName { get; set; }
        public byte TranType { get; set; }
        public byte SubTranType { get; set; }
        public byte ReportType { get; set; }
        public decimal SlNo { get; set; }
        public bool IsActive { get; set; }
        public DateTime LastUpdate { get; set; }

    }
}
