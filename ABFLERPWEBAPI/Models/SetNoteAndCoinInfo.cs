using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class SetNoteAndCoinInfo
    {
        public SetNoteAndCoinInfo()
        {
            DmsAreaDeliveryChallanMoneys = new HashSet<DmsAreaDeliveryChallanMoney>();
        }

        public byte Id { get; set; }
        public string MoneyNoteOrCoin { get; set; } = null!;
        public decimal Amount { get; set; }
        public bool IsCoin { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<DmsAreaDeliveryChallanMoney> DmsAreaDeliveryChallanMoneys { get; set; }
    }
}
