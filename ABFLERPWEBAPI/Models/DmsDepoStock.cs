using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class DmsDepoStock
    {
        public DmsDepoStock()
        {
            DmsAreaReturnReceiveDetails = new HashSet<DmsAreaReturnReceiveDetail>();
            DmsDamageReceiveFromDepoDellarDetails = new HashSet<DmsDamageReceiveFromDepoDellarDetail>();
            DmsDamageReceivedItemFromAreas = new HashSet<DmsDamageReceivedItemFromArea>();
            DmsDamageReturnToFactoryDetails = new HashSet<DmsDamageReturnToFactoryDetail>();
            DmsDepoChallanItems = new HashSet<DmsDepoChallanItem>();
            DmsDepoDellarChallanItemToDamages = new HashSet<DmsDepoDellarChallanItemToDamage>();
            DmsDepoDellarChallanItems = new HashSet<DmsDepoDellarChallanItem>();
            DmsDepoOpeningStocks = new HashSet<DmsDepoOpeningStock>();
            DmsDepoReturnDetails = new HashSet<DmsDepoReturnDetail>();
            DmsDepoToDepoChallanItems = new HashSet<DmsDepoToDepoChallanItem>();
        }

        public long Dsid { get; set; }
        public int DepoId { get; set; }
        public short ProductId { get; set; }
        /// <summary>
        /// if 1 then fresh stock if 2 then damage stock
        /// </summary>
        public byte StockType { get; set; }
        public long Qty { get; set; }
        public long Balance { get; set; }
        public decimal Tp { get; set; }
        public DateTime StockDate { get; set; }

        public virtual SetDepo Depo { get; set; } = null!;
        public virtual SetProduct Product { get; set; } = null!;
        public virtual ICollection<DmsAreaReturnReceiveDetail> DmsAreaReturnReceiveDetails { get; set; }
        public virtual ICollection<DmsDamageReceiveFromDepoDellarDetail> DmsDamageReceiveFromDepoDellarDetails { get; set; }
        public virtual ICollection<DmsDamageReceivedItemFromArea> DmsDamageReceivedItemFromAreas { get; set; }
        public virtual ICollection<DmsDamageReturnToFactoryDetail> DmsDamageReturnToFactoryDetails { get; set; }
        public virtual ICollection<DmsDepoChallanItem> DmsDepoChallanItems { get; set; }
        public virtual ICollection<DmsDepoDellarChallanItemToDamage> DmsDepoDellarChallanItemToDamages { get; set; }
        public virtual ICollection<DmsDepoDellarChallanItem> DmsDepoDellarChallanItems { get; set; }
        public virtual ICollection<DmsDepoOpeningStock> DmsDepoOpeningStocks { get; set; }
        public virtual ICollection<DmsDepoReturnDetail> DmsDepoReturnDetails { get; set; }
        public virtual ICollection<DmsDepoToDepoChallanItem> DmsDepoToDepoChallanItems { get; set; }
    }
}
