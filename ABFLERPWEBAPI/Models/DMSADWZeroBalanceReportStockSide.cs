﻿namespace ABFLERPWEBAPI.Models
{
    public class DMSADWZeroBalanceReportStockSide
    {
        public long ID {  get; set; }
        public DateTime Date {  get; set; }
        public int AreaID {  get; set; }
        public Int16 ProductID {  get; set; }
        public string ProductName { get; set; }
        public byte Sticks { get; set; }
        public decimal TP { get; set; }
        public int ZBRIID { get; set; }
        public int TranType { get; set; }
        public int SubTranType { get; set; }
        public decimal Total{ get; set; }
        public decimal TotalAmount{ get; set; }
        public string? Remarks { get; set; }
        public bool IsActive { get; set; }
        public DateTime LastUpdate { get; set; }

    }
}