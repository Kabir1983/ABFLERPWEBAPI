using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public class DMSSalesTargetWiseTotalMemoPoint
    {
        public long ID { get; set; } 
        public long CallanID { get; set; }
        public long OrderID { get; set; }
        public Int16 STTID { get; set; }
        public Int16 TotalMemo { get; set; }
        public DateTime LastUpdate { get; set; }

        public string StartMemo { get; set; }

        public string EndMemo { get; set; }
    }
}
