using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class AccBankWiseAmout
    {
        public long TransactionId { get; set; }
        public int Dbaid { get; set; }
        public DateTime Date { get; set; }
        public short? TransactionType { get; set; }
        public decimal Amount { get; set; }
        public int? Territory { get; set; }
        public int? DdreceiveDbaid { get; set; }
        public string? DdorPayOrderNo { get; set; }
        public bool IsApprovedByDm { get; set; }
        public long? Mrno { get; set; }
        public DateTime? DepoApproveDate { get; set; }
        public int? DapproverId { get; set; }
        public bool IsApprovedByHo { get; set; }
        public DateTime? HoapproveDate { get; set; }
        public int? HoapproverId { get; set; }
        public int EntryBy { get; set; }
        public string Remarks { get; set; } = null!;

        public virtual AccDepoWiseBankAccount Dba { get; set; } = null!;
        public virtual AccTransactionType? TransactionTypeNavigation { get; set; }
    }
}
