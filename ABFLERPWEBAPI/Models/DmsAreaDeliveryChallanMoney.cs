using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsAreaDeliveryChallanMoney
    {
        public long Id { get; set; }
        public long ChallanId { get; set; }
        public byte NoteId { get; set; }
        public int NoOfNote { get; set; }
        public decimal TotalAmount { get; set; }

        public virtual SetNoteAndCoinInfo Note { get; set; } = null!;
    }
}
