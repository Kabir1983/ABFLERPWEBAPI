using System;
using System.Collections.Generic;

namespace ABFLERPWEBAPI.Models
{
    public partial class SetFactory
    {
        public SetFactory()
        {
            AccIncomeExpenseMasters = new HashSet<AccIncomeExpenseMaster>();
            DmsFactoryChallanDetialsWithBarcodes = new HashSet<DmsFactoryChallanDetialsWithBarcode>();
            DmsFactoryReceives = new HashSet<DmsFactoryReceive>();
            DmsFactoryStocks = new HashSet<DmsFactoryStock>();
            DmsNapkinFactoryStocks = new HashSet<DmsNapkinFactoryStock>();
            FacFacToFacItemDistributionFromFactories = new HashSet<FacFacToFacItemDistribution>();
            FacFacToFacItemDistributionToFactories = new HashSet<FacFacToFacItemDistribution>();
            FacFacToFacItemReceiveFromFactories = new HashSet<FacFacToFacItemReceive>();
            FacFacToFacItemReceiveToFactories = new HashSet<FacFacToFacItemReceive>();
            FacFactoryItemStocks = new HashSet<FacFactoryItemStock>();
            FacJarTamakFactoryItemStocks = new HashSet<FacJarTamakFactoryItemStock>();
            FacJarTobaccoIssueToChatals = new HashSet<FacJarTobaccoIssueToChatal>();
            FacJarTobaccoReceiveFromChatals = new HashSet<FacJarTobaccoReceiveFromChatal>();
            FacWorkerWages = new HashSet<FacWorkerWage>();
            HrmFactoryWorkers = new HashSet<HrmFactoryWorker>();
            HrmPiemployements = new HashSet<HrmPiemployement>();
            HrmPitransfers = new HashSet<HrmPitransfer>();
        }

        public byte FactoryId { get; set; }
        public string FactoryName { get; set; } = null!;
        public string? FactoryCode { get; set; }
        public string Address { get; set; } = null!;
        public bool IsActive { get; set; }
        public DateTime LastUpdate { get; set; }
        public short? Fdid { get; set; }
        public bool? IsProductWwslno { get; set; }

        public virtual ICollection<AccIncomeExpenseMaster> AccIncomeExpenseMasters { get; set; }
        public virtual ICollection<DmsFactoryChallanDetialsWithBarcode> DmsFactoryChallanDetialsWithBarcodes { get; set; }
        public virtual ICollection<DmsFactoryReceive> DmsFactoryReceives { get; set; }
        public virtual ICollection<DmsFactoryStock> DmsFactoryStocks { get; set; }
        public virtual ICollection<DmsNapkinFactoryStock> DmsNapkinFactoryStocks { get; set; }
        public virtual ICollection<FacFacToFacItemDistribution> FacFacToFacItemDistributionFromFactories { get; set; }
        public virtual ICollection<FacFacToFacItemDistribution> FacFacToFacItemDistributionToFactories { get; set; }
        public virtual ICollection<FacFacToFacItemReceive> FacFacToFacItemReceiveFromFactories { get; set; }
        public virtual ICollection<FacFacToFacItemReceive> FacFacToFacItemReceiveToFactories { get; set; }
        public virtual ICollection<FacFactoryItemStock> FacFactoryItemStocks { get; set; }
        public virtual ICollection<FacJarTamakFactoryItemStock> FacJarTamakFactoryItemStocks { get; set; }
        public virtual ICollection<FacJarTobaccoIssueToChatal> FacJarTobaccoIssueToChatals { get; set; }
        public virtual ICollection<FacJarTobaccoReceiveFromChatal> FacJarTobaccoReceiveFromChatals { get; set; }
        public virtual ICollection<FacWorkerWage> FacWorkerWages { get; set; }
        public virtual ICollection<HrmFactoryWorker> HrmFactoryWorkers { get; set; }
        public virtual ICollection<HrmPiemployement> HrmPiemployements { get; set; }
        public virtual ICollection<HrmPitransfer> HrmPitransfers { get; set; }
    }
}
