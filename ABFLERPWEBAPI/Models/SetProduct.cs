using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ABFLERPWEBAPI.Models
{
    public partial class SetProduct
    {
        public SetProduct()
        {
            DmsAreaChallanItemForPoints = new HashSet<DmsAreaChallanItemForPoint>();
            DmsAreaDeliveryChallanItems = new HashSet<DmsAreaDeliveryChallanItem>();
            DmsAreaReceivedItems = new HashSet<DmsAreaReceivedItem>();
            DmsAreaReturnDetails = new HashSet<DmsAreaReturnDetail>();
            DmsAreaStocks = new HashSet<DmsAreaStock>();
            DmsBpacketPromotions = new HashSet<DmsBpacketPromotion>();
            DmsDellarChallanItems = new HashSet<DmsDellarChallanItem>();
            DmsDellarOrderDetails = new HashSet<DmsDellarOrderDetail>();
            DmsDepoDellarChallanItems = new HashSet<DmsDepoDellarChallanItem>();
            DmsDepoRequisitionItems = new HashSet<DmsDepoRequisitionItem>();
            DmsDepoReturnDetails = new HashSet<DmsDepoReturnDetail>();
            DmsDepoStocks = new HashSet<DmsDepoStock>();
            DmsDepoToDepoRequisitionItems = new HashSet<DmsDepoToDepoRequisitionItem>();
            DmsFactoryStocks = new HashSet<DmsFactoryStock>();
            DmsIncentiveDetails = new HashSet<DmsIncentiveDetail>();
            DmsOrderDetails = new HashSet<DmsOrderDetail>();
            DmsRegionWiseActualSales = new HashSet<DmsRegionWiseActualSale>();
            DmsRequisitionItems = new HashSet<DmsRequisitionItem>();
            DmsSampleItems = new HashSet<DmsSampleItem>();
            DmsTargetPlanItems = new HashSet<DmsTargetPlanItem>();
            FacDailyTobaccoIssues = new HashSet<FacDailyTobaccoIssue>();
            FacDailyWorkerWages = new HashSet<FacDailyWorkerWage>();
            FacJarTobaccoIssueToChatals = new HashSet<FacJarTobaccoIssueToChatal>();
            FacWorkerWages = new HashSet<FacWorkerWage>();
            OocOutletSaleTargetPlanItems = new HashSet<OocOutletSaleTargetPlanItem>();
            SetProductPrices = new HashSet<SetProductPrice>();
            SetProductWiseIncentives = new HashSet<SetProductWiseIncentive>();
        }

        public short ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public string? Description { get; set; }
        public byte ProductCategory { get; set; }
        public byte Sticks { get; set; }
        public string? ShortName { get; set; }
        public bool IsActive { get; set; }
        public DateTime LastUpdate { get; set; }
        public short? ProductTypeId { get; set; }
        public int? ProductSticks { get; set; }
        public int? ProductCarton { get; set; }
        public int? PateeSticks { get; set; }
        public int? TotalPatee { get; set; }
        [JsonIgnore]
        public virtual SetProductCategory ProductCategoryNavigation { get; set; } = null!;
        public virtual ICollection<DmsAreaChallanItemForPoint> DmsAreaChallanItemForPoints { get; set; }
        public virtual ICollection<DmsAreaDeliveryChallanItem> DmsAreaDeliveryChallanItems { get; set; }
        public virtual ICollection<DmsAreaReceivedItem> DmsAreaReceivedItems { get; set; }
        public virtual ICollection<DmsAreaReturnDetail> DmsAreaReturnDetails { get; set; }
        public virtual ICollection<DmsAreaStock> DmsAreaStocks { get; set; }
        public virtual ICollection<DmsBpacketPromotion> DmsBpacketPromotions { get; set; }
        public virtual ICollection<DmsDellarChallanItem> DmsDellarChallanItems { get; set; }
        public virtual ICollection<DmsDellarOrderDetail> DmsDellarOrderDetails { get; set; }
        public virtual ICollection<DmsDepoDellarChallanItem> DmsDepoDellarChallanItems { get; set; }
        public virtual ICollection<DmsDepoRequisitionItem> DmsDepoRequisitionItems { get; set; }
        public virtual ICollection<DmsDepoReturnDetail> DmsDepoReturnDetails { get; set; }
        public virtual ICollection<DmsDepoStock> DmsDepoStocks { get; set; }
        public virtual ICollection<DmsDepoToDepoRequisitionItem> DmsDepoToDepoRequisitionItems { get; set; }
        public virtual ICollection<DmsFactoryStock> DmsFactoryStocks { get; set; }
        public virtual ICollection<DmsIncentiveDetail> DmsIncentiveDetails { get; set; }
        public virtual ICollection<DmsOrderDetail> DmsOrderDetails { get; set; }
        public virtual ICollection<DmsRegionWiseActualSale> DmsRegionWiseActualSales { get; set; }
        public virtual ICollection<DmsRequisitionItem> DmsRequisitionItems { get; set; }
        public virtual ICollection<DmsSampleItem> DmsSampleItems { get; set; }
        public virtual ICollection<DmsTargetPlanItem> DmsTargetPlanItems { get; set; }
        public virtual ICollection<FacDailyTobaccoIssue> FacDailyTobaccoIssues { get; set; }
        public virtual ICollection<FacDailyWorkerWage> FacDailyWorkerWages { get; set; }
        public virtual ICollection<FacJarTobaccoIssueToChatal> FacJarTobaccoIssueToChatals { get; set; }
        public virtual ICollection<FacWorkerWage> FacWorkerWages { get; set; }
        public virtual ICollection<OocOutletSaleTargetPlanItem> OocOutletSaleTargetPlanItems { get; set; }
        public virtual ICollection<SetProductPrice> SetProductPrices { get; set; }
        public virtual ICollection<SetProductWiseIncentive> SetProductWiseIncentives { get; set; }
    }
}
