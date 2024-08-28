﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace ABFLERPWEBAPI.Models
{
    [Keyless]
    public class ACCGETDateWiseOnlySoleDepotZeroBalanceReportStockPart
    {
        public string? ProductName { get; set; }
        public byte? Sticks { get; set; }
        public string? Remarks { get; set; }
        public decimal? TP { get; set; }
        public decimal? TPPerPacket { get; set; }
        public string? TranType { get; set; }
        public string? SubTranType { get; set; }
        public Int16? ProductId { get; set; }
        public decimal? Total { get; set; }
        public decimal? TotalValue { get; set; }
    }
}