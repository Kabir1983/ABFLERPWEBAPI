using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class SystemDmsDmreceivedItemFromFactory
    {
        public long HistoryId { get; set; }
        public long DmritemFfid { get; set; }
        public long Dmrffid { get; set; }
        public long? ChallanDetailId { get; set; }
        public short ProductId { get; set; }
        public long Qty { get; set; }
        public long Dsid { get; set; }
        public int InsertUserId { get; set; }
        public DateTime LastUpdate { get; set; }
        public DateTime EventTime { get; set; }
        public string? Host { get; set; }
        public string? EventType { get; set; }
    }
}
