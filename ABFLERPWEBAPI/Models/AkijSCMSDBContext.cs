﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ABFLERPWEBAPI.Models
{
    public partial class AkijSCMSDBContext : DbContext
    {
        public AkijSCMSDBContext()
        {
        }

        public AkijSCMSDBContext(DbContextOptions<AkijSCMSDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccAdvance> AccAdvances { get; set; } = null!;
        public virtual DbSet<AccAdvanceBackup> AccAdvanceBackups { get; set; } = null!;
        public virtual DbSet<AccAdvanceReturn> AccAdvanceReturns { get; set; } = null!;
        public virtual DbSet<AccAdvanceType> AccAdvanceTypes { get; set; } = null!;
        public virtual DbSet<AccAreaDebit> AccAreaDebits { get; set; } = null!;
        public virtual DbSet<AccAreaLedger> AccAreaLedgers { get; set; } = null!;
        public virtual DbSet<AccBank> AccBanks { get; set; } = null!;
        public virtual DbSet<AccBankDeposit> AccBankDeposits { get; set; } = null!;
        public virtual DbSet<AccBankDepositDelete> AccBankDepositDeletes { get; set; } = null!;
        public virtual DbSet<AccBankDepositUpdateInfo> AccBankDepositUpdateInfos { get; set; } = null!;
        public virtual DbSet<AccBankWiseAmout> AccBankWiseAmouts { get; set; } = null!;
        public virtual DbSet<AccBankWiseBranch> AccBankWiseBranches { get; set; } = null!;
        public virtual DbSet<AccCashOrDepositReceive> AccCashOrDepositReceives { get; set; } = null!;
        public virtual DbSet<AccCashTransfer> AccCashTransfers { get; set; } = null!;
        public virtual DbSet<AccCashTransferDelete> AccCashTransferDeletes { get; set; } = null!;
        public virtual DbSet<AccCashTransferUpdateInfo> AccCashTransferUpdateInfos { get; set; } = null!;
        public virtual DbSet<AccClosingBalance> AccClosingBalances { get; set; } = null!;
        public virtual DbSet<AccDailyAccountDataDelete> AccDailyAccountDataDeletes { get; set; } = null!;
        public virtual DbSet<AccDailyAccountDatum> AccDailyAccountData { get; set; } = null!;
        public virtual DbSet<AccDailyClosingBalance> AccDailyClosingBalances { get; set; } = null!;
        public virtual DbSet<AccDailyExpenseUpdateInfo> AccDailyExpenseUpdateInfos { get; set; } = null!;
        public virtual DbSet<AccDepoCredit> AccDepoCredits { get; set; } = null!;
        public virtual DbSet<AccDepoDebit> AccDepoDebits { get; set; } = null!;
        public virtual DbSet<AccDepoLedger> AccDepoLedgers { get; set; } = null!;
        public virtual DbSet<AccDepoWiseBankAccount> AccDepoWiseBankAccounts { get; set; } = null!;
        public virtual DbSet<AccHeader> AccHeaders { get; set; } = null!;
        public virtual DbSet<AccHoCredit> AccHoCredits { get; set; } = null!;
        public virtual DbSet<AccHoDebit> AccHoDebits { get; set; } = null!;
        public virtual DbSet<AccHoLedger> AccHoLedgers { get; set; } = null!;
        public virtual DbSet<AccHouseRentInfo> AccHouseRentInfos { get; set; } = null!;
        public virtual DbSet<AccHouseRentMonthly> AccHouseRentMonthlies { get; set; } = null!;
        public virtual DbSet<AccIncomExpenseMaster> AccIncomExpenseMasters { get; set; } = null!;
        public virtual DbSet<AccIncomeExpense> AccIncomeExpenses { get; set; } = null!;
        public virtual DbSet<AccIncomeExpenseDelete> AccIncomeExpenseDeletes { get; set; } = null!;
        public virtual DbSet<AccIncomeExpenseDetail> AccIncomeExpenseDetails { get; set; } = null!;
        public virtual DbSet<AccIncomeExpenseDetailBackup> AccIncomeExpenseDetailBackups { get; set; } = null!;
        public virtual DbSet<AccIncomeExpenseDetailDelete> AccIncomeExpenseDetailDeletes { get; set; } = null!;
        public virtual DbSet<AccIncomeExpenseMaster> AccIncomeExpenseMasters { get; set; } = null!;
        public virtual DbSet<AccIncomeExpenseMasterDelete> AccIncomeExpenseMasterDeletes { get; set; } = null!;
        public virtual DbSet<AccIncomeExpenseMasterModify> AccIncomeExpenseMasterModifies { get; set; } = null!;
        public virtual DbSet<AccOpeningBalance> AccOpeningBalances { get; set; } = null!;
        public virtual DbSet<AccOthersIncome> AccOthersIncomes { get; set; } = null!;
        public virtual DbSet<AccPupose> AccPuposes { get; set; } = null!;
        public virtual DbSet<AccTransactionType> AccTransactionTypes { get; set; } = null!;
        public virtual DbSet<AccVoucerDetail> AccVoucerDetails { get; set; } = null!;
        public virtual DbSet<AppsLoginInfo> AppsLoginInfos { get; set; } = null!;
        public virtual DbSet<AreaDepotCopyTable> AreaDepotCopyTables { get; set; } = null!;
        public virtual DbSet<CrSampleRandView> CrSampleRandViews { get; set; } = null!;
        public virtual DbSet<DailyGpsgradeReport> DailyGpsgradeReports { get; set; } = null!;
        public virtual DbSet<DeleteOrderDetail> DeleteOrderDetails { get; set; } = null!;
        public virtual DbSet<DmsAreaChallanAgainstAreaRequest> DmsAreaChallanAgainstAreaRequests { get; set; } = null!;
        public virtual DbSet<DmsAreaChallanForPoint> DmsAreaChallanForPoints { get; set; } = null!;
        public virtual DbSet<DmsAreaChallanForPointDelete> DmsAreaChallanForPointDeletes { get; set; } = null!;
        public virtual DbSet<DmsAreaChallanItemForPoint> DmsAreaChallanItemForPoints { get; set; } = null!;
        public virtual DbSet<DmsAreaChallanItemForPointDelete> DmsAreaChallanItemForPointDeletes { get; set; } = null!;
        public virtual DbSet<DmsAreaChallanToAreaRequestDetail> DmsAreaChallanToAreaRequestDetails { get; set; } = null!;
        public virtual DbSet<DmsAreaChallanWisePayment> DmsAreaChallanWisePayments { get; set; } = null!;
        public virtual DbSet<DmsAreaDeliveryChallan> DmsAreaDeliveryChallans { get; set; } = null!;
        public virtual DbSet<DmsAreaDeliveryChallanArchive> DmsAreaDeliveryChallanArchives { get; set; } = null!;
        public virtual DbSet<DmsAreaDeliveryChallanItem> DmsAreaDeliveryChallanItems { get; set; } = null!;
        public virtual DbSet<DmsAreaDeliveryChallanItemArchive> DmsAreaDeliveryChallanItemArchives { get; set; } = null!;
        public virtual DbSet<DmsAreaDeliveryChallanMoney> DmsAreaDeliveryChallanMoneys { get; set; } = null!;
        public virtual DbSet<DmsAreaDeliveryChallanOthersInfo> DmsAreaDeliveryChallanOthersInfos { get; set; } = null!;
        public virtual DbSet<DmsAreaOpeningStock> DmsAreaOpeningStocks { get; set; } = null!;
        public virtual DbSet<DmsAreaReceived> DmsAreaReceiveds { get; set; } = null!;
        public virtual DbSet<DmsAreaReceivedItem> DmsAreaReceivedItems { get; set; } = null!;
        public virtual DbSet<DmsAreaRecvFromArea> DmsAreaRecvFromAreas { get; set; } = null!;
        public virtual DbSet<DmsAreaRecvFromAreaDetail> DmsAreaRecvFromAreaDetails { get; set; } = null!;
        public virtual DbSet<DmsAreaRequisitionToRegion> DmsAreaRequisitionToRegions { get; set; } = null!;
        public virtual DbSet<DmsAreaReturn> DmsAreaReturns { get; set; } = null!;
        public virtual DbSet<DmsAreaReturnDetail> DmsAreaReturnDetails { get; set; } = null!;
        public virtual DbSet<DmsAreaReturnReceive> DmsAreaReturnReceives { get; set; } = null!;
        public virtual DbSet<DmsAreaReturnReceiveDetail> DmsAreaReturnReceiveDetails { get; set; } = null!;
        public virtual DbSet<DmsAreaStock> DmsAreaStocks { get; set; } = null!;
        public virtual DbSet<DmsAreaStockZeroBakup> DmsAreaStockZeroBakups { get; set; } = null!;
        public virtual DbSet<DmsBpacketDetail> DmsBpacketDetails { get; set; } = null!;
        public virtual DbSet<DmsBpacketDetailBack> DmsBpacketDetailBacks { get; set; } = null!;
        public virtual DbSet<DmsBpacketMaster> DmsBpacketMasters { get; set; } = null!;
        public virtual DbSet<DmsBpacketPromotion> DmsBpacketPromotions { get; set; } = null!;
        public virtual DbSet<DmsBpacketStock> DmsBpacketStocks { get; set; } = null!;
        public virtual DbSet<DmsCompititorsBrand> DmsCompititorsBrands { get; set; } = null!;
        public virtual DbSet<DmsCompititorsBrandAvgSale> DmsCompititorsBrandAvgSales { get; set; } = null!;
        public virtual DbSet<DmsDailyAreaClosingStock> DmsDailyAreaClosingStocks { get; set; } = null!;
        public virtual DbSet<DmsDailyOrder> DmsDailyOrders { get; set; } = null!;
        public virtual DbSet<DmsDailyOrderBak> DmsDailyOrderBaks { get; set; } = null!;
        public virtual DbSet<DmsDailyOrderDelete> DmsDailyOrderDeletes { get; set; } = null!;
        public virtual DbSet<DmsDailyOrderDetail> DmsDailyOrderDetails { get; set; } = null!;
        public virtual DbSet<DmsDailyOrderDetailBak> DmsDailyOrderDetailBaks { get; set; } = null!;
        public virtual DbSet<DmsDailyOrderDetailDelete> DmsDailyOrderDetailDeletes { get; set; } = null!;
        public virtual DbSet<DmsDailySurvey> DmsDailySurveys { get; set; } = null!;
        public virtual DbSet<DmsDamageDetail> DmsDamageDetails { get; set; } = null!;
        public virtual DbSet<DmsDamageMaster> DmsDamageMasters { get; set; } = null!;
        public virtual DbSet<DmsDamageReceiveFromDepoDellar> DmsDamageReceiveFromDepoDellars { get; set; } = null!;
        public virtual DbSet<DmsDamageReceiveFromDepoDellarDetail> DmsDamageReceiveFromDepoDellarDetails { get; set; } = null!;
        public virtual DbSet<DmsDamageReceivedFromArea> DmsDamageReceivedFromAreas { get; set; } = null!;
        public virtual DbSet<DmsDamageReceivedFromDepo> DmsDamageReceivedFromDepos { get; set; } = null!;
        public virtual DbSet<DmsDamageReceivedItemFromArea> DmsDamageReceivedItemFromAreas { get; set; } = null!;
        public virtual DbSet<DmsDamageReceivedItemFromDepo> DmsDamageReceivedItemFromDepos { get; set; } = null!;
        public virtual DbSet<DmsDamageReturnToDepo> DmsDamageReturnToDepos { get; set; } = null!;
        public virtual DbSet<DmsDamageReturnToDepoDetail> DmsDamageReturnToDepoDetails { get; set; } = null!;
        public virtual DbSet<DmsDamageReturnToFactory> DmsDamageReturnToFactories { get; set; } = null!;
        public virtual DbSet<DmsDamageReturnToFactoryDetail> DmsDamageReturnToFactoryDetails { get; set; } = null!;
        public virtual DbSet<DmsDeliveryLocationOfDeliveryMan> DmsDeliveryLocationOfDeliveryMen { get; set; } = null!;
        public virtual DbSet<DmsDellarChallan> DmsDellarChallans { get; set; } = null!;
        public virtual DbSet<DmsDellarChallanItem> DmsDellarChallanItems { get; set; } = null!;
        public virtual DbSet<DmsDellarOrder> DmsDellarOrders { get; set; } = null!;
        public virtual DbSet<DmsDellarOrderDetail> DmsDellarOrderDetails { get; set; } = null!;
        public virtual DbSet<DmsDellarPromotion> DmsDellarPromotions { get; set; } = null!;
        public virtual DbSet<DmsDepoChallan> DmsDepoChallans { get; set; } = null!;
        public virtual DbSet<DmsDepoChallanItem> DmsDepoChallanItems { get; set; } = null!;
        public virtual DbSet<DmsDepoChallanItemBarcode> DmsDepoChallanItemBarcodes { get; set; } = null!;
        public virtual DbSet<DmsDepoChallanItemWithBarcode> DmsDepoChallanItemWithBarcodes { get; set; } = null!;
        public virtual DbSet<DmsDepoDellarChallan> DmsDepoDellarChallans { get; set; } = null!;
        public virtual DbSet<DmsDepoDellarChallanItem> DmsDepoDellarChallanItems { get; set; } = null!;
        public virtual DbSet<DmsDepoDellarChallanItemToDamage> DmsDepoDellarChallanItemToDamages { get; set; } = null!;
        public virtual DbSet<DmsDepoDellarChallanToDamage> DmsDepoDellarChallanToDamages { get; set; } = null!;
        public virtual DbSet<DmsDepoOpeningStock> DmsDepoOpeningStocks { get; set; } = null!;
        public virtual DbSet<DmsDepoRequisition> DmsDepoRequisitions { get; set; } = null!;
        public virtual DbSet<DmsDepoRequisitionItem> DmsDepoRequisitionItems { get; set; } = null!;
        public virtual DbSet<DmsDepoReturn> DmsDepoReturns { get; set; } = null!;
        public virtual DbSet<DmsDepoReturnDetail> DmsDepoReturnDetails { get; set; } = null!;
        public virtual DbSet<DmsDepoReturnReceive> DmsDepoReturnReceives { get; set; } = null!;
        public virtual DbSet<DmsDepoReturnReceiveDetail> DmsDepoReturnReceiveDetails { get; set; } = null!;
        public virtual DbSet<DmsDepoStock> DmsDepoStocks { get; set; } = null!;
        public virtual DbSet<DmsDepoStockZeroBakup> DmsDepoStockZeroBakups { get; set; } = null!;
        public virtual DbSet<DmsDepoToDepoChallan> DmsDepoToDepoChallans { get; set; } = null!;
        public virtual DbSet<DmsDepoToDepoChallanItem> DmsDepoToDepoChallanItems { get; set; } = null!;
        public virtual DbSet<DmsDepoToDepoRequisition> DmsDepoToDepoRequisitions { get; set; } = null!;
        public virtual DbSet<DmsDepoToDepoRequisitionItem> DmsDepoToDepoRequisitionItems { get; set; } = null!;
        public virtual DbSet<DmsDmreceivedFromDepo> DmsDmreceivedFromDepos { get; set; } = null!;
        public virtual DbSet<DmsDmreceivedItemFromDepo> DmsDmreceivedItemFromDepos { get; set; } = null!;
        public virtual DbSet<DmsDmreceivedItemFromFactory> DmsDmreceivedItemFromFactories { get; set; } = null!;
        public virtual DbSet<DmsDmreceivedItemFromFactoryWithBarcode> DmsDmreceivedItemFromFactoryWithBarcodes { get; set; } = null!;
        public virtual DbSet<DmsDmrecevedFromFactory> DmsDmrecevedFromFactories { get; set; } = null!;
        public virtual DbSet<DmsFactoryChallan> DmsFactoryChallans { get; set; } = null!;
        public virtual DbSet<DmsFactoryChallanBarcodeTemp> DmsFactoryChallanBarcodeTemps { get; set; } = null!;
        public virtual DbSet<DmsFactoryChallanDetail> DmsFactoryChallanDetails { get; set; } = null!;
        public virtual DbSet<DmsFactoryChallanDetialsWithBarcode> DmsFactoryChallanDetialsWithBarcodes { get; set; } = null!;
        public virtual DbSet<DmsFactoryOpeningStock> DmsFactoryOpeningStocks { get; set; } = null!;
        public virtual DbSet<DmsFactoryProductionAllocation> DmsFactoryProductionAllocations { get; set; } = null!;
        public virtual DbSet<DmsFactoryProductionBarcode> DmsFactoryProductionBarcodes { get; set; } = null!;
        public virtual DbSet<DmsFactoryProductionBarcode2022> DmsFactoryProductionBarcode2022s { get; set; } = null!;
        public virtual DbSet<DmsFactoryProductionBarcode2023> DmsFactoryProductionBarcode2023s { get; set; } = null!;
        public virtual DbSet<DmsFactoryReceive> DmsFactoryReceives { get; set; } = null!;
        public virtual DbSet<DmsFactoryReceiveDetialsWithBarcode> DmsFactoryReceiveDetialsWithBarcodes { get; set; } = null!;
        public virtual DbSet<DmsFactoryStock> DmsFactoryStocks { get; set; } = null!;
        public virtual DbSet<DmsImageCapture> DmsImageCaptures { get; set; } = null!;
        public virtual DbSet<DmsImageCaptureType> DmsImageCaptureTypes { get; set; } = null!;
        public virtual DbSet<DmsIncentiveDetail> DmsIncentiveDetails { get; set; } = null!;
        public virtual DbSet<DmsIncentiveMaster> DmsIncentiveMasters { get; set; } = null!;
        public virtual DbSet<DmsIncentivePointValue> DmsIncentivePointValues { get; set; } = null!;
        public virtual DbSet<DmsMemoType> DmsMemoTypes { get; set; } = null!;
        public virtual DbSet<DmsMixerProductionBarcode> DmsMixerProductionBarcodes { get; set; } = null!;
        public virtual DbSet<DmsNapkinAreaOpeningStock> DmsNapkinAreaOpeningStocks { get; set; } = null!;
        public virtual DbSet<DmsNapkinAreaReceived> DmsNapkinAreaReceiveds { get; set; } = null!;
        public virtual DbSet<DmsNapkinAreaReceivedItem> DmsNapkinAreaReceivedItems { get; set; } = null!;
        public virtual DbSet<DmsNapkinAreaReturn> DmsNapkinAreaReturns { get; set; } = null!;
        public virtual DbSet<DmsNapkinAreaReturnDetail> DmsNapkinAreaReturnDetails { get; set; } = null!;
        public virtual DbSet<DmsNapkinAreaReturnReceive> DmsNapkinAreaReturnReceives { get; set; } = null!;
        public virtual DbSet<DmsNapkinAreaReturnReceiveDetail> DmsNapkinAreaReturnReceiveDetails { get; set; } = null!;
        public virtual DbSet<DmsNapkinAreaStock> DmsNapkinAreaStocks { get; set; } = null!;
        public virtual DbSet<DmsNapkinAreaStockUpdateProDatum> DmsNapkinAreaStockUpdateProData { get; set; } = null!;
        public virtual DbSet<DmsNapkinAreaStockUpdateSalesDatum> DmsNapkinAreaStockUpdateSalesData { get; set; } = null!;
        public virtual DbSet<DmsNapkinDepoChallan> DmsNapkinDepoChallans { get; set; } = null!;
        public virtual DbSet<DmsNapkinDepoChallanItem> DmsNapkinDepoChallanItems { get; set; } = null!;
        public virtual DbSet<DmsNapkinDepoOpeningStock> DmsNapkinDepoOpeningStocks { get; set; } = null!;
        public virtual DbSet<DmsNapkinDepoStock> DmsNapkinDepoStocks { get; set; } = null!;
        public virtual DbSet<DmsNapkinDepoToDepoTransfer> DmsNapkinDepoToDepoTransfers { get; set; } = null!;
        public virtual DbSet<DmsNapkinDepoToDepoTransferDetail> DmsNapkinDepoToDepoTransferDetails { get; set; } = null!;
        public virtual DbSet<DmsNapkinDepoToDepoTransferReceive> DmsNapkinDepoToDepoTransferReceives { get; set; } = null!;
        public virtual DbSet<DmsNapkinDepoToDepoTransferReceiveDetail> DmsNapkinDepoToDepoTransferReceiveDetails { get; set; } = null!;
        public virtual DbSet<DmsNapkinDmreceivedItemFromFactory> DmsNapkinDmreceivedItemFromFactories { get; set; } = null!;
        public virtual DbSet<DmsNapkinDmrecevedFromFactory> DmsNapkinDmrecevedFromFactories { get; set; } = null!;
        public virtual DbSet<DmsNapkinFactoryChallan> DmsNapkinFactoryChallans { get; set; } = null!;
        public virtual DbSet<DmsNapkinFactoryChallanDetail> DmsNapkinFactoryChallanDetails { get; set; } = null!;
        public virtual DbSet<DmsNapkinFactoryOpeningStock> DmsNapkinFactoryOpeningStocks { get; set; } = null!;
        public virtual DbSet<DmsNapkinFactoryProductionAllocation> DmsNapkinFactoryProductionAllocations { get; set; } = null!;
        public virtual DbSet<DmsNapkinFactoryReceive> DmsNapkinFactoryReceives { get; set; } = null!;
        public virtual DbSet<DmsNapkinFactoryStock> DmsNapkinFactoryStocks { get; set; } = null!;
        public virtual DbSet<DmsNapkinReturnType> DmsNapkinReturnTypes { get; set; } = null!;
        public virtual DbSet<DmsOrder> DmsOrders { get; set; } = null!;
        public virtual DbSet<DmsOrderDelete> DmsOrderDeletes { get; set; } = null!;
        public virtual DbSet<DmsOrderDetail> DmsOrderDetails { get; set; } = null!;
        public virtual DbSet<DmsOrderDetailArchive> DmsOrderDetailArchives { get; set; } = null!;
        public virtual DbSet<DmsOrderDetailDelete> DmsOrderDetailDeletes { get; set; } = null!;
        public virtual DbSet<DmsOrderDetailForPoint> DmsOrderDetailForPoints { get; set; } = null!;
        public virtual DbSet<DmsOrderDetailForPointDelete> DmsOrderDetailForPointDeletes { get; set; } = null!;
        public virtual DbSet<DmsOrdersArchive> DmsOrdersArchives { get; set; } = null!;
        public virtual DbSet<DmsOrdersDelete> DmsOrdersDeletes { get; set; } = null!;
        public virtual DbSet<DmsOrdersForPoint> DmsOrdersForPoints { get; set; } = null!;
        public virtual DbSet<DmsOrdersForPointDelete> DmsOrdersForPointDeletes { get; set; } = null!;
        public virtual DbSet<DmsOutletWiseHighBaseSale> DmsOutletWiseHighBaseSales { get; set; } = null!;
        public virtual DbSet<DmsOutletWiseLatlong> DmsOutletWiseLatlongs { get; set; } = null!;
        public virtual DbSet<DmsOutletWiseLatlongDeleted> DmsOutletWiseLatlongDeleteds { get; set; } = null!;
        public virtual DbSet<DmsProductWiseMposalesTarget> DmsProductWiseMposalesTargets { get; set; } = null!;
        public virtual DbSet<DmsProductWiseMposalesTargetRawDatum> DmsProductWiseMposalesTargetRawData { get; set; } = null!;
        public virtual DbSet<DmsRegionActualSalesMaster> DmsRegionActualSalesMasters { get; set; } = null!;
        public virtual DbSet<DmsRegionAllocatedItem> DmsRegionAllocatedItems { get; set; } = null!;
        public virtual DbSet<DmsRegionAllocatedTarget> DmsRegionAllocatedTargets { get; set; } = null!;
        public virtual DbSet<DmsRegionSrwiseNapkinSalesTarget> DmsRegionSrwiseNapkinSalesTargets { get; set; } = null!;
        public virtual DbSet<DmsRegionWiseActualSale> DmsRegionWiseActualSales { get; set; } = null!;
        public virtual DbSet<DmsReportAreaChallan> DmsReportAreaChallans { get; set; } = null!;
        public virtual DbSet<DmsReportAreaChallanItem> DmsReportAreaChallanItems { get; set; } = null!;
        public virtual DbSet<DmsRequisionIndentation> DmsRequisionIndentations { get; set; } = null!;
        public virtual DbSet<DmsRequisition> DmsRequisitions { get; set; } = null!;
        public virtual DbSet<DmsRequisitionIndentationDetail> DmsRequisitionIndentationDetails { get; set; } = null!;
        public virtual DbSet<DmsRequisitionItem> DmsRequisitionItems { get; set; } = null!;
        public virtual DbSet<DmsRequisitionToRegionApproveAndAssign> DmsRequisitionToRegionApproveAndAssigns { get; set; } = null!;
        public virtual DbSet<DmsRequisitionToRegionApproveAndAssignDetail> DmsRequisitionToRegionApproveAndAssignDetails { get; set; } = null!;
        public virtual DbSet<DmsRequisitionToRegionDetail> DmsRequisitionToRegionDetails { get; set; } = null!;
        public virtual DbSet<DmsReturnDetail> DmsReturnDetails { get; set; } = null!;
        public virtual DbSet<DmsRoutePlan> DmsRoutePlans { get; set; } = null!;
        public virtual DbSet<DmsRouteWiseHighLowBase> DmsRouteWiseHighLowBases { get; set; } = null!;
        public virtual DbSet<DmsSample> DmsSamples { get; set; } = null!;
        public virtual DbSet<DmsSampleItem> DmsSampleItems { get; set; } = null!;
        public virtual DbSet<DmsSampleItemSmoker> DmsSampleItemSmokers { get; set; } = null!;
        public virtual DbSet<DmsSetFactoryProductionTarget> DmsSetFactoryProductionTargets { get; set; } = null!;
        public virtual DbSet<DmsSrandRouteWiseNapkinSalesTarget> DmsSrandRouteWiseNapkinSalesTargets { get; set; } = null!;
        public virtual DbSet<DmsSrandRouteWiseSalesTarget> DmsSrandRouteWiseSalesTargets { get; set; } = null!;
        public virtual DbSet<DmsSrprojectInfo> DmsSrprojectInfos { get; set; } = null!;
        public virtual DbSet<DmsSrprojectParameter> DmsSrprojectParameters { get; set; } = null!;
        public virtual DbSet<DmsSrwiseDailyActivitiesBackup> DmsSrwiseDailyActivitiesBackups { get; set; } = null!;
        public virtual DbSet<DmsSrwiseDailyActivitiesDel> DmsSrwiseDailyActivitiesDels { get; set; } = null!;
        public virtual DbSet<DmsSrwiseDailyActivitiesItem> DmsSrwiseDailyActivitiesItems { get; set; } = null!;
        public virtual DbSet<DmsSrwiseDailyActivity> DmsSrwiseDailyActivities { get; set; } = null!;
        public virtual DbSet<DmsSrwiseMatchSale> DmsSrwiseMatchSales { get; set; } = null!;
        public virtual DbSet<DmsSrwiseNapkinPromotion> DmsSrwiseNapkinPromotions { get; set; } = null!;
        public virtual DbSet<DmsSrwiseNapkinPromotionUpdateDatum> DmsSrwiseNapkinPromotionUpdateData { get; set; } = null!;
        public virtual DbSet<DmsSrwiseNapkinSale> DmsSrwiseNapkinSales { get; set; } = null!;
        public virtual DbSet<DmsSrwiseNapkinSalesUpdateDatum> DmsSrwiseNapkinSalesUpdateData { get; set; } = null!;
        public virtual DbSet<DmsSrwiseTarget> DmsSrwiseTargets { get; set; } = null!;
        public virtual DbSet<DmsSrwiseTargetDel> DmsSrwiseTargetDels { get; set; } = null!;
        public virtual DbSet<DmsTargetPlan> DmsTargetPlans { get; set; } = null!;
        public virtual DbSet<DmsTargetPlanItem> DmsTargetPlanItems { get; set; } = null!;
        public virtual DbSet<FacBandRollCounting> FacBandRollCountings { get; set; } = null!;
        public virtual DbSet<FacBandRollReceivedInfo> FacBandRollReceivedInfos { get; set; } = null!;
        public virtual DbSet<FacDailyItemDisToWorker> FacDailyItemDisToWorkers { get; set; } = null!;
        public virtual DbSet<FacDailyItemDisToWorkerDetail> FacDailyItemDisToWorkerDetails { get; set; } = null!;
        public virtual DbSet<FacDailyToabaccoUse> FacDailyToabaccoUses { get; set; } = null!;
        public virtual DbSet<FacDailyTobaccoIssue> FacDailyTobaccoIssues { get; set; } = null!;
        public virtual DbSet<FacDailyWorkerWage> FacDailyWorkerWages { get; set; } = null!;
        public virtual DbSet<FacFacToFacItemDistribution> FacFacToFacItemDistributions { get; set; } = null!;
        public virtual DbSet<FacFacToFacItemDistributionDetail> FacFacToFacItemDistributionDetails { get; set; } = null!;
        public virtual DbSet<FacFacToFacItemReceive> FacFacToFacItemReceives { get; set; } = null!;
        public virtual DbSet<FacFacToFacItemReceiveDetail> FacFacToFacItemReceiveDetails { get; set; } = null!;
        public virtual DbSet<FacFactoryItemStock> FacFactoryItemStocks { get; set; } = null!;
        public virtual DbSet<FacItemInfo> FacItemInfos { get; set; } = null!;
        public virtual DbSet<FacItemPackSize> FacItemPackSizes { get; set; } = null!;
        public virtual DbSet<FacItemType> FacItemTypes { get; set; } = null!;
        public virtual DbSet<FacItemUnit> FacItemUnits { get; set; } = null!;
        public virtual DbSet<FacItemUnitWisePackSize> FacItemUnitWisePackSizes { get; set; } = null!;
        public virtual DbSet<FacJarTamakFactoryItemStock> FacJarTamakFactoryItemStocks { get; set; } = null!;
        public virtual DbSet<FacJarTobaccoIssueToChatal> FacJarTobaccoIssueToChatals { get; set; } = null!;
        public virtual DbSet<FacJarTobaccoReceiveFromChatal> FacJarTobaccoReceiveFromChatals { get; set; } = null!;
        public virtual DbSet<FacProductionReceiveFromWorker> FacProductionReceiveFromWorkers { get; set; } = null!;
        public virtual DbSet<FacProductionReceiveFromWorkerDetial> FacProductionReceiveFromWorkerDetials { get; set; } = null!;
        public virtual DbSet<FacReceiveItemFromHo> FacReceiveItemFromHos { get; set; } = null!;
        public virtual DbSet<FacReceiveItemFromHodetail> FacReceiveItemFromHodetails { get; set; } = null!;
        public virtual DbSet<FacTobaccoIssueType> FacTobaccoIssueTypes { get; set; } = null!;
        public virtual DbSet<FacWorkerCanteenBill> FacWorkerCanteenBills { get; set; } = null!;
        public virtual DbSet<FacWorkerWage> FacWorkerWages { get; set; } = null!;
        public virtual DbSet<FtAggreementType> FtAggreementTypes { get; set; } = null!;
        public virtual DbSet<FtApprovalStatus> FtApprovalStatuses { get; set; } = null!;
        public virtual DbSet<FtAttendanceStatus> FtAttendanceStatuses { get; set; } = null!;
        public virtual DbSet<FtBloodGroup> FtBloodGroups { get; set; } = null!;
        public virtual DbSet<FtChoiceType> FtChoiceTypes { get; set; } = null!;
        public virtual DbSet<FtEmployeeStatus> FtEmployeeStatuses { get; set; } = null!;
        public virtual DbSet<FtGender> FtGenders { get; set; } = null!;
        public virtual DbSet<FtHrleaveType> FtHrleaveTypes { get; set; } = null!;
        public virtual DbSet<FtMeritalStatus> FtMeritalStatuses { get; set; } = null!;
        public virtual DbSet<FtOutletOther> FtOutletOthers { get; set; } = null!;
        public virtual DbSet<FtReligion> FtReligions { get; set; } = null!;
        public virtual DbSet<FtShiftProfileItem> FtShiftProfileItems { get; set; } = null!;
        public virtual DbSet<FtTerminationType> FtTerminationTypes { get; set; } = null!;
        public virtual DbSet<FtTerritoryType> FtTerritoryTypes { get; set; } = null!;
        public virtual DbSet<FtWorkingDay> FtWorkingDays { get; set; } = null!;
        public virtual DbSet<Gpstracking> Gpstrackings { get; set; } = null!;
        public virtual DbSet<GpstrackingArchive> GpstrackingArchives { get; set; } = null!;
        public virtual DbSet<GpstrackingOrder> GpstrackingOrders { get; set; } = null!;
        public virtual DbSet<GpstrackingRaw> GpstrackingRaws { get; set; } = null!;
        public virtual DbSet<GpstrackingTemp> GpstrackingTemps { get; set; } = null!;
        public virtual DbSet<HrLeaveBalanceLeave> HrLeaveBalanceLeaves { get; set; } = null!;
        public virtual DbSet<HrLeaveCancelApplication> HrLeaveCancelApplications { get; set; } = null!;
        public virtual DbSet<HrmAdvanceApplication> HrmAdvanceApplications { get; set; } = null!;
        public virtual DbSet<HrmAdvanceApproval> HrmAdvanceApprovals { get; set; } = null!;
        public virtual DbSet<HrmAdvanceRepay> HrmAdvanceRepays { get; set; } = null!;
        public virtual DbSet<HrmAssignEmployeeShiftPattern> HrmAssignEmployeeShiftPatterns { get; set; } = null!;
        public virtual DbSet<HrmAttendance> HrmAttendances { get; set; } = null!;
        public virtual DbSet<HrmAttendanceArchive> HrmAttendanceArchives { get; set; } = null!;
        public virtual DbSet<HrmAttendanceDevice> HrmAttendanceDevices { get; set; } = null!;
        public virtual DbSet<HrmCarInfo> HrmCarInfos { get; set; } = null!;
        public virtual DbSet<HrmDeviceInOut> HrmDeviceInOuts { get; set; } = null!;
        public virtual DbSet<HrmDeviceInOutArchive> HrmDeviceInOutArchives { get; set; } = null!;
        public virtual DbSet<HrmEmployeeSalaryInfo> HrmEmployeeSalaryInfos { get; set; } = null!;
        public virtual DbSet<HrmEmployeeShiftPattern> HrmEmployeeShiftPatterns { get; set; } = null!;
        public virtual DbSet<HrmEmployeeShiftPatternDetail> HrmEmployeeShiftPatternDetails { get; set; } = null!;
        public virtual DbSet<HrmEmployeeTransfer> HrmEmployeeTransfers { get; set; } = null!;
        public virtual DbSet<HrmEmployeeWiseImage> HrmEmployeeWiseImages { get; set; } = null!;
        public virtual DbSet<HrmEtchoicePlace> HrmEtchoicePlaces { get; set; } = null!;
        public virtual DbSet<HrmEtpreviousWorkPlace> HrmEtpreviousWorkPlaces { get; set; } = null!;
        public virtual DbSet<HrmFactoryWorker> HrmFactoryWorkers { get; set; } = null!;
        public virtual DbSet<HrmFactoryWorkerBackup> HrmFactoryWorkerBackups { get; set; } = null!;
        public virtual DbSet<HrmHoliday> HrmHolidays { get; set; } = null!;
        public virtual DbSet<HrmLeaveAppDetail> HrmLeaveAppDetails { get; set; } = null!;
        public virtual DbSet<HrmLeaveApplication> HrmLeaveApplications { get; set; } = null!;
        public virtual DbSet<HrmLeaveApproval> HrmLeaveApprovals { get; set; } = null!;
        public virtual DbSet<HrmLoanApplication> HrmLoanApplications { get; set; } = null!;
        public virtual DbSet<HrmLoanApproval> HrmLoanApprovals { get; set; } = null!;
        public virtual DbSet<HrmLoanInstallment> HrmLoanInstallments { get; set; } = null!;
        public virtual DbSet<HrmLoanPaid> HrmLoanPaids { get; set; } = null!;
        public virtual DbSet<HrmPayRollSalaryMaster> HrmPayRollSalaryMasters { get; set; } = null!;
        public virtual DbSet<HrmPayrollSalaryDetail> HrmPayrollSalaryDetails { get; set; } = null!;
        public virtual DbSet<HrmPfaccount> HrmPfaccounts { get; set; } = null!;
        public virtual DbSet<HrmPfaccountDetail> HrmPfaccountDetails { get; set; } = null!;
        public virtual DbSet<HrmPfdddetail> HrmPfdddetails { get; set; } = null!;
        public virtual DbSet<HrmPfddinfo> HrmPfddinfos { get; set; } = null!;
        public virtual DbSet<HrmPfinstallment> HrmPfinstallments { get; set; } = null!;
        public virtual DbSet<HrmPfopeningBalance> HrmPfopeningBalances { get; set; } = null!;
        public virtual DbSet<HrmPfrule> HrmPfrules { get; set; } = null!;
        public virtual DbSet<HrmPftransaction> HrmPftransactions { get; set; } = null!;
        public virtual DbSet<HrmPi> HrmPis { get; set; } = null!;
        public virtual DbSet<HrmPiemergencyContact> HrmPiemergencyContacts { get; set; } = null!;
        public virtual DbSet<HrmPiemployement> HrmPiemployements { get; set; } = null!;
        public virtual DbSet<HrmPiemploymentDetail> HrmPiemploymentDetails { get; set; } = null!;
        public virtual DbSet<HrmPifamilyInfo> HrmPifamilyInfos { get; set; } = null!;
        public virtual DbSet<HrmPiincrement> HrmPiincrements { get; set; } = null!;
        public virtual DbSet<HrmPiincrementRawDatum> HrmPiincrementRawData { get; set; } = null!;
        public virtual DbSet<HrmPijobExperience> HrmPijobExperiences { get; set; } = null!;
        public virtual DbSet<HrmPinominee> HrmPinominees { get; set; } = null!;
        public virtual DbSet<HrmPipromotion> HrmPipromotions { get; set; } = null!;
        public virtual DbSet<HrmPipromotionRawDatum> HrmPipromotionRawData { get; set; } = null!;
        public virtual DbSet<HrmPiqualification> HrmPiqualifications { get; set; } = null!;
        public virtual DbSet<HrmPireference> HrmPireferences { get; set; } = null!;
        public virtual DbSet<HrmPitermination> HrmPiterminations { get; set; } = null!;
        public virtual DbSet<HrmPitransfer> HrmPitransfers { get; set; } = null!;
        public virtual DbSet<HrmPitransferRawDatum> HrmPitransferRawData { get; set; } = null!;
        public virtual DbSet<HrmPreviousEmployeement> HrmPreviousEmployeements { get; set; } = null!;
        public virtual DbSet<HrmShiftPattern> HrmShiftPatterns { get; set; } = null!;
        public virtual DbSet<HrmShiftPatternDetail> HrmShiftPatternDetails { get; set; } = null!;
        public virtual DbSet<HrmShiftProfile> HrmShiftProfiles { get; set; } = null!;
        public virtual DbSet<HrmShiftProfileItem> HrmShiftProfileItems { get; set; } = null!;
        public virtual DbSet<HrmTerminationApproval> HrmTerminationApprovals { get; set; } = null!;
        public virtual DbSet<HrmTourAttendance> HrmTourAttendances { get; set; } = null!;
        public virtual DbSet<HrmTourAttendanceDetail> HrmTourAttendanceDetails { get; set; } = null!;
        public virtual DbSet<HrmWorkingDay> HrmWorkingDays { get; set; } = null!;
        public virtual DbSet<Log> Logs { get; set; } = null!;
        public virtual DbSet<OocAreaVisitPlan> OocAreaVisitPlans { get; set; } = null!;
        public virtual DbSet<OocDailySmokerContact> OocDailySmokerContacts { get; set; } = null!;
        public virtual DbSet<OocOutletSaleTargetPlan> OocOutletSaleTargetPlans { get; set; } = null!;
        public virtual DbSet<OocOutletSaleTargetPlanDelDatum> OocOutletSaleTargetPlanDelData { get; set; } = null!;
        public virtual DbSet<OocOutletSaleTargetPlanItem> OocOutletSaleTargetPlanItems { get; set; } = null!;
        public virtual DbSet<OocOutletSaleTargetPlanItemDelDatum> OocOutletSaleTargetPlanItemDelData { get; set; } = null!;
        public virtual DbSet<OocOutletVisit> OocOutletVisits { get; set; } = null!;
        public virtual DbSet<OocOutletVisitPlan> OocOutletVisitPlans { get; set; } = null!;
        public virtual DbSet<OocSalesRefuseType> OocSalesRefuseTypes { get; set; } = null!;
        public virtual DbSet<OocSmokerContact> OocSmokerContacts { get; set; } = null!;
        public virtual DbSet<OocSmokerContactBak> OocSmokerContactBaks { get; set; } = null!;
        public virtual DbSet<OocSmokerContactDetail> OocSmokerContactDetails { get; set; } = null!;
        public virtual DbSet<OocVisibilityInfo> OocVisibilityInfos { get; set; } = null!;
        public virtual DbSet<OverSalesOrderDetailDel> OverSalesOrderDetailDels { get; set; } = null!;
        public virtual DbSet<OverSalesOrderDetailDelForPoint> OverSalesOrderDetailDelForPoints { get; set; } = null!;
        public virtual DbSet<PageReference> PageReferences { get; set; } = null!;
        public virtual DbSet<ReturnType> ReturnTypes { get; set; } = null!;
        public virtual DbSet<RptSoldDepotStockReport> RptSoldDepotStockReports { get; set; } = null!;
        public virtual DbSet<SecuredUser> SecuredUsers { get; set; } = null!;
        public virtual DbSet<SetArea> SetAreas { get; set; } = null!;
        public virtual DbSet<SetAreaWiseUnit> SetAreaWiseUnits { get; set; } = null!;
        public virtual DbSet<SetAttendance> SetAttendances { get; set; } = null!;
        public virtual DbSet<SetAttendanceByMobile> SetAttendanceByMobiles { get; set; } = null!;
        public virtual DbSet<SetBiriCigaretteStatus> SetBiriCigaretteStatuses { get; set; } = null!;
        public virtual DbSet<SetChallanPurpose> SetChallanPurposes { get; set; } = null!;
        public virtual DbSet<SetCluster> SetClusters { get; set; } = null!;
        public virtual DbSet<SetClusterDeatail> SetClusterDeatails { get; set; } = null!;
        public virtual DbSet<SetDailySmoker> SetDailySmokers { get; set; } = null!;
        public virtual DbSet<SetDealerSubDealerInfo> SetDealerSubDealerInfos { get; set; } = null!;
        public virtual DbSet<SetDeliveryMan> SetDeliveryMen { get; set; } = null!;
        public virtual DbSet<SetDellar> SetDellars { get; set; } = null!;
        public virtual DbSet<SetDepartment> SetDepartments { get; set; } = null!;
        public virtual DbSet<SetDepartmentWiseSection> SetDepartmentWiseSections { get; set; } = null!;
        public virtual DbSet<SetDepo> SetDepos { get; set; } = null!;
        public virtual DbSet<SetDistrict> SetDistricts { get; set; } = null!;
        public virtual DbSet<SetDivision> SetDivisions { get; set; } = null!;
        public virtual DbSet<SetDivisionDistrictUpazillaRawDatum> SetDivisionDistrictUpazillaRawData { get; set; } = null!;
        public virtual DbSet<SetDivisionWiseRegion> SetDivisionWiseRegions { get; set; } = null!;
        public virtual DbSet<SetDivsionWiseDepartment> SetDivsionWiseDepartments { get; set; } = null!;
        public virtual DbSet<SetEmployeeDevice> SetEmployeeDevices { get; set; } = null!;
        public virtual DbSet<SetEmployeeInfo> SetEmployeeInfos { get; set; } = null!;
        public virtual DbSet<SetFactory> SetFactories { get; set; } = null!;
        public virtual DbSet<SetFactoryDivision> SetFactoryDivisions { get; set; } = null!;
        public virtual DbSet<SetFactoryWiseProductionProduct> SetFactoryWiseProductionProducts { get; set; } = null!;
        public virtual DbSet<SetFactoryWorkerType> SetFactoryWorkerTypes { get; set; } = null!;
        public virtual DbSet<SetHrdesignation> SetHrdesignations { get; set; } = null!;
        public virtual DbSet<SetHremployeeCategory> SetHremployeeCategories { get; set; } = null!;
        public virtual DbSet<SetHrleaveProfile> SetHrleaveProfiles { get; set; } = null!;
        public virtual DbSet<SetHrleaveYear> SetHrleaveYears { get; set; } = null!;
        public virtual DbSet<SetHrmshiftCategory> SetHrmshiftCategories { get; set; } = null!;
        public virtual DbSet<SetHrmshiftType> SetHrmshiftTypes { get; set; } = null!;
        public virtual DbSet<SetIncentivePoint> SetIncentivePoints { get; set; } = null!;
        public virtual DbSet<SetIncentivePointMaster> SetIncentivePointMasters { get; set; } = null!;
        public virtual DbSet<SetJobPosition> SetJobPositions { get; set; } = null!;
        public virtual DbSet<SetLeaveType> SetLeaveTypes { get; set; } = null!;
        public virtual DbSet<SetLoanType> SetLoanTypes { get; set; } = null!;
        public virtual DbSet<SetLog> SetLogs { get; set; } = null!;
        public virtual DbSet<SetLogInLog> SetLogInLogs { get; set; } = null!;
        public virtual DbSet<SetLogInMacAddress> SetLogInMacAddresses { get; set; } = null!;
        public virtual DbSet<SetLogonsUser> SetLogonsUsers { get; set; } = null!;
        public virtual DbSet<SetMenuGroup> SetMenuGroups { get; set; } = null!;
        public virtual DbSet<SetModule> SetModules { get; set; } = null!;
        public virtual DbSet<SetModuleWiseSubmodule> SetModuleWiseSubmodules { get; set; } = null!;
        public virtual DbSet<SetMonthlyActiveWorkingDay> SetMonthlyActiveWorkingDays { get; set; } = null!;
        public virtual DbSet<SetMporecruitment> SetMporecruitments { get; set; } = null!;
        public virtual DbSet<SetNapkinFactory> SetNapkinFactories { get; set; } = null!;
        public virtual DbSet<SetNapkinOutlet> SetNapkinOutlets { get; set; } = null!;
        public virtual DbSet<SetNapkinOutletType> SetNapkinOutletTypes { get; set; } = null!;
        public virtual DbSet<SetNapkinProduct> SetNapkinProducts { get; set; } = null!;
        public virtual DbSet<SetNapkinProductPrice> SetNapkinProductPrices { get; set; } = null!;
        public virtual DbSet<SetNapkinPromotionType> SetNapkinPromotionTypes { get; set; } = null!;
        public virtual DbSet<SetNoteAndCoinInfo> SetNoteAndCoinInfos { get; set; } = null!;
        public virtual DbSet<SetOutetRawDatum> SetOutetRawData { get; set; } = null!;
        public virtual DbSet<SetOutlet> SetOutlets { get; set; } = null!;
        public virtual DbSet<SetOutletDetail> SetOutletDetails { get; set; } = null!;
        public virtual DbSet<SetOutletDivision> SetOutletDivisions { get; set; } = null!;
        public virtual DbSet<SetOutletNumber> SetOutletNumbers { get; set; } = null!;
        public virtual DbSet<SetPage> SetPages { get; set; } = null!;
        public virtual DbSet<SetPayGrade> SetPayGrades { get; set; } = null!;
        public virtual DbSet<SetPostOffice> SetPostOffices { get; set; } = null!;
        public virtual DbSet<SetPostWisePage> SetPostWisePages { get; set; } = null!;
        public virtual DbSet<SetProduct> SetProducts { get; set; } = null!;
        public virtual DbSet<SetProductCategory> SetProductCategories { get; set; } = null!;
        public virtual DbSet<SetProductPrice> SetProductPrices { get; set; } = null!;
        public virtual DbSet<SetProductPricePre> SetProductPricePres { get; set; } = null!;
        public virtual DbSet<SetProductPricePreviouse> SetProductPricePreviouses { get; set; } = null!;
        public virtual DbSet<SetProductType> SetProductTypes { get; set; } = null!;
        public virtual DbSet<SetProductWiseIncentive> SetProductWiseIncentives { get; set; } = null!;
        public virtual DbSet<SetReUpdateOutletBcstatus> SetReUpdateOutletBcstatuses { get; set; } = null!;
        public virtual DbSet<SetRegion> SetRegions { get; set; } = null!;
        public virtual DbSet<SetReportView> SetReportViews { get; set; } = null!;
        public virtual DbSet<SetRole> SetRoles { get; set; } = null!;
        public virtual DbSet<SetRoleWisePage> SetRoleWisePages { get; set; } = null!;
        public virtual DbSet<SetRoute> SetRoutes { get; set; } = null!;
        public virtual DbSet<SetRouteBackUp> SetRouteBackUps { get; set; } = null!;
        public virtual DbSet<SetSalah> SetSalahs { get; set; } = null!;
        public virtual DbSet<SetSection> SetSections { get; set; } = null!;
        public virtual DbSet<SetSecuredUser> SetSecuredUsers { get; set; } = null!;
        public virtual DbSet<SetSmoker> SetSmokers { get; set; } = null!;
        public virtual DbSet<SetSmokerBak> SetSmokerBaks { get; set; } = null!;
        public virtual DbSet<SetSmokerCategory> SetSmokerCategories { get; set; } = null!;
        public virtual DbSet<SetSrofficer> SetSrofficers { get; set; } = null!;
        public virtual DbSet<SetSrwiseRoute> SetSrwiseRoutes { get; set; } = null!;
        public virtual DbSet<SetSubModule> SetSubModules { get; set; } = null!;
        public virtual DbSet<SetSurveyItem> SetSurveyItems { get; set; } = null!;
        public virtual DbSet<SetSurveyType> SetSurveyTypes { get; set; } = null!;
        public virtual DbSet<SetTerritory> SetTerritories { get; set; } = null!;
        public virtual DbSet<SetThana> SetThanas { get; set; } = null!;
        public virtual DbSet<SetTourType> SetTourTypes { get; set; } = null!;
        public virtual DbSet<SetUnion> SetUnions { get; set; } = null!;
        public virtual DbSet<SetUser> SetUsers { get; set; } = null!;
        public virtual DbSet<SetUserMessage> SetUserMessages { get; set; } = null!;
        public virtual DbSet<SetUserMessageReceiver> SetUserMessageReceivers { get; set; } = null!;
        public virtual DbSet<SetUserWisePage> SetUserWisePages { get; set; } = null!;
        public virtual DbSet<SetUserWiseRole> SetUserWiseRoles { get; set; } = null!;
        public virtual DbSet<SetVisitStatus> SetVisitStatuses { get; set; } = null!;
        public virtual DbSet<SrcsrNotification> SrcsrNotifications { get; set; } = null!;
        public virtual DbSet<Student> Students { get; set; } = null!;
        public virtual DbSet<SystemDmsDmreceivedItemFromFactory> SystemDmsDmreceivedItemFromFactories { get; set; } = null!;
        public virtual DbSet<SystemDmsDmrecevedFromFactory> SystemDmsDmrecevedFromFactories { get; set; } = null!;
        public virtual DbSet<SystemDmsFactoryChallan> SystemDmsFactoryChallans { get; set; } = null!;
        public virtual DbSet<SystemDmsFactoryChallanDetail> SystemDmsFactoryChallanDetails { get; set; } = null!;
        public virtual DbSet<SystemDmsFactoryReceive> SystemDmsFactoryReceives { get; set; } = null!;
        public virtual DbSet<TablePkid> TablePkids { get; set; } = null!;
        public virtual DbSet<TbEventLog> TbEventLogs { get; set; } = null!;
        public virtual DbSet<TbReport> TbReports { get; set; } = null!;
        public virtual DbSet<TblWeight> TblWeights { get; set; } = null!;
        public virtual DbSet<TempOrder> TempOrders { get; set; } = null!;
        public virtual DbSet<TempUnionListUpdate> TempUnionListUpdates { get; set; } = null!;
        public virtual DbSet<VwcurrentDateDistinctGpstrackingPresentEmployee> VwcurrentDateDistinctGpstrackingPresentEmployees { get; set; } = null!;
        public virtual DbSet<VwdellarSummaryReport> VwdellarSummaryReports { get; set; } = null!;
        public virtual DbSet<VwfacFactoryItemCurrentStock> VwfacFactoryItemCurrentStocks { get; set; } = null!;
        public virtual DbSet<VworderSummaryReport> VworderSummaryReports { get; set; } = null!;
        public virtual DbSet<Vwoutlet> Vwoutlets { get; set; } = null!;
        public virtual DbSet<VwsaleTargetSummaryReport> VwsaleTargetSummaryReports { get; set; } = null!;
        public virtual DbSet<VwscmAreaCurrentStock> VwscmAreaCurrentStocks { get; set; } = null!;
        public virtual DbSet<VwscmAreaCurrentStockForSale> VwscmAreaCurrentStockForSales { get; set; } = null!;
        public virtual DbSet<VwscmDepoCurrentStock> VwscmDepoCurrentStocks { get; set; } = null!;
        public virtual DbSet<VwscmFacToFacCurrentStock> VwscmFacToFacCurrentStocks { get; set; } = null!;
        public virtual DbSet<VwscmFactoryCurrentStock> VwscmFactoryCurrentStocks { get; set; } = null!;
        public virtual DbSet<VwscmNapkinAreaCurrentStock> VwscmNapkinAreaCurrentStocks { get; set; } = null!;
        public virtual DbSet<VwscmNapkinDepoCurrentStock> VwscmNapkinDepoCurrentStocks { get; set; } = null!;
        public virtual DbSet<DMSSDWCDZeroBalanceReportStockSide> DMSSDWCDZeroBalanceReportStockSides { get; set; } = null!;
        public virtual DbSet<DMSSDWCDZeroBalanceReportExpenseSide> DMS_SDWCDZeroBalanceReportExpenseSides { get; set; } = null!;
        public virtual DbSet<DMSADWZeroBalanceReportStockSide> DMSADWZeroBalanceReportStockSides { get; set; } = null!;
        public virtual DbSet<DMSADWZeroBalanceReportExpenseSide> DMS_ADWZeroBalanceReportExpenseSides { get; set; } = null!;

        public virtual DbSet<DMSSDWZeroBalanceReportStockSide> DMSSDWZeroBalanceReportStockSides { get; set; } = null!;
        public virtual DbSet<DMSSDWZeroBalanceReportExpenseSide> DMSSDWZeroBalanceReportExpenseSides { get; set; } = null!;
        public virtual DbSet<ACCSPGETTopSheetProductStockForDepotWithChildDepot> ACCSPGETTopSheetProductStockForDepotWithChildDepots { get; set; } = null!;
        public virtual DbSet<ACCSPGETTopSheetProductExpenseForDepotWithChildDepot> ACCSPGETTopSheetProductExpenseForDepotWithChildDepots { get; set; } = null!;
        public virtual DbSet<DMSSPGetSDWCDZeroBalanceSalesReportByDepoAndDate> DMSSPGetSDWCDZeroBalanceSalesReportByDepoAndDates { get; set; } = null!; 

        public virtual DbSet<ACCGETDateWiseAreaZeroBalanceReportStockPart> ACCGETDateWiseAreaZeroBalanceReportStockParts { get; set; } = null!;
        public virtual DbSet<ACCGETDateWiseAreaZeroBalanceReportExpensePart> ACCSPGETAreaWiseZeroBlanceExpenseParts { get; set; } = null!;

        public virtual DbSet<ACCGETDateWiseOnlySoleDepotZeroBalanceReportStockPart> ACCGETDateWiseOnlySoleDepotZeroBalanceReportStockParts { get; set; } = null!;
        public virtual DbSet<ACCGETDateWiseOnlySoleDepotZeroBalanceReportExpensePart> ACCSPGETOnlySoleDepotWiseZeroBlanceExpenseParts { get; set; } = null!;

        public virtual DbSet<AccZeroBalanceReportItem> AccZeroBalanceReportItems { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=123.200.7.37;Database=AkijSCMSDB;User=Sa; Password=ABlock***###;Trusted_Connection=false;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccAdvance>(entity =>
            {
                entity.ToTable("ACC_Advance");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AdvanceTypeId).HasColumnName("AdvanceTypeID");

                entity.Property(e => e.Amount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.DepoId).HasColumnName("DepoID");

                entity.Property(e => e.EmployementId).HasColumnName("EmployementID");

                entity.Property(e => e.Iemid).HasColumnName("IEMID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.MiscellaneousAdvancePerson)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.MiscellaneousPersonMobileNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MiscellaneousPurpose)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ResEmployeeId).HasColumnName("ResEmployeeID");

                entity.HasOne(d => d.AdvanceType)
                    .WithMany(p => p.AccAdvances)
                    .HasForeignKey(d => d.AdvanceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ACC_Advance_ACC_AdvanceType");

                entity.HasOne(d => d.Iem)
                    .WithMany(p => p.AccAdvances)
                    .HasForeignKey(d => d.Iemid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ACC_Advance_ACC_IncomeExpenseMaster");
            });

            modelBuilder.Entity<AccAdvanceBackup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Acc_AdvanceBackup");

                entity.Property(e => e.AdvanceTypeId).HasColumnName("AdvanceTypeID");

                entity.Property(e => e.Amount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.DepoId).HasColumnName("DepoID");

                entity.Property(e => e.EmployementId).HasColumnName("EmployementID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Iemid).HasColumnName("IEMID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.MiscellaneousAdvancePerson)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.MiscellaneousPersonMobileNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MiscellaneousPurpose)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ResEmployeeId).HasColumnName("ResEmployeeID");
            });

            modelBuilder.Entity<AccAdvanceReturn>(entity =>
            {
                entity.ToTable("ACC_AdvanceReturn");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AdjustAmountCash).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.AdjustAmountVoucher).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AdjustDate).HasColumnType("date");

                entity.Property(e => e.AdvanceId).HasColumnName("AdvanceID");

                entity.Property(e => e.DueAmount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Iemid).HasColumnName("IEMID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.HasOne(d => d.Advance)
                    .WithMany(p => p.AccAdvanceReturns)
                    .HasForeignKey(d => d.AdvanceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ACC_SRAdvanceReturn_ACC_SRAdvance");
            });

            modelBuilder.Entity<AccAdvanceType>(entity =>
            {
                entity.ToTable("ACC_AdvanceType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.TypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AccZeroBalanceReportItem>(entity =>
            {
                entity.ToTable("ACC_ZeroBalanceReportItem");

                entity.Property(e => e.ID).HasColumnName("ID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(500)
                    .IsUnicode(false);
                entity.Property(e => e.ReportType);
                entity.Property(e => e.TranType);
                entity.Property(e => e.SubTranType);
                entity.Property(e => e.SlNo);
                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<AccAreaDebit>(entity =>
            {
                entity.ToTable("ACC_AreaDebit");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.AreaLedgerId).HasColumnName("AreaLedgerID");

                entity.Property(e => e.Bdid).HasColumnName("BDID");

                entity.Property(e => e.Ctid).HasColumnName("CTID");

                entity.Property(e => e.ExpenseId).HasColumnName("ExpenseID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.AccAreaDebits)
                    .HasForeignKey(d => d.AreaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ACC_AreaDebit_SET_Area");

                entity.HasOne(d => d.AreaLedger)
                    .WithMany(p => p.AccAreaDebits)
                    .HasForeignKey(d => d.AreaLedgerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ACC_AreaDebit_ACC_AreaLedger");
            });

            modelBuilder.Entity<AccAreaLedger>(entity =>
            {
                entity.HasKey(e => e.Alid);

                entity.ToTable("ACC_AreaLedger");

                entity.Property(e => e.Alid)
                    .ValueGeneratedNever()
                    .HasColumnName("ALID");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.AccAreaLedgers)
                    .HasForeignKey(d => d.AreaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ACC_AreaLedger_SET_Area");
            });

            modelBuilder.Entity<AccBank>(entity =>
            {
                entity.HasKey(e => e.BankId);

                entity.ToTable("ACC_Bank");

                entity.HasIndex(e => e.BankName, "IX_ACC_Bank")
                    .IsUnique();

                entity.Property(e => e.BankId).HasColumnName("BankID");

                entity.Property(e => e.BankName).HasMaxLength(50);

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AccBankDeposit>(entity =>
            {
                entity.ToTable("ACC_BankDeposit");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DdPayOrderDate).HasColumnType("date");

                entity.Property(e => e.DdPayOrderNo).HasMaxLength(50);

                entity.Property(e => e.DepoId).HasColumnName("DepoID");

                entity.Property(e => e.DepositBbid).HasColumnName("DepositBBId");

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.Ieid).HasColumnName("IEID");

                entity.Property(e => e.ReceiveBbid).HasColumnName("ReceiveBBId");

                entity.Property(e => e.ReceiveDbaid).HasColumnName("ReceiveDBAID");

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.DepositBb)
                    .WithMany(p => p.AccBankDeposits)
                    .HasForeignKey(d => d.DepositBbid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ACC_BankDeposit_ACC_BankBranch");

                entity.HasOne(d => d.Ie)
                    .WithMany(p => p.AccBankDeposits)
                    .HasForeignKey(d => d.Ieid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ACC_BankDeposit_ACC_IncomeExpenseMaster");

                entity.HasOne(d => d.ReceiveDba)
                    .WithMany(p => p.AccBankDeposits)
                    .HasForeignKey(d => d.ReceiveDbaid)
                    .HasConstraintName("FK_ACC_BankDeposit_ACC_DepoWiseBankAccount");

                entity.HasOne(d => d.TransactionType)
                    .WithMany(p => p.AccBankDeposits)
                    .HasForeignKey(d => d.TransactionTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ACC_BankDeposit_ACC_TransactionType");
            });

            modelBuilder.Entity<AccBankDepositDelete>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ACC_BankDeposit_Delete");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DdPayOrderDate).HasColumnType("date");

                entity.Property(e => e.DdPayOrderNo).HasMaxLength(50);

                entity.Property(e => e.DepoId).HasColumnName("DepoID");

                entity.Property(e => e.DepositBbid).HasColumnName("DepositBBId");

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ieid).HasColumnName("IEID");

                entity.Property(e => e.ReceiveBbid).HasColumnName("ReceiveBBId");

                entity.Property(e => e.ReceiveDbaid).HasColumnName("ReceiveDBAID");

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AccBankDepositUpdateInfo>(entity =>
            {
                entity.ToTable("ACC_BankDepositUpdateInfo");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Bdid).HasColumnName("BDID");

                entity.Property(e => e.Iedid).HasColumnName("IEDID");

                entity.Property(e => e.Ieid).HasColumnName("IEID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.RefEmployeeId).HasColumnName("RefEmployeeID");

                entity.Property(e => e.UpdateDeleteStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AccBankWiseAmout>(entity =>
            {
                entity.HasKey(e => e.TransactionId)
                    .HasName("PK_BankWiseAmout");

                entity.ToTable("ACC_BankWiseAmout");

                entity.HasIndex(e => e.DdorPayOrderNo, "IX_ACC_BankWiseAmout")
                    .IsUnique();

                entity.Property(e => e.TransactionId)
                    .ValueGeneratedNever()
                    .HasColumnName("TransactionID");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DapproverId).HasColumnName("DApproverID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Dbaid).HasColumnName("DBAID");

                entity.Property(e => e.DdorPayOrderNo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DDOrPayOrderNo");

                entity.Property(e => e.DdreceiveDbaid).HasColumnName("DDReceiveDBAID");

                entity.Property(e => e.DepoApproveDate).HasColumnType("date");

                entity.Property(e => e.HoapproveDate)
                    .HasColumnType("date")
                    .HasColumnName("HOApproveDate");

                entity.Property(e => e.HoapproverId).HasColumnName("HOApproverID");

                entity.Property(e => e.IsApprovedByDm).HasColumnName("IsApprovedByDM");

                entity.Property(e => e.IsApprovedByHo).HasColumnName("IsApprovedByHO");

                entity.Property(e => e.Mrno).HasColumnName("MRNo");

                entity.Property(e => e.Remarks).HasMaxLength(500);

                entity.HasOne(d => d.Dba)
                    .WithMany(p => p.AccBankWiseAmouts)
                    .HasForeignKey(d => d.Dbaid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BankWiseAmout_DepoWiseBankAccount");

                entity.HasOne(d => d.TransactionTypeNavigation)
                    .WithMany(p => p.AccBankWiseAmouts)
                    .HasForeignKey(d => d.TransactionType)
                    .HasConstraintName("FK_ACC_BankWiseAmout_ACC_TransactionType");
            });

            modelBuilder.Entity<AccBankWiseBranch>(entity =>
            {
                entity.HasKey(e => e.BranchId)
                    .HasName("PK_BankWiseBranch");

                entity.ToTable("ACC_BankWiseBranch");

                entity.HasIndex(e => new { e.BankId, e.BranchName, e.AreaId }, "IX_ACC_BankWiseBranch")
                    .IsUnique();

                entity.Property(e => e.BranchId)
                    .ValueGeneratedNever()
                    .HasColumnName("BranchID");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.BankId).HasColumnName("BankID");

                entity.Property(e => e.BranchAddress).HasMaxLength(300);

                entity.Property(e => e.BranchName).HasMaxLength(100);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DepoId).HasColumnName("DepoID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.AccBankWiseBranches)
                    .HasForeignKey(d => d.BankId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BankWiseBranch_Bank");
            });

            modelBuilder.Entity<AccCashOrDepositReceive>(entity =>
            {
                entity.ToTable("ACC_CashOrDepositReceive");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.BdepoistId).HasColumnName("BDepoistID");

                entity.Property(e => e.CashTranId).HasColumnName("CashTranID");

                entity.Property(e => e.Ieid).HasColumnName("IEID");

                entity.Property(e => e.ReceiveDate).HasColumnType("date");

                entity.Property(e => e.ReceiveNo).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Bdepoist)
                    .WithMany(p => p.AccCashOrDepositReceives)
                    .HasForeignKey(d => d.BdepoistId)
                    .HasConstraintName("FK_ACC_CashOrDepositReceive_ACC_BankDeposit");

                entity.HasOne(d => d.CashTran)
                    .WithMany(p => p.AccCashOrDepositReceives)
                    .HasForeignKey(d => d.CashTranId)
                    .HasConstraintName("FK_ACC_CashOrDepositReceive_ACC_CashTransfer");

                entity.HasOne(d => d.Ie)
                    .WithMany(p => p.AccCashOrDepositReceives)
                    .HasForeignKey(d => d.Ieid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ACC_CashOrDepositReceive_ACC_IncomeExpenseMaster");
            });

            modelBuilder.Entity<AccCashTransfer>(entity =>
            {
                entity.ToTable("ACC_CashTransfer");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.DepoId).HasColumnName("DepoID");

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.Ieid).HasColumnName("IEID");

                entity.Property(e => e.IsAtal).HasColumnName("IsATAL");

                entity.Property(e => e.PayDate).HasColumnType("datetime");

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.HasOne(d => d.Ie)
                    .WithMany(p => p.AccCashTransfers)
                    .HasForeignKey(d => d.Ieid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ACC_CashTransfer_ACC_IncomeExpenseMaster");
            });

            modelBuilder.Entity<AccCashTransferDelete>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ACC_CashTransfer_Delete");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.DepoId).HasColumnName("DepoID");

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ieid).HasColumnName("IEID");

                entity.Property(e => e.IsAtal).HasColumnName("IsATAL");

                entity.Property(e => e.PayDate).HasColumnType("datetime");

                entity.Property(e => e.RegionId).HasColumnName("RegionID");
            });

            modelBuilder.Entity<AccCashTransferUpdateInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ACC_CashTransferUpdateInfo");

                entity.Property(e => e.CashTransferId).HasColumnName("CashTransferID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Iedid).HasColumnName("IEDID");

                entity.Property(e => e.Ieid).HasColumnName("IEID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.RefEmployeeId).HasColumnName("RefEmployeeID");

                entity.Property(e => e.UpdateDeleteStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AccClosingBalance>(entity =>
            {
                entity.ToTable("ACC_ClosingBalance");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.ClosingAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AccDailyAccountDataDelete>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Acc_DailyAccountDataDelete");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.DepoId).HasColumnName("DepoID");

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Iedate)
                    .HasColumnType("date")
                    .HasColumnName("IEDate");

                entity.Property(e => e.IeheaderId).HasColumnName("IEHeaderID");

                entity.Property(e => e.PayDate).HasColumnType("date");

                entity.Property(e => e.PurposeId).HasColumnName("PurposeID");

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(38, 2)");
            });

            modelBuilder.Entity<AccDailyAccountDatum>(entity =>
            {
                entity.ToTable("Acc_DailyAccountData");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.DepoId).HasColumnName("DepoID");

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.Iedate)
                    .HasColumnType("date")
                    .HasColumnName("IEDate");

                entity.Property(e => e.IeheaderId).HasColumnName("IEHeaderID");

                entity.Property(e => e.PayDate).HasColumnType("date");

                entity.Property(e => e.PurposeId).HasColumnName("PurposeID");

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(38, 2)");
            });

            modelBuilder.Entity<AccDailyClosingBalance>(entity =>
            {
                entity.ToTable("ACC_DailyClosingBalance");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccId).HasColumnName("AccID");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DepoId).HasColumnName("DepoID");

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.PayDate).HasColumnType("date");

                entity.Property(e => e.RegionId).HasColumnName("RegionID");
            });

            modelBuilder.Entity<AccDailyExpenseUpdateInfo>(entity =>
            {
                entity.ToTable("ACC_DailyExpenseUpdateInfo");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Iedid).HasColumnName("IEDID");

                entity.Property(e => e.Ieid).HasColumnName("IEID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.RefEmployeeId).HasColumnName("RefEmployeeID");

                entity.Property(e => e.UpdateDeleteStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AccDepoCredit>(entity =>
            {
                entity.HasKey(e => e.Dcid);

                entity.ToTable("ACC_DepoCredit");

                entity.Property(e => e.Dcid)
                    .ValueGeneratedNever()
                    .HasColumnName("DCID");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Ctid).HasColumnName("CTID");

                entity.Property(e => e.DepoId).HasColumnName("DepoID");

                entity.Property(e => e.Dlid).HasColumnName("DLID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.OtherSaleId).HasColumnName("OtherSaleID");

                entity.HasOne(d => d.Ct)
                    .WithMany(p => p.AccDepoCredits)
                    .HasForeignKey(d => d.Ctid)
                    .HasConstraintName("FK_ACC_DepoCredit_ACC_CashTransfer");

                entity.HasOne(d => d.Depo)
                    .WithMany(p => p.AccDepoCredits)
                    .HasForeignKey(d => d.DepoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ACC_DepoCredit_SET_Depo");

                entity.HasOne(d => d.Dl)
                    .WithMany(p => p.AccDepoCredits)
                    .HasForeignKey(d => d.Dlid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ACC_DepoCredit_ACC_DepoLedger");

                entity.HasOne(d => d.OtherSale)
                    .WithMany(p => p.AccDepoCredits)
                    .HasForeignKey(d => d.OtherSaleId)
                    .HasConstraintName("FK_ACC_DepoCredit_ACC_OthersIncome");
            });

            modelBuilder.Entity<AccDepoDebit>(entity =>
            {
                entity.ToTable("ACC_DepoDebit");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Bdid).HasColumnName("BDID");

                entity.Property(e => e.Ctid).HasColumnName("CTID");

                entity.Property(e => e.DepoId).HasColumnName("DepoID");

                entity.Property(e => e.Dlid).HasColumnName("DLID");

                entity.Property(e => e.ExpenseId).HasColumnName("ExpenseID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.HasOne(d => d.Bd)
                    .WithMany(p => p.AccDepoDebits)
                    .HasForeignKey(d => d.Bdid)
                    .HasConstraintName("FK_ACC_DepoDebit_ACC_BankDeposit");

                entity.HasOne(d => d.Ct)
                    .WithMany(p => p.AccDepoDebits)
                    .HasForeignKey(d => d.Ctid)
                    .HasConstraintName("FK_ACC_DepoDebit_ACC_CashTransfer");

                entity.HasOne(d => d.Depo)
                    .WithMany(p => p.AccDepoDebits)
                    .HasForeignKey(d => d.DepoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ACC_DepoDebit_SET_Depo");

                entity.HasOne(d => d.Dl)
                    .WithMany(p => p.AccDepoDebits)
                    .HasForeignKey(d => d.Dlid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ACC_DepoDebit_ACC_DepoLedger");

                entity.HasOne(d => d.Expense)
                    .WithMany(p => p.AccDepoDebits)
                    .HasForeignKey(d => d.ExpenseId)
                    .HasConstraintName("FK_ACC_DepoDebit_ACC_ExpenseMaster");
            });

            modelBuilder.Entity<AccDepoLedger>(entity =>
            {
                entity.HasKey(e => e.Dlid);

                entity.ToTable("ACC_DepoLedger");

                entity.Property(e => e.Dlid)
                    .ValueGeneratedNever()
                    .HasColumnName("DLID");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DepoId).HasColumnName("DepoID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.HasOne(d => d.Depo)
                    .WithMany(p => p.AccDepoLedgers)
                    .HasForeignKey(d => d.DepoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ACC_DepoLedger_SET_Depo");
            });

            modelBuilder.Entity<AccDepoWiseBankAccount>(entity =>
            {
                entity.HasKey(e => e.BankAccountId);

                entity.ToTable("ACC_DepoWiseBankAccount");

                entity.Property(e => e.BankAccountId)
                    .ValueGeneratedNever()
                    .HasColumnName("BankAccountID");

                entity.Property(e => e.AccountName).HasMaxLength(50);

                entity.Property(e => e.AccountNo).HasMaxLength(50);

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.BankBranchId).HasColumnName("BankBranchID");

                entity.Property(e => e.DepoId).HasColumnName("DepoID");

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.HasOne(d => d.BankBranch)
                    .WithMany(p => p.AccDepoWiseBankAccounts)
                    .HasForeignKey(d => d.BankBranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DepoWiseBankAccount_BankWiseBranch");

                entity.HasOne(d => d.Depo)
                    .WithMany(p => p.AccDepoWiseBankAccounts)
                    .HasForeignKey(d => d.DepoId)
                    .HasConstraintName("FK_DepoWiseBankAccount_Depo");
            });

            modelBuilder.Entity<AccHeader>(entity =>
            {
                entity.HasKey(e => e.HeaderId)
                    .HasName("PK_AccountHeaderType");

                entity.ToTable("ACC_Header");

                entity.HasIndex(e => e.HeaderName, "IX_AccountHeaderType")
                    .IsUnique();

                entity.Property(e => e.HeaderId).HasColumnName("HeaderID");

                entity.Property(e => e.HeaderDescription).HasMaxLength(200);

                entity.Property(e => e.HeaderName).HasMaxLength(50);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<AccHoCredit>(entity =>
            {
                entity.HasKey(e => e.Hcid);

                entity.ToTable("ACC_HoCredit");

                entity.Property(e => e.Hcid)
                    .ValueGeneratedNever()
                    .HasColumnName("HCID");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Bdid).HasColumnName("BDID");

                entity.Property(e => e.Ctid).HasColumnName("CTID");

                entity.Property(e => e.Hlid).HasColumnName("HLID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.Mrno).HasColumnName("MRNo");

                entity.HasOne(d => d.Bd)
                    .WithMany(p => p.AccHoCredits)
                    .HasForeignKey(d => d.Bdid)
                    .HasConstraintName("FK_ACC_HoCredit_ACC_BankDeposit");

                entity.HasOne(d => d.Ct)
                    .WithMany(p => p.AccHoCredits)
                    .HasForeignKey(d => d.Ctid)
                    .HasConstraintName("FK_ACC_HoCredit_ACC_CashTransfer");

                entity.HasOne(d => d.Hl)
                    .WithMany(p => p.AccHoCredits)
                    .HasForeignKey(d => d.Hlid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ACC_HoCredit_ACC_HoLedger");
            });

            modelBuilder.Entity<AccHoDebit>(entity =>
            {
                entity.ToTable("ACC_HoDebit");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Bdid).HasColumnName("BDID");

                entity.Property(e => e.ExpenseId).HasColumnName("ExpenseID");

                entity.Property(e => e.Hlid).HasColumnName("HLID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.HasOne(d => d.Bd)
                    .WithMany(p => p.AccHoDebits)
                    .HasForeignKey(d => d.Bdid)
                    .HasConstraintName("FK_ACC_HoDebit_ACC_BankDeposit");

                entity.HasOne(d => d.Expense)
                    .WithMany(p => p.AccHoDebits)
                    .HasForeignKey(d => d.ExpenseId)
                    .HasConstraintName("FK_ACC_HoDebit_ACC_ExpenseMaster");

                entity.HasOne(d => d.Hl)
                    .WithMany(p => p.AccHoDebits)
                    .HasForeignKey(d => d.Hlid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ACC_HoDebit_ACC_HoLedger");
            });

            modelBuilder.Entity<AccHoLedger>(entity =>
            {
                entity.HasKey(e => e.Hlid);

                entity.ToTable("ACC_HoLedger");

                entity.Property(e => e.Hlid)
                    .ValueGeneratedNever()
                    .HasColumnName("HLID");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AccHouseRentInfo>(entity =>
            {
                entity.ToTable("ACC_HouseRentInfo");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AdvanceId).HasColumnName("AdvanceID");

                entity.Property(e => e.HouseAddress)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.HouseOwnerName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.MobileNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MonthlyReduceAmount).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.MonthlyRent).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.Advance)
                    .WithMany(p => p.AccHouseRentInfos)
                    .HasForeignKey(d => d.AdvanceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ACC_HouseRentInfo_ACC_Advance");
            });

            modelBuilder.Entity<AccHouseRentMonthly>(entity =>
            {
                entity.ToTable("ACC_HouseRentMonthly");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AdvanceAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AdvanceBalance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.CashAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.DepoId).HasColumnName("DepoID");

                entity.Property(e => e.HouseRentInfoId).HasColumnName("HouseRentInfoID");

                entity.Property(e => e.Iemid).HasColumnName("IEMID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.HasOne(d => d.HouseRentInfo)
                    .WithMany(p => p.AccHouseRentMonthlies)
                    .HasForeignKey(d => d.HouseRentInfoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ACC_HouseRentMonthly_ACC_HouseRentInfo");

                entity.HasOne(d => d.Iem)
                    .WithMany(p => p.AccHouseRentMonthlies)
                    .HasForeignKey(d => d.Iemid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ACC_HouseRentMonthly_ACC_IncomeExpenseMaster");
            });

            modelBuilder.Entity<AccIncomExpenseMaster>(entity =>
            {
                entity.ToTable("ACC_IncomExpenseMaster");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IncomeExpenseTypeId).HasColumnName("IncomeExpenseTypeID");

                entity.Property(e => e.PayTime).HasColumnType("datetime");

                entity.Property(e => e.ResponsibleId).HasColumnName("ResponsibleID");

                entity.Property(e => e.VoucherNo).HasMaxLength(50);
            });

            modelBuilder.Entity<AccIncomeExpense>(entity =>
            {
                entity.ToTable("ACC_IncomeExpense");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("decimal(14, 2)");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.DepoId).HasColumnName("DepoID");

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.IemasterId).HasColumnName("IEMasterID");

                entity.Property(e => e.PayToId).HasColumnName("PayToID");

                entity.Property(e => e.PurposeId).HasColumnName("PurposeID");

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.HasOne(d => d.Depo)
                    .WithMany(p => p.AccIncomeExpenses)
                    .HasForeignKey(d => d.DepoId)
                    .HasConstraintName("FK_ACC_IncomeExpense_SET_Depo");

                entity.HasOne(d => d.Purpose)
                    .WithMany(p => p.AccIncomeExpenses)
                    .HasForeignKey(d => d.PurposeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ACC_IncomeExpense_ACC_Pupose");
            });

            modelBuilder.Entity<AccIncomeExpenseDelete>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Acc_IncomeExpenseDelete");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DepoId).HasColumnName("DepoID");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Iedate)
                    .HasColumnType("date")
                    .HasColumnName("IEDate");

                entity.Property(e => e.IeheaderId).HasColumnName("IEHeaderID");

                entity.Property(e => e.PayDate).HasColumnType("datetime");

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.Property(e => e.ResponsibleId).HasColumnName("ResponsibleID");

                entity.Property(e => e.VoucherNo).HasMaxLength(50);
            });

            modelBuilder.Entity<AccIncomeExpenseDetail>(entity =>
            {
                entity.ToTable("ACC_IncomeExpenseDetail");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Emid).HasColumnName("EMID");

                entity.Property(e => e.PurposeId).HasColumnName("PurposeID");

                entity.HasOne(d => d.Em)
                    .WithMany(p => p.AccIncomeExpenseDetails)
                    .HasForeignKey(d => d.Emid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ACC_IncomeExpenseDetail_ACC_IncomeExpenseMaster");

                entity.HasOne(d => d.Purpose)
                    .WithMany(p => p.AccIncomeExpenseDetails)
                    .HasForeignKey(d => d.PurposeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ACC_IncomeExpenseDetail_ACC_Pupose");
            });

            modelBuilder.Entity<AccIncomeExpenseDetailBackup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ACC_IncomeExpenseDetailBackup");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Emid).HasColumnName("EMID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.PurposeId).HasColumnName("PurposeID");
            });

            modelBuilder.Entity<AccIncomeExpenseDetailDelete>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Acc_IncomeExpenseDetailDelete");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Emid).HasColumnName("EMID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.PurposeId).HasColumnName("PurposeID");
            });

            modelBuilder.Entity<AccIncomeExpenseMaster>(entity =>
            {
                entity.ToTable("ACC_IncomeExpenseMaster");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DepoId).HasColumnName("DepoID");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.Iedate)
                    .HasColumnType("date")
                    .HasColumnName("IEDate");

                entity.Property(e => e.IeheaderId).HasColumnName("IEHeaderID");

                entity.Property(e => e.PayDate).HasColumnType("datetime");

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.Property(e => e.ResponsibleId).HasColumnName("ResponsibleID");

                entity.Property(e => e.VoucherNo).HasMaxLength(50);

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.AccIncomeExpenseMasters)
                    .HasForeignKey(d => d.AreaId)
                    .HasConstraintName("FK_ACC_ExpenseMaster_SET_Area");

                entity.HasOne(d => d.Depo)
                    .WithMany(p => p.AccIncomeExpenseMasters)
                    .HasForeignKey(d => d.DepoId)
                    .HasConstraintName("FK_ACC_ExpenseMaster_SET_Depo");

                entity.HasOne(d => d.Factory)
                    .WithMany(p => p.AccIncomeExpenseMasters)
                    .HasForeignKey(d => d.FactoryId)
                    .HasConstraintName("FK_ACC_ExpenseMaster_SET_Factory");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.AccIncomeExpenseMasters)
                    .HasForeignKey(d => d.RegionId)
                    .HasConstraintName("FK_ACC_ExpenseMaster_SET_Region");
            });

            modelBuilder.Entity<AccIncomeExpenseMasterDelete>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Acc_IncomeExpenseMasterDelete");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DepoId).HasColumnName("DepoID");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Iedate)
                    .HasColumnType("date")
                    .HasColumnName("IEDate");

                entity.Property(e => e.IeheaderId).HasColumnName("IEHeaderID");

                entity.Property(e => e.PayDate).HasColumnType("datetime");

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.Property(e => e.ResponsibleId).HasColumnName("ResponsibleID");

                entity.Property(e => e.VoucherNo).HasMaxLength(50);
            });

            modelBuilder.Entity<AccIncomeExpenseMasterModify>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ACC_IncomeExpenseMasterModify");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DepoId).HasColumnName("DepoID");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Iedate)
                    .HasColumnType("date")
                    .HasColumnName("IEDate");

                entity.Property(e => e.IeheaderId).HasColumnName("IEHeaderID");

                entity.Property(e => e.PayDate).HasColumnType("datetime");

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.Property(e => e.ResponsibleId).HasColumnName("ResponsibleID");

                entity.Property(e => e.VoucherNo).HasMaxLength(50);
            });

            modelBuilder.Entity<AccOpeningBalance>(entity =>
            {
                entity.ToTable("ACC_OpeningBalance");

                entity.HasIndex(e => new { e.AreaId, e.RegionId, e.DepoId, e.FactoryId, e.IsHeadOffice }, "IX_ACC_OpeningBalance")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DepoId).HasColumnName("DepoID");

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.Ieid).HasColumnName("IEID");

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.HasOne(d => d.Ie)
                    .WithMany(p => p.AccOpeningBalances)
                    .HasForeignKey(d => d.Ieid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ACC_OpeningBalance_ACC_IncomeExpenseMaster");
            });

            modelBuilder.Entity<AccOthersIncome>(entity =>
            {
                entity.ToTable("ACC_OthersIncome");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.DepoId).HasColumnName("DepoID");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Ieid).HasColumnName("IEID");

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.AccOthersIncomes)
                    .HasForeignKey(d => d.AreaId)
                    .HasConstraintName("FK_ACC_OthersIncome_SET_Area");

                entity.HasOne(d => d.Depo)
                    .WithMany(p => p.AccOthersIncomes)
                    .HasForeignKey(d => d.DepoId)
                    .HasConstraintName("FK_ACC_OthersIncome_SET_Depo");

                entity.HasOne(d => d.Ie)
                    .WithMany(p => p.AccOthersIncomes)
                    .HasForeignKey(d => d.Ieid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ACC_OthersIncome_ACC_IncomeExpenseMaster");
            });

            modelBuilder.Entity<AccPupose>(entity =>
            {
                entity.HasKey(e => e.PurposeId);

                entity.ToTable("ACC_Pupose");

                entity.Property(e => e.PurposeId)
                    .ValueGeneratedNever()
                    .HasColumnName("PurposeID");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.HeaderId).HasColumnName("HeaderID");

                entity.Property(e => e.PurposeName).HasMaxLength(100);

                entity.Property(e => e.PurposeNameBengali).HasMaxLength(100);

                entity.HasOne(d => d.Header)
                    .WithMany(p => p.AccPuposes)
                    .HasForeignKey(d => d.HeaderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ACC_Pupose_ACC_Header");
            });

            modelBuilder.Entity<AccTransactionType>(entity =>
            {
                entity.HasKey(e => e.TransactionTypeId);

                entity.ToTable("ACC_TransactionType");

                entity.Property(e => e.TransactionTypeId)
                    .ValueGeneratedNever()
                    .HasColumnName("TransactionTypeID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.TransactionTypeName).HasMaxLength(100);
            });

            modelBuilder.Entity<AccVoucerDetail>(entity =>
            {
                entity.ToTable("ACC_VoucerDetail");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.IncExpId).HasColumnName("IncExpID");

                entity.Property(e => e.MasterId).HasColumnName("MasterID");

                entity.Property(e => e.PayToId).HasColumnName("PayToID");

                entity.HasOne(d => d.IncExp)
                    .WithMany(p => p.AccVoucerDetails)
                    .HasForeignKey(d => d.IncExpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ACC_VoucerDetail_ACC_IncomeExpense");

                entity.HasOne(d => d.Master)
                    .WithMany(p => p.AccVoucerDetails)
                    .HasForeignKey(d => d.MasterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ACC_VoucerDetail_ACC_IncomExpenseMaster");
            });

            modelBuilder.Entity<AppsLoginInfo>(entity =>
            {
                entity.ToTable("AppsLoginInfo");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AreaDepotCopyTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AreaDepotCopyTable");

                entity.Property(e => e.AccountCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AreaAddress).HasMaxLength(200);

                entity.Property(e => e.AreaCode).HasMaxLength(50);

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.AreaName).HasMaxLength(100);

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.RegionId).HasColumnName("RegionID");
            });

            modelBuilder.Entity<CrSampleRandView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("cr_sample_randView");

                entity.Property(e => e.RandomNumber).HasColumnName("random_number");
            });

            modelBuilder.Entity<DailyGpsgradeReport>(entity =>
            {
                entity.ToTable("DailyGPSGradeReport");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.AreaName).HasMaxLength(100);

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.DepoName).HasMaxLength(100);

                entity.Property(e => e.DivisionId).HasColumnName("DivisionID");

                entity.Property(e => e.DivisionName).HasMaxLength(50);

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.EmployeeName).HasMaxLength(500);

                entity.Property(e => e.Grade)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JoinDate).HasColumnType("date");

                entity.Property(e => e.Post)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.Property(e => e.RegionName).HasMaxLength(100);

                entity.Property(e => e.TerritoryName).HasMaxLength(100);

                entity.Property(e => e.TotalGpshours).HasColumnName("TotalGPSHours");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DeleteOrderDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DeleteOrderDetail");

                entity.Property(e => e.BpacketMax).HasColumnName("BPacketMax");

                entity.Property(e => e.Fqty).HasColumnName("FQty");

                entity.Property(e => e.GrossTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IncentiveQty).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.OrderDetailId).HasColumnName("OrderDetailID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Rn).HasColumnName("RN");

                entity.Property(e => e.Tp)
                    .HasColumnType("decimal(7, 3)")
                    .HasColumnName("TP");
            });

            modelBuilder.Entity<DmsAreaChallanAgainstAreaRequest>(entity =>
            {
                entity.HasKey(e => e.ChallanId);

                entity.ToTable("DMS_AreaChallanAgainstAreaRequest");

                entity.Property(e => e.ChallanId)
                    .ValueGeneratedNever()
                    .HasColumnName("ChallanID");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.CarNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChallanById).HasColumnName("ChallanByID");

                entity.Property(e => e.ChallanDate).HasColumnType("date");

                entity.Property(e => e.ChallanNo).HasMaxLength(100);

                entity.Property(e => e.DriverId)
                    .HasColumnName("DriverID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DriverName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MobileNo)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks).HasMaxLength(300);
            });

            modelBuilder.Entity<DmsAreaChallanForPoint>(entity =>
            {
                entity.HasKey(e => e.ChallanId)
                    .HasName("PK_DMS_AreaChallanForPoint_1");

                entity.ToTable("DMS_AreaChallanForPoint");

                entity.HasIndex(e => e.ChallanNo, "IX_DMS_AreaChallanForPoint")
                    .IsUnique();

                entity.HasIndex(e => new { e.AreaId, e.Srid, e.RouteId, e.ChallanDate }, "IX_DMS_AreaChallanForPoint_1")
                    .IsUnique();

                entity.Property(e => e.ChallanId)
                    .ValueGeneratedNever()
                    .HasColumnName("ChallanID");

                entity.Property(e => e.AlternetSr)
                    .HasMaxLength(300)
                    .HasColumnName("AlternetSR");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.ChallanById).HasColumnName("ChallanByID");

                entity.Property(e => e.ChallanDate).HasColumnType("date");

                entity.Property(e => e.ChallanNo).HasMaxLength(100);

                entity.Property(e => e.Driver).HasMaxLength(100);

                entity.Property(e => e.IsOrderClosed).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Remarks).HasMaxLength(300);

                entity.Property(e => e.ResSrid).HasColumnName("ResSRID");

                entity.Property(e => e.RouteId).HasColumnName("RouteID");

                entity.Property(e => e.Srid).HasColumnName("SRID");

                entity.Property(e => e.VanNo).HasMaxLength(100);

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.DmsAreaChallanForPoints)
                    .HasForeignKey(d => d.AreaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_AreaChallanForPoint_SET_Area");

                entity.HasOne(d => d.Route)
                    .WithMany(p => p.DmsAreaChallanForPoints)
                    .HasForeignKey(d => d.RouteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_AreaChallanForPoint_SET_Route");

                entity.HasOne(d => d.Sr)
                    .WithMany(p => p.DmsAreaChallanForPoints)
                    .HasForeignKey(d => d.Srid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_AreaChallanForPoint_HRM_PIEmployement");
            });

            modelBuilder.Entity<DmsAreaChallanForPointDelete>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DMS_AreaChallanForPointDelete");

                entity.Property(e => e.AlternetSr)
                    .HasMaxLength(300)
                    .HasColumnName("AlternetSR");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.ChallanById).HasColumnName("ChallanByID");

                entity.Property(e => e.ChallanDate).HasColumnType("date");

                entity.Property(e => e.ChallanId).HasColumnName("ChallanID");

                entity.Property(e => e.ChallanNo).HasMaxLength(100);

                entity.Property(e => e.Driver).HasMaxLength(100);

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.Remarks).HasMaxLength(300);

                entity.Property(e => e.ResSrid).HasColumnName("ResSRID");

                entity.Property(e => e.Rn).HasColumnName("rn");

                entity.Property(e => e.RouteId).HasColumnName("RouteID");

                entity.Property(e => e.Srid).HasColumnName("SRID");

                entity.Property(e => e.VanNo).HasMaxLength(100);
            });

            modelBuilder.Entity<DmsAreaChallanItemForPoint>(entity =>
            {
                entity.HasKey(e => e.ChallanItemId);

                entity.ToTable("DMS_AreaChallanItemForPoint");

                entity.Property(e => e.ChallanItemId)
                    .ValueGeneratedNever()
                    .HasColumnName("ChallanItemID");

                entity.Property(e => e.ChallanId).HasColumnName("ChallanID");

                entity.Property(e => e.InsertUserId).HasColumnName("InsertUserID");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Tp)
                    .HasColumnType("decimal(7, 3)")
                    .HasColumnName("TP");

                entity.HasOne(d => d.Challan)
                    .WithMany(p => p.DmsAreaChallanItemForPoints)
                    .HasForeignKey(d => d.ChallanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_AreaChallanItemForPoint_DMS_AreaDeliveryChallan");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.DmsAreaChallanItemForPoints)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_AreaChallanItemForPoint_SET_Product");
            });

            modelBuilder.Entity<DmsAreaChallanItemForPointDelete>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DMS_AreaChallanItemForPointDelete");

                entity.Property(e => e.ChallanId).HasColumnName("ChallanID");

                entity.Property(e => e.ChallanItemId).HasColumnName("ChallanItemID");

                entity.Property(e => e.InsertUserId).HasColumnName("InsertUserID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Tp)
                    .HasColumnType("decimal(7, 3)")
                    .HasColumnName("TP");
            });

            modelBuilder.Entity<DmsAreaChallanToAreaRequestDetail>(entity =>
            {
                entity.HasKey(e => e.ChallanItemId);

                entity.ToTable("DMS_AreaChallanToAreaRequestDetail");

                entity.Property(e => e.ChallanItemId)
                    .ValueGeneratedNever()
                    .HasColumnName("ChallanItemID");

                entity.Property(e => e.Asid).HasColumnName("ASID");

                entity.Property(e => e.ChallanId).HasColumnName("ChallanID");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.As)
                    .WithMany(p => p.DmsAreaChallanToAreaRequestDetails)
                    .HasForeignKey(d => d.Asid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_AreaChallanToAreaRequestDetail_DMS_AreaStock");

                entity.HasOne(d => d.Challan)
                    .WithMany(p => p.DmsAreaChallanToAreaRequestDetails)
                    .HasForeignKey(d => d.ChallanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_AreaChallanToAreaRequestDetail_DMS_AreaChallanAgainstAreaRequest");
            });

            modelBuilder.Entity<DmsAreaChallanWisePayment>(entity =>
            {
                entity.ToTable("DMS_AreaChallanWisePayment");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DueAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Ieid).HasColumnName("IEID");

                entity.Property(e => e.InsertDate).HasColumnType("date");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.PaidAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Remarks).HasMaxLength(100);

                entity.HasOne(d => d.Ie)
                    .WithMany(p => p.DmsAreaChallanWisePayments)
                    .HasForeignKey(d => d.Ieid)
                    .HasConstraintName("FK_DMS_AreaChallanWisePayment_ACC_IncomeExpenseMaster");
            });

            modelBuilder.Entity<DmsAreaDeliveryChallan>(entity =>
            {
                entity.HasKey(e => e.ChallanId);

                entity.ToTable("DMS_AreaDeliveryChallan");

                entity.HasIndex(e => e.ChallanNo, "IX_DMS_AreaDeliveryChallan")
                    .IsUnique();

                entity.HasIndex(e => new { e.AreaId, e.Srid, e.RouteId, e.ChallanDate }, "IX_DMS_AreaDeliveryChallan_1")
                    .IsUnique();

                entity.Property(e => e.ChallanId)
                    .ValueGeneratedNever()
                    .HasColumnName("ChallanID");

                entity.Property(e => e.AlternetSr)
                    .HasMaxLength(300)
                    .HasColumnName("AlternetSR");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.ChallanById).HasColumnName("ChallanByID");

                entity.Property(e => e.ChallanDate).HasColumnType("date");

                entity.Property(e => e.ChallanNo).HasMaxLength(100);

                entity.Property(e => e.Driver).HasMaxLength(100);

                entity.Property(e => e.Ieid).HasColumnName("IEID");

                entity.Property(e => e.IsApprovedByAm).HasColumnName("IsApprovedByAM");

                entity.Property(e => e.IsOrderClosed).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Remarks).HasMaxLength(300);

                entity.Property(e => e.RouteId).HasColumnName("RouteID");

                entity.Property(e => e.Srid).HasColumnName("SRID");

                entity.Property(e => e.VanNo).HasMaxLength(100);

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.DmsAreaDeliveryChallans)
                    .HasForeignKey(d => d.AreaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_AreaDeliveryChallan_SET_Area");

                entity.HasOne(d => d.Ie)
                    .WithMany(p => p.DmsAreaDeliveryChallans)
                    .HasForeignKey(d => d.Ieid)
                    .HasConstraintName("FK_DMS_AreaDeliveryChallan_ACC_IncomeExpenseMaster");

                entity.HasOne(d => d.Route)
                    .WithMany(p => p.DmsAreaDeliveryChallans)
                    .HasForeignKey(d => d.RouteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_AreaDeliveryChallan_SET_Route");

                entity.HasOne(d => d.Sr)
                    .WithMany(p => p.DmsAreaDeliveryChallans)
                    .HasForeignKey(d => d.Srid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_AreaDeliveryChallan_HRM_PIEmployement");
            });

            modelBuilder.Entity<DmsAreaDeliveryChallanArchive>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DMS_AreaDeliveryChallanArchive");

                entity.Property(e => e.AlternetSr)
                    .HasMaxLength(300)
                    .HasColumnName("AlternetSR");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.ChallanById).HasColumnName("ChallanByID");

                entity.Property(e => e.ChallanDate).HasColumnType("date");

                entity.Property(e => e.ChallanId).HasColumnName("ChallanID");

                entity.Property(e => e.ChallanNo).HasMaxLength(100);

                entity.Property(e => e.Driver).HasMaxLength(100);

                entity.Property(e => e.Ieid).HasColumnName("IEID");

                entity.Property(e => e.IsApprovedByAm).HasColumnName("IsApprovedByAM");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.Remarks).HasMaxLength(300);

                entity.Property(e => e.RouteId).HasColumnName("RouteID");

                entity.Property(e => e.Srid).HasColumnName("SRID");

                entity.Property(e => e.VanNo).HasMaxLength(100);
            });

            modelBuilder.Entity<DmsAreaDeliveryChallanItem>(entity =>
            {
                entity.HasKey(e => e.ChallanItemId);

                entity.ToTable("DMS_AreaDeliveryChallanItem");

                entity.HasIndex(e => new { e.ChallanId, e.ProductId }, "IX_DMS_AreaDeliveryChallanItem")
                    .IsUnique();

                entity.Property(e => e.ChallanItemId)
                    .ValueGeneratedNever()
                    .HasColumnName("ChallanItemID");

                entity.Property(e => e.Asid).HasColumnName("ASID");

                entity.Property(e => e.ChallanId).HasColumnName("ChallanID");

                entity.Property(e => e.InsertUserId).HasColumnName("InsertUserID");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ReturnAsid).HasColumnName("ReturnASID");

                entity.Property(e => e.Tp)
                    .HasColumnType("decimal(7, 3)")
                    .HasColumnName("TP");

                entity.HasOne(d => d.As)
                    .WithMany(p => p.DmsAreaDeliveryChallanItemAs)
                    .HasForeignKey(d => d.Asid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_AreaDeliveryChallanItem_DMS_AreaStock");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.DmsAreaDeliveryChallanItems)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_AreaDeliveryChallanItem_SET_Product");

                entity.HasOne(d => d.ReturnAs)
                    .WithMany(p => p.DmsAreaDeliveryChallanItemReturnAs)
                    .HasForeignKey(d => d.ReturnAsid)
                    .HasConstraintName("FK_DMS_AreaDeliveryChallanItem_DMS_AreaStock1");
            });

            modelBuilder.Entity<DmsAreaDeliveryChallanItemArchive>(entity =>
            {
                entity.HasKey(e => e.ChallanItemId);

                entity.ToTable("DMS_AreaDeliveryChallanItemArchive");

                entity.Property(e => e.ChallanItemId)
                    .ValueGeneratedNever()
                    .HasColumnName("ChallanItemID");

                entity.Property(e => e.Asid).HasColumnName("ASID");

                entity.Property(e => e.ChallanId).HasColumnName("ChallanID");

                entity.Property(e => e.InsertUserId).HasColumnName("InsertUserID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ReturnAsid).HasColumnName("ReturnASID");

                entity.Property(e => e.Tp)
                    .HasColumnType("decimal(7, 3)")
                    .HasColumnName("TP");
            });

            modelBuilder.Entity<DmsAreaDeliveryChallanMoney>(entity =>
            {
                entity.ToTable("DMS_AreaDeliveryChallanMoney");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ChallanId).HasColumnName("ChallanID");

                entity.Property(e => e.NoteId).HasColumnName("NoteID");

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Note)
                    .WithMany(p => p.DmsAreaDeliveryChallanMoneys)
                    .HasForeignKey(d => d.NoteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_AreaDeliveryChallanMoney_SET_NoteAndCoinInfo");
            });

            modelBuilder.Entity<DmsAreaDeliveryChallanOthersInfo>(entity =>
            {
                entity.ToTable("DMS_AreaDeliveryChallanOthersInfo");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ChallanId).HasColumnName("ChallanID");

                entity.Property(e => e.PurposeId).HasColumnName("PurposeID");

                entity.HasOne(d => d.Purpose)
                    .WithMany(p => p.DmsAreaDeliveryChallanOthersInfos)
                    .HasForeignKey(d => d.PurposeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_AreaDeliveryChallanOthersInfo_SET_ChallanPurpose");
            });

            modelBuilder.Entity<DmsAreaOpeningStock>(entity =>
            {
                entity.ToTable("DMS_AreaOpeningStock");

                entity.HasIndex(e => new { e.AreaId, e.ProductId, e.Asid }, "IX_DMS_AreaOpeningStock")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.Asid).HasColumnName("ASID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsertUserId).HasColumnName("InsertUserID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.As)
                    .WithMany(p => p.DmsAreaOpeningStocks)
                    .HasForeignKey(d => d.Asid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_AreaOpeningStock_DMS_AreaStock");
            });

            modelBuilder.Entity<DmsAreaReceived>(entity =>
            {
                entity.HasKey(e => e.AreaRffid)
                    .HasName("PK_DMS_AreaReceved");

                entity.ToTable("DMS_AreaReceived");

                entity.Property(e => e.AreaRffid)
                    .ValueGeneratedNever()
                    .HasColumnName("AreaRFFID");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.LastUpdate).HasColumnType("date");

                entity.Property(e => e.ReceivedById).HasColumnName("ReceivedByID");

                entity.Property(e => e.ReceivedDate).HasColumnType("date");

                entity.Property(e => e.ReceivedNo).HasMaxLength(50);

                entity.Property(e => e.Remarks).HasMaxLength(300);
            });

            modelBuilder.Entity<DmsAreaReceivedItem>(entity =>
            {
                entity.HasKey(e => e.AreaReceiveItemId);

                entity.ToTable("DMS_AreaReceivedItem");

                entity.HasIndex(e => e.DepoChallanItemId, "IX_DMS_AreaReceivedItem")
                    .IsUnique();

                entity.Property(e => e.AreaReceiveItemId)
                    .ValueGeneratedNever()
                    .HasColumnName("AreaReceiveItemID");

                entity.Property(e => e.AreaReceiveId).HasColumnName("AreaReceiveID");

                entity.Property(e => e.Asid).HasColumnName("ASID");

                entity.Property(e => e.DepoChallanItemId).HasColumnName("DepoChallanItemID");

                entity.Property(e => e.InsertUserId).HasColumnName("InsertUserID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.AreaReceive)
                    .WithMany(p => p.DmsAreaReceivedItems)
                    .HasForeignKey(d => d.AreaReceiveId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_AreaReceivedItem_DMS_AreaReceved");

                entity.HasOne(d => d.As)
                    .WithMany(p => p.DmsAreaReceivedItems)
                    .HasForeignKey(d => d.Asid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_AreaReceivedItem_DMS_AreaStock");

                entity.HasOne(d => d.DepoChallanItem)
                    .WithOne(p => p.DmsAreaReceivedItem)
                    .HasForeignKey<DmsAreaReceivedItem>(d => d.DepoChallanItemId)
                    .HasConstraintName("FK_DMS_AreaReceivedItem_DMS_DepoChallanItem");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.DmsAreaReceivedItems)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_AreaReceivedItem_SET_Product");
            });

            modelBuilder.Entity<DmsAreaRecvFromArea>(entity =>
            {
                entity.HasKey(e => e.AreaRffid);

                entity.ToTable("DMS_AreaRecvFromArea");

                entity.Property(e => e.AreaRffid)
                    .ValueGeneratedNever()
                    .HasColumnName("AreaRFFID");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.LastUpdate).HasColumnType("date");

                entity.Property(e => e.ReceivedById).HasColumnName("ReceivedByID");

                entity.Property(e => e.ReceivedDate).HasColumnType("date");

                entity.Property(e => e.ReceivedNo).HasMaxLength(50);

                entity.Property(e => e.Remarks).HasMaxLength(300);
            });

            modelBuilder.Entity<DmsAreaRecvFromAreaDetail>(entity =>
            {
                entity.HasKey(e => e.AreaReceiveItemId);

                entity.ToTable("DMS_AreaRecvFromAreaDetail");

                entity.Property(e => e.AreaReceiveItemId)
                    .ValueGeneratedNever()
                    .HasColumnName("AreaReceiveItemID");

                entity.Property(e => e.AreaReceiveId).HasColumnName("AreaReceiveID");

                entity.Property(e => e.Asid).HasColumnName("ASID");

                entity.Property(e => e.ChallanItemId).HasColumnName("ChallanItemID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.AreaReceive)
                    .WithMany(p => p.DmsAreaRecvFromAreaDetails)
                    .HasForeignKey(d => d.AreaReceiveId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_AreaRecvFromAreaDetail_DMS_AreaRecvFromArea");

                entity.HasOne(d => d.As)
                    .WithMany(p => p.DmsAreaRecvFromAreaDetails)
                    .HasForeignKey(d => d.Asid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_AreaRecvFromAreaDetail_DMS_AreaStock");

                entity.HasOne(d => d.ChallanItem)
                    .WithMany(p => p.DmsAreaRecvFromAreaDetails)
                    .HasForeignKey(d => d.ChallanItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_AreaRecvFromAreaDetail_DMS_AreaChallanToAreaRequestDetail");
            });

            modelBuilder.Entity<DmsAreaRequisitionToRegion>(entity =>
            {
                entity.HasKey(e => e.RequisitionId);

                entity.ToTable("DMS_AreaRequisitionToRegion");

                entity.Property(e => e.RequisitionId)
                    .ValueGeneratedNever()
                    .HasColumnName("RequisitionID");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Remarks).HasMaxLength(300);

                entity.Property(e => e.RequisitionById).HasColumnName("RequisitionByID");

                entity.Property(e => e.RequisitionNo).HasMaxLength(50);
            });

            modelBuilder.Entity<DmsAreaReturn>(entity =>
            {
                entity.HasKey(e => e.ReturnId);

                entity.ToTable("DMS_AreaReturn");

                entity.Property(e => e.ReturnId)
                    .ValueGeneratedNever()
                    .HasColumnName("ReturnID");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.DeliveryManId).HasColumnName("DeliveryManID");

                entity.Property(e => e.DepoId).HasColumnName("DepoID");

                entity.Property(e => e.ReturnDate).HasColumnType("date");
            });

            modelBuilder.Entity<DmsAreaReturnDetail>(entity =>
            {
                entity.HasKey(e => e.ReturnItemId);

                entity.ToTable("DMS_AreaReturnDetail");

                entity.Property(e => e.ReturnItemId)
                    .ValueGeneratedNever()
                    .HasColumnName("ReturnItemID");

                entity.Property(e => e.Asid).HasColumnName("ASID");

                entity.Property(e => e.Cause).HasMaxLength(200);

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.ReturnId).HasColumnName("ReturnID");

                entity.Property(e => e.ReturnTypeId).HasColumnName("ReturnTypeID");

                entity.HasOne(d => d.As)
                    .WithMany(p => p.DmsAreaReturnDetails)
                    .HasForeignKey(d => d.Asid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_AreaReturnDetail_DMS_AreaStock");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.DmsAreaReturnDetails)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_AreaReturnDetail_SET_Product");

                entity.HasOne(d => d.Return)
                    .WithMany(p => p.DmsAreaReturnDetails)
                    .HasForeignKey(d => d.ReturnId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_AreaReturnDetail_DMS_AreaReturn");

                entity.HasOne(d => d.ReturnType)
                    .WithMany(p => p.DmsAreaReturnDetails)
                    .HasForeignKey(d => d.ReturnTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_AreaReturnDetail_ReturnType");
            });

            modelBuilder.Entity<DmsAreaReturnReceive>(entity =>
            {
                entity.ToTable("DMS_AreaReturnReceive");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.ReceiveDate).HasColumnType("datetime");

                entity.Property(e => e.ReturnReceiveNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DmsAreaReturnReceiveDetail>(entity =>
            {
                entity.ToTable("DMS_AreaReturnReceiveDetail");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Dsid).HasColumnName("DSID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Ds)
                    .WithMany(p => p.DmsAreaReturnReceiveDetails)
                    .HasForeignKey(d => d.Dsid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_AreaReturnReceiveDetail_DMS_DepoStock");

                entity.HasOne(d => d.ReturnReceive)
                    .WithMany(p => p.DmsAreaReturnReceiveDetails)
                    .HasForeignKey(d => d.ReturnReceiveId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_AreaReturnReceiveDetail_DMS_AreaReturnReceive");
            });

            modelBuilder.Entity<DmsAreaStock>(entity =>
            {
                entity.HasKey(e => e.Asid)
                    .HasName("PK_DMS_AreaMedicineStock");

                entity.ToTable("DMS_AreaStock");

                entity.HasIndex(e => e.Asid, "IX_DMS_AreaStock");

                entity.Property(e => e.Asid)
                    .ValueGeneratedNever()
                    .HasColumnName("ASID");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.StockDate).HasColumnType("datetime");

                entity.Property(e => e.Tp)
                    .HasColumnType("decimal(5, 3)")
                    .HasColumnName("TP");

                entity.Property(e => e.TransactionDate).HasColumnType("date");

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.DmsAreaStocks)
                    .HasForeignKey(d => d.AreaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_AreaStock_SET_Area");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.DmsAreaStocks)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_AreaStock_SET_Product");
            });

            modelBuilder.Entity<DmsAreaStockZeroBakup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DMS_AreaStockZeroBakup");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.Asid).HasColumnName("ASID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.StockDate).HasColumnType("datetime");

                entity.Property(e => e.Tp)
                    .HasColumnType("decimal(5, 3)")
                    .HasColumnName("TP");

                entity.Property(e => e.TransactionDate).HasColumnType("date");
            });

            modelBuilder.Entity<DmsBpacketDetail>(entity =>
            {
                entity.ToTable("DMS_BPacketDetail");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.BpacketMasterId).HasColumnName("BPacketMasterId");

                entity.Property(e => e.Bpsid).HasColumnName("BPSID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.BpacketMaster)
                    .WithMany(p => p.DmsBpacketDetails)
                    .HasForeignKey(d => d.BpacketMasterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_BPacketDetail_DMS_BPacketMaster");

                entity.HasOne(d => d.Bps)
                    .WithMany(p => p.DmsBpacketDetails)
                    .HasForeignKey(d => d.Bpsid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_BPacketDetail_DMS_BPacketStock");
            });

            modelBuilder.Entity<DmsBpacketDetailBack>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DMS_BPacketDetailBack");

                entity.Property(e => e.BpacketMasterId).HasColumnName("BPacketMasterId");

                entity.Property(e => e.Bpsid).HasColumnName("BPSID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");
            });

            modelBuilder.Entity<DmsBpacketMaster>(entity =>
            {
                entity.ToTable("DMS_BPacketMaster");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ChallanId).HasColumnName("ChallanID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.OutletId).HasColumnName("OutletID");

                entity.HasOne(d => d.Challan)
                    .WithMany(p => p.DmsBpacketMasters)
                    .HasForeignKey(d => d.ChallanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_BPacketMaster_DMS_AreaDeliveryChallan");
            });

            modelBuilder.Entity<DmsBpacketPromotion>(entity =>
            {
                entity.HasKey(e => e.PromotionId)
                    .HasName("PK_BPacketPromotion");

                entity.ToTable("DMS_BPacketPromotion");

                entity.Property(e => e.PromotionId)
                    .ValueGeneratedNever()
                    .HasColumnName("PromotionID");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.DmsBpacketPromotions)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BPacketPromotion_Product");
            });

            modelBuilder.Entity<DmsBpacketStock>(entity =>
            {
                entity.HasKey(e => e.Bpsid);

                entity.ToTable("DMS_BPacketStock");

                entity.Property(e => e.Bpsid)
                    .ValueGeneratedNever()
                    .HasColumnName("BPSID");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");
            });

            modelBuilder.Entity<DmsCompititorsBrand>(entity =>
            {
                entity.ToTable("DMS_CompititorsBrand");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ComBrandName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");
            });

            modelBuilder.Entity<DmsCompititorsBrandAvgSale>(entity =>
            {
                entity.ToTable("DMS_CompititorsBrandAvgSales");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.AvgSales).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ComBrandId).HasColumnName("ComBrandID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.ResEmployeeId).HasColumnName("ResEmployeeID");
            });

            modelBuilder.Entity<DmsDailyAreaClosingStock>(entity =>
            {
                entity.ToTable("DMS_DailyAreaClosingStock");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.Asid).HasColumnName("ASID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.StockDate).HasColumnType("date");
            });

            modelBuilder.Entity<DmsDailyOrder>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.ToTable("DMS_DailyOrders");

                entity.HasIndex(e => new { e.ChallanId, e.EmployeementId, e.OutletId, e.OrderDate, e.OrderTime }, "IX_DMS_DailyOrders")
                    .IsUnique();

                entity.Property(e => e.OrderId)
                    .ValueGeneratedNever()
                    .HasColumnName("OrderID");

                entity.Property(e => e.ChallanId).HasColumnName("ChallanID");

                entity.Property(e => e.EmployeementId).HasColumnName("EmployeementID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.OrderDate).HasColumnType("date");

                entity.Property(e => e.OrderTime)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.OutletId).HasColumnName("OutletID");
            });

            modelBuilder.Entity<DmsDailyOrderBak>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.ToTable("DMS_DailyOrderBak");

                entity.Property(e => e.OrderId)
                    .ValueGeneratedNever()
                    .HasColumnName("OrderID");

                entity.Property(e => e.ChallanId).HasColumnName("ChallanID");

                entity.Property(e => e.EmployeementId).HasColumnName("EmployeementID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.OrderDate).HasColumnType("date");

                entity.Property(e => e.OrderTime)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.OutletId).HasColumnName("OutletID");
            });

            modelBuilder.Entity<DmsDailyOrderDelete>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DMS_DailyOrderDelete");

                entity.Property(e => e.ChallanId).HasColumnName("ChallanID");

                entity.Property(e => e.EmployeementId).HasColumnName("EmployeementID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.OrderDate).HasColumnType("date");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.OrderTime)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.OutletId).HasColumnName("OutletID");
            });

            modelBuilder.Entity<DmsDailyOrderDetail>(entity =>
            {
                entity.HasKey(e => e.OrderDetailId);

                entity.ToTable("DMS_DailyOrderDetail");

                entity.HasIndex(e => new { e.OrderId, e.ProductId }, "IX_DMS_DailyOrderDetail")
                    .IsUnique();

                entity.Property(e => e.OrderDetailId)
                    .ValueGeneratedNever()
                    .HasColumnName("OrderDetailID");

                entity.Property(e => e.BpacketMax).HasColumnName("BPacketMax");

                entity.Property(e => e.Fqty).HasColumnName("FQty");

                entity.Property(e => e.GrossTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IncentiveQty).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Tp)
                    .HasColumnType("decimal(7, 3)")
                    .HasColumnName("TP");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.DmsDailyOrderDetails)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_DailyOrderDetail_DMS_DailyOrders");
            });

            modelBuilder.Entity<DmsDailyOrderDetailBak>(entity =>
            {
                entity.HasKey(e => e.OrderDetailId);

                entity.ToTable("DMS_DailyOrderDetailBak");

                entity.Property(e => e.OrderDetailId)
                    .ValueGeneratedNever()
                    .HasColumnName("OrderDetailID");

                entity.Property(e => e.BpacketMax).HasColumnName("BPacketMax");

                entity.Property(e => e.Fqty).HasColumnName("FQty");

                entity.Property(e => e.GrossTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IncentiveQty).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Tp)
                    .HasColumnType("decimal(7, 3)")
                    .HasColumnName("TP");
            });

            modelBuilder.Entity<DmsDailyOrderDetailDelete>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DMS_DailyOrderDetailDelete");

                entity.Property(e => e.BpacketMax).HasColumnName("BPacketMax");

                entity.Property(e => e.Fqty).HasColumnName("FQty");

                entity.Property(e => e.GrossTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IncentiveQty).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.OrderDetailId).HasColumnName("OrderDetailID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Tp)
                    .HasColumnType("decimal(7, 3)")
                    .HasColumnName("TP");
            });

            modelBuilder.Entity<DmsDailySurvey>(entity =>
            {
                entity.ToTable("DMS_DailySurvey");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.EmployeementId).HasColumnName("EmployeementID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SurveyItemId).HasColumnName("SurveyItemID");
            });

            modelBuilder.Entity<DmsDamageDetail>(entity =>
            {
                entity.ToTable("DMS_DamageDetail");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Asid).HasColumnName("ASID");

                entity.Property(e => e.Dmid).HasColumnName("DMID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.As)
                    .WithMany(p => p.DmsDamageDetails)
                    .HasForeignKey(d => d.Asid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_DamageDetail_DMS_AreaStock");
            });

            modelBuilder.Entity<DmsDamageMaster>(entity =>
            {
                entity.ToTable("DMS_DamageMaster");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ChallanId).HasColumnName("ChallanID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");
            });

            modelBuilder.Entity<DmsDamageReceiveFromDepoDellar>(entity =>
            {
                entity.ToTable("DMS_DamageReceiveFromDepoDellar");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.DellarId).HasColumnName("DellarID");

                entity.Property(e => e.ReceiveDate).HasColumnType("datetime");

                entity.Property(e => e.ReceiveNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Dellar)
                    .WithMany(p => p.DmsDamageReceiveFromDepoDellars)
                    .HasForeignKey(d => d.DellarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_DamageReceiveFromDepoDellar_SET_Dellar");
            });

            modelBuilder.Entity<DmsDamageReceiveFromDepoDellarDetail>(entity =>
            {
                entity.ToTable("DMS_DamageReceiveFromDepoDellarDetail");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Dsid).HasColumnName("DSID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Ds)
                    .WithMany(p => p.DmsDamageReceiveFromDepoDellarDetails)
                    .HasForeignKey(d => d.Dsid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_DamageReceiveFromDepoDellarDetail_DMS_DepoStock");

                entity.HasOne(d => d.Receive)
                    .WithMany(p => p.DmsDamageReceiveFromDepoDellarDetails)
                    .HasForeignKey(d => d.ReceiveId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_DamageReceiveFromDepoDellarDetail_DMS_DamageReceiveFromDepoDellar");
            });

            modelBuilder.Entity<DmsDamageReceivedFromArea>(entity =>
            {
                entity.ToTable("DMS_DamageReceivedFromArea");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.DepoId).HasColumnName("DepoID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.ReceivedDate).HasColumnType("date");

                entity.Property(e => e.ReceivedNo).HasMaxLength(50);

                entity.Property(e => e.Remarks).HasMaxLength(200);
            });

            modelBuilder.Entity<DmsDamageReceivedFromDepo>(entity =>
            {
                entity.ToTable("DMS_DamageReceivedFromDepo");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.DepoId).HasColumnName("DepoID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.ReceivedDate).HasColumnType("date");

                entity.Property(e => e.ReceivedNo).HasMaxLength(50);

                entity.Property(e => e.Remarks).HasMaxLength(100);
            });

            modelBuilder.Entity<DmsDamageReceivedItemFromArea>(entity =>
            {
                entity.ToTable("DMS_DamageReceivedItemFromArea");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Dmsid).HasColumnName("DMSID");

                entity.Property(e => e.Drfaid).HasColumnName("DRFAID");

                entity.Property(e => e.InsertUserId).HasColumnName("InsertUserID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.AreaReturnItem)
                    .WithMany(p => p.DmsDamageReceivedItemFromAreas)
                    .HasForeignKey(d => d.AreaReturnItemId)
                    .HasConstraintName("FK_DMS_DamageReceivedItemFromArea_DMS_DamageReturnToDepoDetail");

                entity.HasOne(d => d.Dms)
                    .WithMany(p => p.DmsDamageReceivedItemFromAreas)
                    .HasForeignKey(d => d.Dmsid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_DamageReceivedItemFromArea_DMS_DepoStock");

                entity.HasOne(d => d.Drfa)
                    .WithMany(p => p.DmsDamageReceivedItemFromAreas)
                    .HasForeignKey(d => d.Drfaid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_DamageReceivedItemFromArea_DMS_DamageReceivedFromArea");
            });

            modelBuilder.Entity<DmsDamageReceivedItemFromDepo>(entity =>
            {
                entity.ToTable("DMS_DamageReceivedItemFromDepo");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Drfdid).HasColumnName("DRFDID");

                entity.Property(e => e.Fmsid).HasColumnName("FMSID");

                entity.Property(e => e.InsertUserId).HasColumnName("InsertUserID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Qty).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Drfd)
                    .WithMany(p => p.DmsDamageReceivedItemFromDepos)
                    .HasForeignKey(d => d.Drfdid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_DamageReceivedItemFromDepo_DMS_DamageReceivedFromDepo");

                entity.HasOne(d => d.Fms)
                    .WithMany(p => p.DmsDamageReceivedItemFromDepos)
                    .HasForeignKey(d => d.Fmsid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_DamageReceivedItemFromDepo_DMS_FactoryMedicineStock");

                entity.HasOne(d => d.ReturnItem)
                    .WithMany(p => p.DmsDamageReceivedItemFromDepos)
                    .HasForeignKey(d => d.ReturnItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_DamageReceivedItemFromDepo_DMS_DamageReturnToFactoryDetail");
            });

            modelBuilder.Entity<DmsDamageReturnToDepo>(entity =>
            {
                entity.ToTable("DMS_DamageReturnToDepo");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.DepoId).HasColumnName("DepoID");

                entity.Property(e => e.Remarks).HasMaxLength(100);

                entity.Property(e => e.ReturnNo).HasMaxLength(50);
            });

            modelBuilder.Entity<DmsDamageReturnToDepoDetail>(entity =>
            {
                entity.ToTable("DMS_DamageReturnToDepoDetail");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Asid).HasColumnName("ASID");

                entity.Property(e => e.Drdid).HasColumnName("DRDID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.As)
                    .WithMany(p => p.DmsDamageReturnToDepoDetails)
                    .HasForeignKey(d => d.Asid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_DamageReturnToDepoDetail_DMS_AreaStock");

                entity.HasOne(d => d.Drd)
                    .WithMany(p => p.DmsDamageReturnToDepoDetails)
                    .HasForeignKey(d => d.Drdid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_DamageReturnToDepoDetail_DMS_DamageReturnToDepo");
            });

            modelBuilder.Entity<DmsDamageReturnToFactory>(entity =>
            {
                entity.ToTable("DMS_DamageReturnToFactory");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.DeliveryManId).HasColumnName("DeliveryManID");

                entity.Property(e => e.DepoId).HasColumnName("DepoID");

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.Remarks).HasMaxLength(100);

                entity.Property(e => e.ReturnNo).HasMaxLength(50);
            });

            modelBuilder.Entity<DmsDamageReturnToFactoryDetail>(entity =>
            {
                entity.ToTable("DMS_DamageReturnToFactoryDetail");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.BatchId).HasColumnName("BatchID");

                entity.Property(e => e.Dmsid).HasColumnName("DMSID");

                entity.Property(e => e.Drfid).HasColumnName("DRFID");

                entity.Property(e => e.InsertUserId).HasColumnName("InsertUserID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.Qty).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Dms)
                    .WithMany(p => p.DmsDamageReturnToFactoryDetails)
                    .HasForeignKey(d => d.Dmsid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_DamageReturnToFactoryDetail_DMS_DepoMedicinStock");

                entity.HasOne(d => d.Drf)
                    .WithMany(p => p.DmsDamageReturnToFactoryDetails)
                    .HasForeignKey(d => d.Drfid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_DamageReturnToFactoryDetail_DMS_DamageReturnToFactory");
            });

            modelBuilder.Entity<DmsDeliveryLocationOfDeliveryMan>(entity =>
            {
                entity.ToTable("DMS_DeliveryLocationOfDeliveryMan");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.DeliveryManId).HasColumnName("DeliveryManID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.MarketId).HasColumnName("MarketID");
            });

            modelBuilder.Entity<DmsDellarChallan>(entity =>
            {
                entity.HasKey(e => e.ChallanId);

                entity.ToTable("DMS_DellarChallan");

                entity.HasIndex(e => e.ChallanNo, "IX_DMS_DellarChallan")
                    .IsUnique();

                entity.Property(e => e.ChallanId)
                    .ValueGeneratedNever()
                    .HasColumnName("ChallanID");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.ChallanById).HasColumnName("ChallanByID");

                entity.Property(e => e.ChallanDate).HasColumnType("date");

                entity.Property(e => e.ChallanNo).HasMaxLength(100);

                entity.Property(e => e.DellarId).HasColumnName("DellarID");

                entity.Property(e => e.Ieid).HasColumnName("IEID");

                entity.Property(e => e.IsApprovedByAm).HasColumnName("IsApprovedByAM");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Remarks).HasMaxLength(300);

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.DmsDellarChallans)
                    .HasForeignKey(d => d.AreaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_DellarChallan_SET_Area");

                entity.HasOne(d => d.ChallanBy)
                    .WithMany(p => p.DmsDellarChallans)
                    .HasForeignKey(d => d.ChallanById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_DellarChallan_HRM_PIEmployement");

                entity.HasOne(d => d.Dellar)
                    .WithMany(p => p.DmsDellarChallans)
                    .HasForeignKey(d => d.DellarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_DellarChallan_SET_Dellar");

                entity.HasOne(d => d.Ie)
                    .WithMany(p => p.DmsDellarChallans)
                    .HasForeignKey(d => d.Ieid)
                    .HasConstraintName("FK_DMS_DellarChallan_ACC_IncomeExpenseMaster");
            });

            modelBuilder.Entity<DmsDellarChallanItem>(entity =>
            {
                entity.HasKey(e => e.ChallanItemId);

                entity.ToTable("DMS_DellarChallanItem");

                entity.Property(e => e.ChallanItemId)
                    .ValueGeneratedNever()
                    .HasColumnName("ChallanItemID");

                entity.Property(e => e.Asid).HasColumnName("ASID");

                entity.Property(e => e.ChallanId).HasColumnName("ChallanID");

                entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.InsertUserId).HasColumnName("InsertUserID");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PayableAmount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.PromotionId).HasColumnName("PromotionID");

                entity.Property(e => e.Tp)
                    .HasColumnType("decimal(7, 2)")
                    .HasColumnName("TP");

                entity.HasOne(d => d.As)
                    .WithMany(p => p.DmsDellarChallanItems)
                    .HasForeignKey(d => d.Asid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_DellarChallanItem_DMS_AreaStock");

                entity.HasOne(d => d.Challan)
                    .WithMany(p => p.DmsDellarChallanItems)
                    .HasForeignKey(d => d.ChallanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_DellarChallanItem_DMS_DellarChallan");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.DmsDellarChallanItems)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_DellarChallanItem_SET_Product");
            });

            modelBuilder.Entity<DmsDellarOrder>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.ToTable("DMS_DellarOrder");

                entity.Property(e => e.OrderId)
                    .ValueGeneratedNever()
                    .HasColumnName("OrderID");

                entity.Property(e => e.ChallanId).HasColumnName("ChallanID");

                entity.Property(e => e.DellarId).HasColumnName("DellarID");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OrderDate).HasColumnType("date");

                entity.HasOne(d => d.Dellar)
                    .WithMany(p => p.DmsDellarOrders)
                    .HasForeignKey(d => d.DellarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_DellarOrder_SET_Dellar");
            });

            modelBuilder.Entity<DmsDellarOrderDetail>(entity =>
            {
                entity.HasKey(e => e.OrderDetailId);

                entity.ToTable("DMS_DellarOrderDetail");

                entity.Property(e => e.OrderDetailId)
                    .ValueGeneratedNever()
                    .HasColumnName("OrderDetailID");

                entity.Property(e => e.GrossTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Tp)
                    .HasColumnType("decimal(7, 2)")
                    .HasColumnName("TP");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.DmsDellarOrderDetails)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_DellarOrderDetail_DMS_DellarOrder");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.DmsDellarOrderDetails)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_DellarOrderDetail_SET_Product");
            });

            modelBuilder.Entity<DmsDellarPromotion>(entity =>
            {
                entity.ToTable("DMS_DellarPromotion");

                entity.HasIndex(e => e.Id, "IX_DMS_DellarPromotion")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.DellarId).HasColumnName("DellarID");

                entity.Property(e => e.DiscountValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.Percentage).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Dellar)
                    .WithMany(p => p.DmsDellarPromotions)
                    .HasForeignKey(d => d.DellarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_DellarPromotion_SET_Dellar");
            });

            modelBuilder.Entity<DmsDepoChallan>(entity =>
            {
                entity.HasKey(e => e.ChallanId)
                    .HasName("PK_DepoIssue");

                entity.ToTable("DMS_DepoChallan");

                entity.Property(e => e.ChallanId)
                    .ValueGeneratedNever()
                    .HasColumnName("ChallanID");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.CarNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChallanById).HasColumnName("ChallanByID");

                entity.Property(e => e.ChallanDate).HasColumnType("date");

                entity.Property(e => e.ChallanNo).HasMaxLength(100);

                entity.Property(e => e.DepoId).HasColumnName("DepoID");

                entity.Property(e => e.DriverId)
                    .HasColumnName("DriverID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DriverName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MobileNo)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks).HasMaxLength(300);

                entity.HasOne(d => d.Depo)
                    .WithMany(p => p.DmsDepoChallans)
                    .HasForeignKey(d => d.DepoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_DepoIssue_SET_Depo");

                entity.HasOne(d => d.Driver)
                    .WithMany(p => p.DmsDepoChallans)
                    .HasForeignKey(d => d.DriverId)
                    .HasConstraintName("FK_DMS_DepoChallan_HRM_PIEmployement");
            });

            modelBuilder.Entity<DmsDepoChallanItem>(entity =>
            {
                entity.HasKey(e => e.ChallanItemId)
                    .HasName("PK_DepoIssueItem");

                entity.ToTable("DMS_DepoChallanItem");

                entity.Property(e => e.ChallanItemId)
                    .ValueGeneratedNever()
                    .HasColumnName("ChallanItemID");

                entity.Property(e => e.ChallanId).HasColumnName("ChallanID");

                entity.Property(e => e.Dsid).HasColumnName("DSID");

                entity.Property(e => e.InsertUserId).HasColumnName("InsertUserID");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Challan)
                    .WithMany(p => p.DmsDepoChallanItems)
                    .HasForeignKey(d => d.ChallanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DepoIssueItem_DepoIssue");

                entity.HasOne(d => d.Ds)
                    .WithMany(p => p.DmsDepoChallanItems)
                    .HasForeignKey(d => d.Dsid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_DepoIssueItem_DMS_DepoStock");
            });

            modelBuilder.Entity<DmsDepoChallanItemBarcode>(entity =>
            {
                entity.ToTable("DMS_DepoChallanItemBarcode");

                entity.HasIndex(e => e.Barcode, "IX_DMS_DepoChallanItemBarcode")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.AreaName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Barcode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CartonNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ChallanNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Day).HasDefaultValueSql("(datepart(day,getdate()))");

                entity.Property(e => e.DepoId).HasColumnName("DepoID");

                entity.Property(e => e.DepoName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.FactoryName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fbarcode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("FBarcode");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.Month).HasDefaultValueSql("(datepart(month,getdate()))");

                entity.Property(e => e.Pdate)
                    .HasColumnType("date")
                    .HasColumnName("PDate");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Sdweight)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("SDWeight");

                entity.Property(e => e.Weight).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.WorkerCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WorkerName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Year).HasDefaultValueSql("(datepart(year,getdate()))");
            });

            modelBuilder.Entity<DmsDepoChallanItemWithBarcode>(entity =>
            {
                entity.ToTable("DMS_DepoChallanItemWithBarcode");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ChallanItemId).HasColumnName("ChallanItemID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.DepoId).HasColumnName("DepoID");

                entity.Property(e => e.Dmriffdwbcid).HasColumnName("DMRIFFDWBCID");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Weight).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.WorkerId).HasColumnName("WorkerID");
            });

            modelBuilder.Entity<DmsDepoDellarChallan>(entity =>
            {
                entity.HasKey(e => e.DchallanId);

                entity.ToTable("DMS_DepoDellarChallan");

                entity.HasIndex(e => e.ChallanNo, "IX_DMS_DepoDellarChallan")
                    .IsUnique();

                entity.Property(e => e.DchallanId)
                    .ValueGeneratedNever()
                    .HasColumnName("DChallanID");

                entity.Property(e => e.CarNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChallanById).HasColumnName("ChallanByID");

                entity.Property(e => e.ChallanDate).HasColumnType("date");

                entity.Property(e => e.ChallanNo).HasMaxLength(100);

                entity.Property(e => e.DellarId).HasColumnName("DellarID");

                entity.Property(e => e.DepoId).HasColumnName("DepoID");

                entity.Property(e => e.DriverId).HasColumnName("DriverID");

                entity.Property(e => e.DriverName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ieid).HasColumnName("IEID");

                entity.Property(e => e.IsApprovedBySdm).HasColumnName("IsApprovedBySDM");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MobileNo)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks).HasMaxLength(300);

                entity.HasOne(d => d.Dellar)
                    .WithMany(p => p.DmsDepoDellarChallans)
                    .HasForeignKey(d => d.DellarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_DepoDellarChallan_SET_Dellar");

                entity.HasOne(d => d.Depo)
                    .WithMany(p => p.DmsDepoDellarChallans)
                    .HasForeignKey(d => d.DepoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_DellarChallan_SET_Depo");

                entity.HasOne(d => d.Ie)
                    .WithMany(p => p.DmsDepoDellarChallans)
                    .HasForeignKey(d => d.Ieid)
                    .HasConstraintName("FK_DMS_DepoDellarChallan_ACC_IncomeExpenseMaster");
            });

            modelBuilder.Entity<DmsDepoDellarChallanItem>(entity =>
            {
                entity.HasKey(e => e.ChallanItemId);

                entity.ToTable("DMS_DepoDellarChallanItem");

                entity.Property(e => e.ChallanItemId)
                    .ValueGeneratedNever()
                    .HasColumnName("ChallanItemID");

                entity.Property(e => e.DchallanId).HasColumnName("DChallanID");

                entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Dsid).HasColumnName("DSID");

                entity.Property(e => e.GrossTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InsertUserId).HasColumnName("InsertUserID");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PayableAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.PromotionId).HasColumnName("PromotionID");

                entity.Property(e => e.Tp)
                    .HasColumnType("decimal(7, 2)")
                    .HasColumnName("TP");

                entity.HasOne(d => d.Dchallan)
                    .WithMany(p => p.DmsDepoDellarChallanItems)
                    .HasForeignKey(d => d.DchallanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_DellarChallanItem_DMS_DepoDellarChallan");

                entity.HasOne(d => d.Ds)
                    .WithMany(p => p.DmsDepoDellarChallanItems)
                    .HasForeignKey(d => d.Dsid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_DepoDellarChallanItem_DMS_DepoStock");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.DmsDepoDellarChallanItems)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_DepoDellarChallanItem_SET_Product");
            });

            modelBuilder.Entity<DmsDepoDellarChallanItemToDamage>(entity =>
            {
                entity.HasKey(e => e.ChallanItemId)
                    .HasName("PK_DepoDellarChallanItemToDamage");

                entity.ToTable("DMS_DepoDellarChallanItemToDamage");

                entity.Property(e => e.ChallanItemId)
                    .ValueGeneratedNever()
                    .HasColumnName("ChallanItemID");

                entity.Property(e => e.DchallanId).HasColumnName("DChallanID");

                entity.Property(e => e.Dsid).HasColumnName("DSID");

                entity.Property(e => e.InsertUserId).HasColumnName("InsertUserID");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Dchallan)
                    .WithMany(p => p.DmsDepoDellarChallanItemToDamages)
                    .HasForeignKey(d => d.DchallanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DepoDellarChallanItemToDamage_DepoIssue");

                entity.HasOne(d => d.Ds)
                    .WithMany(p => p.DmsDepoDellarChallanItemToDamages)
                    .HasForeignKey(d => d.Dsid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_DepoDellarChallanItemToDamage_DMS_DepoStock");
            });

            modelBuilder.Entity<DmsDepoDellarChallanToDamage>(entity =>
            {
                entity.HasKey(e => e.DchallanId);

                entity.ToTable("DMS_DepoDellarChallanToDamage");

                entity.HasIndex(e => e.ChallanNo, "IX_DMS_DepoDellarChallanToDamage")
                    .IsUnique();

                entity.Property(e => e.DchallanId)
                    .ValueGeneratedNever()
                    .HasColumnName("DChallanID");

                entity.Property(e => e.CarNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChallanById).HasColumnName("ChallanByID");

                entity.Property(e => e.ChallanDate).HasColumnType("date");

                entity.Property(e => e.ChallanNo).HasMaxLength(100);

                entity.Property(e => e.DellarId).HasColumnName("DellarID");

                entity.Property(e => e.DepoId).HasColumnName("DepoID");

                entity.Property(e => e.DriverId).HasColumnName("DriverID");

                entity.Property(e => e.DriverName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsApprovedBySdm).HasColumnName("IsApprovedBySDM");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MobileNo)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks).HasMaxLength(300);

                entity.HasOne(d => d.Dellar)
                    .WithMany(p => p.DmsDepoDellarChallanToDamages)
                    .HasForeignKey(d => d.DellarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_DepoDellarChallanToDamage_SET_Dellar");

                entity.HasOne(d => d.Depo)
                    .WithMany(p => p.DmsDepoDellarChallanToDamages)
                    .HasForeignKey(d => d.DepoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_DepoDellarChallanToDamage_SET_Depo");
            });

            modelBuilder.Entity<DmsDepoOpeningStock>(entity =>
            {
                entity.ToTable("DMS_DepoOpeningStock");

                entity.HasIndex(e => new { e.DepoId, e.ProductId }, "IX_DMS_DepoOpeningStock")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DepoId).HasColumnName("DepoID");

                entity.Property(e => e.Dsid).HasColumnName("DSID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Ds)
                    .WithMany(p => p.DmsDepoOpeningStocks)
                    .HasForeignKey(d => d.Dsid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_DepoOpeningStock_DMS_DepoStock");
            });

            modelBuilder.Entity<DmsDepoRequisition>(entity =>
            {
                entity.HasKey(e => e.RequisitionId)
                    .HasName("PK_DepoRequisition");

                entity.ToTable("DMS_DepoRequisition");

                entity.Property(e => e.RequisitionId)
                    .ValueGeneratedNever()
                    .HasColumnName("RequisitionID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.DepoId).HasColumnName("DepoID");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Remarks).HasMaxLength(300);

                entity.Property(e => e.RequisitionById).HasColumnName("RequisitionByID");

                entity.Property(e => e.RequisitionNo).HasMaxLength(50);

                entity.HasOne(d => d.Depo)
                    .WithMany(p => p.DmsDepoRequisitions)
                    .HasForeignKey(d => d.DepoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_Requisition_SET_Depo");
            });

            modelBuilder.Entity<DmsDepoRequisitionItem>(entity =>
            {
                entity.HasKey(e => e.RequisitionItemId);

                entity.ToTable("DMS_DepoRequisitionItem");

                entity.Property(e => e.RequisitionItemId)
                    .ValueGeneratedNever()
                    .HasColumnName("RequisitionItemID");

                entity.Property(e => e.InsertUserId).HasColumnName("InsertUserID");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.RequisitionId).HasColumnName("RequisitionID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.DmsDepoRequisitionItems)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_DepoRequisitionItem_SET_Product");

                entity.HasOne(d => d.Requisition)
                    .WithMany(p => p.DmsDepoRequisitionItems)
                    .HasForeignKey(d => d.RequisitionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_DepoRequisitionItem_DMS_DepoRequisition");
            });

            modelBuilder.Entity<DmsDepoReturn>(entity =>
            {
                entity.HasKey(e => e.ReturnId)
                    .HasName("PK_DepoReturn");

                entity.ToTable("DMS_DepoReturn");

                entity.Property(e => e.ReturnId)
                    .ValueGeneratedNever()
                    .HasColumnName("ReturnID");

                entity.Property(e => e.DeliveryManId).HasColumnName("DeliveryManID");

                entity.Property(e => e.DepoId).HasColumnName("DepoID");

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.ReturnDate).HasColumnType("date");
            });

            modelBuilder.Entity<DmsDepoReturnDetail>(entity =>
            {
                entity.HasKey(e => e.ReturnItemId)
                    .HasName("PK_DepoReturnDetail");

                entity.ToTable("DMS_DepoReturnDetail");

                entity.Property(e => e.ReturnItemId)
                    .ValueGeneratedNever()
                    .HasColumnName("ReturnItemID");

                entity.Property(e => e.Cause).HasMaxLength(200);

                entity.Property(e => e.Dsid).HasColumnName("DSID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.ReturnId).HasColumnName("ReturnID");

                entity.Property(e => e.ReturnTypeId).HasColumnName("ReturnTypeID");

                entity.HasOne(d => d.Ds)
                    .WithMany(p => p.DmsDepoReturnDetails)
                    .HasForeignKey(d => d.Dsid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_DepoReturnDetail_DMS_DepoStock");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.DmsDepoReturnDetails)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_DepoReturnDetail_SET_Product");

                entity.HasOne(d => d.Return)
                    .WithMany(p => p.DmsDepoReturnDetails)
                    .HasForeignKey(d => d.ReturnId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_DepoReturnDetail_DMS_DepoReturn");

                entity.HasOne(d => d.ReturnType)
                    .WithMany(p => p.DmsDepoReturnDetails)
                    .HasForeignKey(d => d.ReturnTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_DepoReturnDetail_ReturnType");
            });

            modelBuilder.Entity<DmsDepoReturnReceive>(entity =>
            {
                entity.ToTable("DMS_DepoReturnReceive");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.DepoId).HasColumnName("DepoID");

                entity.Property(e => e.ReceiveDate).HasColumnType("datetime");

                entity.Property(e => e.ReturnReceiveNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DmsDepoReturnReceiveDetail>(entity =>
            {
                entity.ToTable("DMS_DepoReturnReceiveDetail");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Fsid).HasColumnName("FSID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Fs)
                    .WithMany(p => p.DmsDepoReturnReceiveDetails)
                    .HasForeignKey(d => d.Fsid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_DepoReturnReceiveDetail_DMS_FactoryStock");

                entity.HasOne(d => d.ReturnReceive)
                    .WithMany(p => p.DmsDepoReturnReceiveDetails)
                    .HasForeignKey(d => d.ReturnReceiveId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_DepoReturnReceiveDetail_DMS_DepoReturnReceive");
            });

            modelBuilder.Entity<DmsDepoStock>(entity =>
            {
                entity.HasKey(e => e.Dsid)
                    .HasName("PK_DMS_DepoMedicinStock");

                entity.ToTable("DMS_DepoStock");

                entity.Property(e => e.Dsid)
                    .ValueGeneratedNever()
                    .HasColumnName("DSID");

                entity.Property(e => e.DepoId).HasColumnName("DepoID");

                entity.Property(e => e.StockDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StockType)
                    .HasDefaultValueSql("((1))")
                    .HasComment("if 1 then fresh stock if 2 then damage stock");

                entity.Property(e => e.Tp)
                    .HasColumnType("decimal(5, 3)")
                    .HasColumnName("TP");

                entity.HasOne(d => d.Depo)
                    .WithMany(p => p.DmsDepoStocks)
                    .HasForeignKey(d => d.DepoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_DepoMedicinStock_Depo");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.DmsDepoStocks)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_DepoStock_SET_Product");
            });

            modelBuilder.Entity<DmsDepoStockZeroBakup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DMS_DepoStockZeroBakup");

                entity.Property(e => e.DepoId).HasColumnName("DepoID");

                entity.Property(e => e.Dsid).HasColumnName("DSID");

                entity.Property(e => e.StockDate).HasColumnType("datetime");

                entity.Property(e => e.Tp)
                    .HasColumnType("decimal(5, 3)")
                    .HasColumnName("TP");
            });

            modelBuilder.Entity<DmsDepoToDepoChallan>(entity =>
            {
                entity.HasKey(e => e.ChallanId)
                    .HasName("PK_DepoToDepoChallan");

                entity.ToTable("DMS_DepoToDepoChallan");

                entity.Property(e => e.ChallanId)
                    .ValueGeneratedNever()
                    .HasColumnName("ChallanID");

                entity.Property(e => e.CarNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChallanById).HasColumnName("ChallanByID");

                entity.Property(e => e.ChallanDate).HasColumnType("date");

                entity.Property(e => e.ChallanNo).HasMaxLength(100);

                entity.Property(e => e.DepoId).HasColumnName("DepoID");

                entity.Property(e => e.DriverId)
                    .HasColumnName("DriverID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DriverName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MobileNo)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks).HasMaxLength(300);

                entity.Property(e => e.ToDepoId).HasColumnName("ToDepoID");

                entity.HasOne(d => d.Depo)
                    .WithMany(p => p.DmsDepoToDepoChallans)
                    .HasForeignKey(d => d.DepoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_DepoToDepoChallan_SET_Depo");

                entity.HasOne(d => d.Driver)
                    .WithMany(p => p.DmsDepoToDepoChallans)
                    .HasForeignKey(d => d.DriverId)
                    .HasConstraintName("FK_DMS_DepoToDepoChallan_HRM_PIEmployement");
            });

            modelBuilder.Entity<DmsDepoToDepoChallanItem>(entity =>
            {
                entity.HasKey(e => e.ChallanItemId)
                    .HasName("PK_DepoToDepoChallanItem");

                entity.ToTable("DMS_DepoToDepoChallanItem");

                entity.Property(e => e.ChallanItemId)
                    .ValueGeneratedNever()
                    .HasColumnName("ChallanItemID");

                entity.Property(e => e.ChallanId).HasColumnName("ChallanID");

                entity.Property(e => e.Dsid).HasColumnName("DSID");

                entity.Property(e => e.InsertUserId).HasColumnName("InsertUserID");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Challan)
                    .WithMany(p => p.DmsDepoToDepoChallanItems)
                    .HasForeignKey(d => d.ChallanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DepoToDepoChallanItem_DepoIssue");

                entity.HasOne(d => d.Ds)
                    .WithMany(p => p.DmsDepoToDepoChallanItems)
                    .HasForeignKey(d => d.Dsid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_DepoToDepoChallanItem_DMS_DepoStock");
            });

            modelBuilder.Entity<DmsDepoToDepoRequisition>(entity =>
            {
                entity.HasKey(e => e.RequisitionId)
                    .HasName("PK_DepoToDepoRequisition");

                entity.ToTable("DMS_DepoToDepoRequisition");

                entity.Property(e => e.RequisitionId)
                    .ValueGeneratedNever()
                    .HasColumnName("RequisitionID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.DepoId).HasColumnName("DepoID");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Remarks).HasMaxLength(300);

                entity.Property(e => e.RequisitionById).HasColumnName("RequisitionByID");

                entity.Property(e => e.RequisitionNo).HasMaxLength(50);

                entity.Property(e => e.ToDepoId).HasColumnName("ToDepoID");

                entity.HasOne(d => d.Depo)
                    .WithMany(p => p.DmsDepoToDepoRequisitions)
                    .HasForeignKey(d => d.DepoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_DepoToDepoRequisition_SET_Depo");
            });

            modelBuilder.Entity<DmsDepoToDepoRequisitionItem>(entity =>
            {
                entity.HasKey(e => e.RequisitionItemId);

                entity.ToTable("DMS_DepoToDepoRequisitionItem");

                entity.Property(e => e.RequisitionItemId)
                    .ValueGeneratedNever()
                    .HasColumnName("RequisitionItemID");

                entity.Property(e => e.InsertUserId).HasColumnName("InsertUserID");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.RequisitionId).HasColumnName("RequisitionID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.DmsDepoToDepoRequisitionItems)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_DepoToDepoRequisitionItem_SET_Product");

                entity.HasOne(d => d.Requisition)
                    .WithMany(p => p.DmsDepoToDepoRequisitionItems)
                    .HasForeignKey(d => d.RequisitionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_DepoToDepoRequisitionItem_DMS_DepoToDepoRequisition");
            });

            modelBuilder.Entity<DmsDmreceivedFromDepo>(entity =>
            {
                entity.HasKey(e => e.Dmrfdid);

                entity.ToTable("DMS_DMReceivedFromDepo");

                entity.Property(e => e.Dmrfdid)
                    .ValueGeneratedNever()
                    .HasColumnName("DMRFDID");

                entity.Property(e => e.DepoId).HasColumnName("DepoID");

                entity.Property(e => e.FromDepoId).HasColumnName("FromDepoID");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ReceivedById).HasColumnName("ReceivedByID");

                entity.Property(e => e.ReceivedDate).HasColumnType("datetime");

                entity.Property(e => e.ReceivedNo).HasMaxLength(50);

                entity.Property(e => e.Remarks).HasMaxLength(300);

                entity.HasOne(d => d.Depo)
                    .WithMany(p => p.DmsDmreceivedFromDepos)
                    .HasForeignKey(d => d.DepoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_DMReceivedFromDepo_Depo");
            });

            modelBuilder.Entity<DmsDmreceivedItemFromDepo>(entity =>
            {
                entity.ToTable("DMS_DMReceivedItemFromDepo");

                entity.HasIndex(e => e.ChallanItemId, "IX_DMS_DMReceivedItemFromDepo")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ChallanItemId).HasColumnName("ChallanItemID");

                entity.Property(e => e.Dmrfdid).HasColumnName("DMRFDID");

                entity.Property(e => e.Dsid).HasColumnName("DSID");

                entity.Property(e => e.InsertUserId).HasColumnName("InsertUserID");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.ChallanItem)
                    .WithOne(p => p.DmsDmreceivedItemFromDepo)
                    .HasForeignKey<DmsDmreceivedItemFromDepo>(d => d.ChallanItemId)
                    .HasConstraintName("FK_DMS_DMReceivedItemFromDepo_DMS_DepoToDepoChallanItem");

                entity.HasOne(d => d.Dmrfd)
                    .WithMany(p => p.DmsDmreceivedItemFromDepos)
                    .HasForeignKey(d => d.Dmrfdid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_DMReceivedItemFromDepo_DMS_DMReceivedFromDepo");
            });

            modelBuilder.Entity<DmsDmreceivedItemFromFactory>(entity =>
            {
                entity.HasKey(e => e.DmritemFfid);

                entity.ToTable("DMS_DMReceivedItemFromFactory");

                entity.HasIndex(e => e.ChallanDetailId, "IX_DMS_DMReceivedItemFromFactory")
                    .IsUnique();

                entity.Property(e => e.DmritemFfid)
                    .ValueGeneratedNever()
                    .HasColumnName("DMRItemFFID");

                entity.Property(e => e.ChallanDetailId).HasColumnName("ChallanDetailID");

                entity.Property(e => e.Dmrffid).HasColumnName("DMRFFID");

                entity.Property(e => e.Dsid).HasColumnName("DSID");

                entity.Property(e => e.InsertUserId).HasColumnName("InsertUserID");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.ChallanDetail)
                    .WithOne(p => p.DmsDmreceivedItemFromFactory)
                    .HasForeignKey<DmsDmreceivedItemFromFactory>(d => d.ChallanDetailId)
                    .HasConstraintName("FK_DMS_DMReceivedItemFromFactory_DMS_FactoryChallanDetail");

                entity.HasOne(d => d.Dmrff)
                    .WithMany(p => p.DmsDmreceivedItemFromFactories)
                    .HasForeignKey(d => d.Dmrffid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_DMReceivedItemFromFactory_DMS_DMRecevedFromFactory");
            });

            modelBuilder.Entity<DmsDmreceivedItemFromFactoryWithBarcode>(entity =>
            {
                entity.ToTable("DMS_DMReceivedItemFromFactoryWithBarcode");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.DmritemFfid).HasColumnName("DMRItemFFID");

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.Fcdwbc).HasColumnName("FCDWBC");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Pdate)
                    .HasColumnType("date")
                    .HasColumnName("PDate");

                entity.Property(e => e.Weight).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.WorkerId).HasColumnName("WorkerID");
            });

            modelBuilder.Entity<DmsDmrecevedFromFactory>(entity =>
            {
                entity.HasKey(e => e.Dmrffid);

                entity.ToTable("DMS_DMRecevedFromFactory");

                entity.Property(e => e.Dmrffid)
                    .ValueGeneratedNever()
                    .HasColumnName("DMRFFID");

                entity.Property(e => e.DepoId).HasColumnName("DepoID");

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ReceivedById).HasColumnName("ReceivedByID");

                entity.Property(e => e.ReceivedDate).HasColumnType("datetime");

                entity.Property(e => e.ReceivedNo).HasMaxLength(50);

                entity.Property(e => e.Remarks).HasMaxLength(300);

                entity.HasOne(d => d.Depo)
                    .WithMany(p => p.DmsDmrecevedFromFactories)
                    .HasForeignKey(d => d.DepoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMRecevedFromFactory_Depo");
            });

            modelBuilder.Entity<DmsFactoryChallan>(entity =>
            {
                entity.HasKey(e => e.ChallanId)
                    .HasName("PK_DMS_FactoryInvoice");

                entity.ToTable("DMS_FactoryChallan");

                entity.Property(e => e.ChallanId)
                    .ValueGeneratedNever()
                    .HasColumnName("ChallanID");

                entity.Property(e => e.CarNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChalanById).HasColumnName("ChalanByID");

                entity.Property(e => e.ChallanDate).HasColumnType("date");

                entity.Property(e => e.ChallanNo).HasMaxLength(50);

                entity.Property(e => e.DepoId).HasColumnName("DepoID");

                entity.Property(e => e.DriverId)
                    .HasColumnName("DriverID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DriverName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.FirstWeight).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.IndentationId).HasColumnName("IndentationID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.LockNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNo)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.OthersWeight).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Remarks).HasMaxLength(300);

                entity.Property(e => e.SecondWeight).HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.Depo)
                    .WithMany(p => p.DmsFactoryChallans)
                    .HasForeignKey(d => d.DepoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_FactoryInvoice_SET_Depo");

                entity.HasOne(d => d.Driver)
                    .WithMany(p => p.DmsFactoryChallans)
                    .HasForeignKey(d => d.DriverId)
                    .HasConstraintName("FK_DMS_FactoryChallan_HRM_PIEmployement");
            });

            modelBuilder.Entity<DmsFactoryChallanBarcodeTemp>(entity =>
            {
                entity.ToTable("DMS_FactoryChallanBarcodeTemp");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Day).HasDefaultValueSql("(datepart(day,getdate()))");

                entity.Property(e => e.DepoId).HasColumnName("DepoID");

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.Fpbcid).HasColumnName("FPBCID");

                entity.Property(e => e.Frdwbcid).HasColumnName("FRDWBCID");

                entity.Property(e => e.Lastupdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Month).HasDefaultValueSql("(datepart(month,getdate()))");

                entity.Property(e => e.PrductId).HasColumnName("PrductID");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Weight).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.WorkerId).HasColumnName("WorkerID");

                entity.Property(e => e.WorkerName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Year).HasDefaultValueSql("(datepart(year,getdate()))");
            });

            modelBuilder.Entity<DmsFactoryChallanDetail>(entity =>
            {
                entity.HasKey(e => e.ChallanDetailId)
                    .HasName("PK_DMS_FactoryInvoiceDetail");

                entity.ToTable("DMS_FactoryChallanDetail");

                entity.Property(e => e.ChallanDetailId)
                    .ValueGeneratedNever()
                    .HasColumnName("ChallanDetailID");

                entity.Property(e => e.Asid).HasColumnName("ASID");

                entity.Property(e => e.ChallanId).HasColumnName("ChallanID");

                entity.Property(e => e.InsertUserId).HasColumnName("InsertUserID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.As)
                    .WithMany(p => p.DmsFactoryChallanDetails)
                    .HasForeignKey(d => d.Asid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_FactoryChallanDetail_DMS_FactoryStock");

                entity.HasOne(d => d.Challan)
                    .WithMany(p => p.DmsFactoryChallanDetails)
                    .HasForeignKey(d => d.ChallanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_FactoryInvoiceDetail_DMS_FactoryInvoice");
            });

            modelBuilder.Entity<DmsFactoryChallanDetialsWithBarcode>(entity =>
            {
                entity.ToTable("DMS_FactoryChallanDetialsWithBarcode");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ChallanDetailId).HasColumnName("ChallanDetailID");

                entity.Property(e => e.ChallanNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.DepoId).HasColumnName("DepoID");

                entity.Property(e => e.Dwsl).HasColumnName("DWSL");

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.Frdwbcid).HasColumnName("FRDWBCID");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Weight).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.WorkerId).HasColumnName("WorkerID");

                entity.HasOne(d => d.Factory)
                    .WithMany(p => p.DmsFactoryChallanDetialsWithBarcodes)
                    .HasForeignKey(d => d.FactoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_FactoryChallanDetialsWithBarcode_SET_Factory");
            });

            modelBuilder.Entity<DmsFactoryOpeningStock>(entity =>
            {
                entity.ToTable("DMS_FactoryOpeningStock");

                entity.HasIndex(e => new { e.FactoryId, e.ProductId }, "IX_DMS_FactoryOpeningStock")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.Fsid).HasColumnName("FSID");

                entity.Property(e => e.InsertUserId).HasColumnName("InsertUserID");

                entity.HasOne(d => d.Fs)
                    .WithMany(p => p.DmsFactoryOpeningStocks)
                    .HasForeignKey(d => d.Fsid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_FactoryOpeningStock_DMS_FactoryStock");
            });

            modelBuilder.Entity<DmsFactoryProductionAllocation>(entity =>
            {
                entity.ToTable("DMS_FactoryProductionAllocation");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Remarks).HasMaxLength(300);

                entity.Property(e => e.Smid).HasColumnName("SMId");
            });

            modelBuilder.Entity<DmsFactoryProductionBarcode>(entity =>
            {
                entity.ToTable("DMS_FactoryProductionBarcode");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.BandRollBoxNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Barcode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Bmwcode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("BMWCode");

                entity.Property(e => e.CartonNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CheckerCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CheckerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.FactoryCode)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.FactoryName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Lastupdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Month).HasDefaultValueSql("(datepart(month,getdate()))");

                entity.Property(e => e.Pcno).HasColumnName("PCNo");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Ptype)
                    .HasColumnName("PType")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SdreceiveStatus).HasColumnName("SDReceiveStatus");

                entity.Property(e => e.UploadTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Weight).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.WorkerCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WorkerId).HasColumnName("WorkerID");

                entity.Property(e => e.WorkerName).HasMaxLength(200);

                entity.Property(e => e.Year).HasDefaultValueSql("(datepart(year,getdate()))");
            });

            modelBuilder.Entity<DmsFactoryProductionBarcode2022>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DMS_FactoryProductionBarcode2022");

                entity.Property(e => e.BandRollBoxNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Barcode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Bmwcode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("BMWCode");

                entity.Property(e => e.CartonNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CheckerCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CheckerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.FactoryCode)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.FactoryName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Lastupdate).HasColumnType("datetime");

                entity.Property(e => e.Pcno).HasColumnName("PCNo");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Ptype).HasColumnName("PType");

                entity.Property(e => e.SdreceiveStatus).HasColumnName("SDReceiveStatus");

                entity.Property(e => e.UploadTime).HasColumnType("datetime");

                entity.Property(e => e.Weight).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.WorkerCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WorkerId).HasColumnName("WorkerID");

                entity.Property(e => e.WorkerName).HasMaxLength(200);
            });

            modelBuilder.Entity<DmsFactoryProductionBarcode2023>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DMS_FactoryProductionBarcode2023");

                entity.Property(e => e.BandRollBoxNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Barcode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Bmwcode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("BMWCode");

                entity.Property(e => e.CartonNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CheckerCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CheckerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.FactoryCode)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.FactoryName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Lastupdate).HasColumnType("datetime");

                entity.Property(e => e.Pcno).HasColumnName("PCNo");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Ptype).HasColumnName("PType");

                entity.Property(e => e.SdreceiveStatus).HasColumnName("SDReceiveStatus");

                entity.Property(e => e.UploadTime).HasColumnType("datetime");

                entity.Property(e => e.Weight).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.WorkerCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WorkerId).HasColumnName("WorkerID");

                entity.Property(e => e.WorkerName).HasMaxLength(200);
            });

            modelBuilder.Entity<DmsFactoryReceive>(entity =>
            {
                entity.HasKey(e => e.Fsrid)
                    .HasName("PK_DMS_FactoryMedicineReceive");

                entity.ToTable("DMS_FactoryReceive");

                entity.Property(e => e.Fsrid)
                    .ValueGeneratedNever()
                    .HasColumnName("FSRID");

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.Fsid).HasColumnName("FSID");

                entity.Property(e => e.ReceiveById).HasColumnName("ReceiveByID");

                entity.Property(e => e.ReceiveDate).HasColumnType("datetime");

                entity.HasOne(d => d.Factory)
                    .WithMany(p => p.DmsFactoryReceives)
                    .HasForeignKey(d => d.FactoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_FactoryMedicineReceive_Factory");

                entity.HasOne(d => d.Fs)
                    .WithMany(p => p.DmsFactoryReceives)
                    .HasForeignKey(d => d.Fsid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_FactoryReceive_DMS_FactoryStock");
            });

            modelBuilder.Entity<DmsFactoryReceiveDetialsWithBarcode>(entity =>
            {
                entity.ToTable("DMS_FactoryReceiveDetialsWithBarcode");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.Fpbcid).HasColumnName("FPBCID");

                entity.Property(e => e.Fsrid).HasColumnName("FSRID");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Weight).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.WorkerId).HasColumnName("WorkerID");
            });

            modelBuilder.Entity<DmsFactoryStock>(entity =>
            {
                entity.HasKey(e => e.Fsid)
                    .HasName("PK_DMS_FactoryMedicineStock");

                entity.ToTable("DMS_FactoryStock");

                entity.Property(e => e.Fsid)
                    .ValueGeneratedNever()
                    .HasColumnName("FSID");

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.StockDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StockType)
                    .HasDefaultValueSql("((1))")
                    .HasComment("if 1 then fresh stock if 2 then damage stock");

                entity.Property(e => e.Tp)
                    .HasColumnType("decimal(5, 3)")
                    .HasColumnName("TP");

                entity.HasOne(d => d.Factory)
                    .WithMany(p => p.DmsFactoryStocks)
                    .HasForeignKey(d => d.FactoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_FactoryMedicineStock_Factory");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.DmsFactoryStocks)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_FactoryStock_SET_Product");
            });

            modelBuilder.Entity<DmsImageCapture>(entity =>
            {
                entity.ToTable("DMS_ImageCapture");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CaptureDate).HasColumnType("datetime");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.ImageName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ImageUrl).HasMaxLength(200);

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ImageType)
                    .WithMany(p => p.DmsImageCaptures)
                    .HasForeignKey(d => d.ImageTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_ImageCapture_DMS_ImageCaptureType");
            });

            modelBuilder.Entity<DmsImageCaptureType>(entity =>
            {
                entity.HasKey(e => e.ImageTypeId);

                entity.ToTable("DMS_ImageCaptureType");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.TypeName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DmsIncentiveDetail>(entity =>
            {
                entity.ToTable("DMS_IncentiveDetail");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.IncentiveId).HasColumnName("IncentiveID");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Incentive)
                    .WithMany(p => p.DmsIncentiveDetails)
                    .HasForeignKey(d => d.IncentiveId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IncentiveDetail_DMS_IncentiveMaster");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.DmsIncentiveDetails)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_IncentiveDetail_SET_Product");
            });

            modelBuilder.Entity<DmsIncentiveMaster>(entity =>
            {
                entity.HasKey(e => e.IncentiveId)
                    .HasName("PK_IncentiveMaster");

                entity.ToTable("DMS_IncentiveMaster");

                entity.Property(e => e.IncentiveId)
                    .ValueGeneratedNever()
                    .HasColumnName("IncentiveID");

                entity.Property(e => e.ChallanId).HasColumnName("ChallanID");

                entity.Property(e => e.EmployeementId).HasColumnName("EmployeementID");

                entity.Property(e => e.IncentiveDate).HasColumnType("date");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Employeement)
                    .WithMany(p => p.DmsIncentiveMasters)
                    .HasForeignKey(d => d.EmployeementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_IncentiveMaster_HRM_PIEmployement");
            });

            modelBuilder.Entity<DmsIncentivePointValue>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DMS_IncentivePointValue");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.EmployementId).HasColumnName("EmployementID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IncentiveId).HasColumnName("IncentiveID");

                entity.Property(e => e.Lastupdate).HasColumnType("datetime");
            });

            modelBuilder.Entity<DmsMemoType>(entity =>
            {
                entity.ToTable("DMS_MemoType");

                entity.HasIndex(e => e.Name, "IX_MemoType")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<DmsMixerProductionBarcode>(entity =>
            {
                entity.ToTable("DMS_MixerProductionBarcode");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BostaNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.DtransferStatus).HasColumnName("DTransferStatus");

                entity.Property(e => e.FactoryCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FactoryDivisionCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.FactoryName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Lastupdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Pcno).HasColumnName("PCNo");

                entity.Property(e => e.Weight).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.WorkerCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WorkerId).HasColumnName("WorkerID");

                entity.Property(e => e.WorkerName)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DmsNapkinAreaOpeningStock>(entity =>
            {
                entity.ToTable("DMS_NapkinAreaOpeningStock");

                entity.HasIndex(e => new { e.AreaId, e.ProductId }, "IX_DMS_NapkinAreaOpeningStock")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.Asid).HasColumnName("ASID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("InsertUserID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.As)
                    .WithMany(p => p.DmsNapkinAreaOpeningStocks)
                    .HasForeignKey(d => d.Asid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_NapkinAreaOpeningStock_DMS_NapkinAreaStock");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.DmsNapkinAreaOpeningStocks)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_NapkinAreaOpeningStock_SET_NapkinProduct");
            });

            modelBuilder.Entity<DmsNapkinAreaReceived>(entity =>
            {
                entity.HasKey(e => e.AreaRffid);

                entity.ToTable("DMS_NapkinAreaReceived");

                entity.HasIndex(e => e.ReceivedNo, "IX_DMS_NapkinAreaReceived")
                    .IsUnique();

                entity.Property(e => e.AreaRffid)
                    .ValueGeneratedNever()
                    .HasColumnName("AreaRFFID");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.LastUpdate).HasColumnType("date");

                entity.Property(e => e.ReceivedById).HasColumnName("ReceivedByID");

                entity.Property(e => e.ReceivedDate).HasColumnType("date");

                entity.Property(e => e.ReceivedNo).HasMaxLength(50);

                entity.Property(e => e.Remarks).HasMaxLength(300);
            });

            modelBuilder.Entity<DmsNapkinAreaReceivedItem>(entity =>
            {
                entity.HasKey(e => e.AreaReceiveItemId);

                entity.ToTable("DMS_NapkinAreaReceivedItem");

                entity.Property(e => e.AreaReceiveItemId)
                    .ValueGeneratedNever()
                    .HasColumnName("AreaReceiveItemID");

                entity.Property(e => e.AreaReceiveId).HasColumnName("AreaReceiveID");

                entity.Property(e => e.Asid).HasColumnName("ASID");

                entity.Property(e => e.DepoChallanItemId).HasColumnName("DepoChallanItemID");

                entity.Property(e => e.InsertUserId).HasColumnName("InsertUserID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.AreaReceive)
                    .WithMany(p => p.DmsNapkinAreaReceivedItems)
                    .HasForeignKey(d => d.AreaReceiveId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_NapkinAreaReceivedItem_DMS_NapkinAreaReceived");

                entity.HasOne(d => d.As)
                    .WithMany(p => p.DmsNapkinAreaReceivedItems)
                    .HasForeignKey(d => d.Asid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_NapkinAreaReceivedItem_DMS_NapkinAreaStock");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.DmsNapkinAreaReceivedItems)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_NapkinAreaReceivedItem_SET_NapkinProduct");
            });

            modelBuilder.Entity<DmsNapkinAreaReturn>(entity =>
            {
                entity.HasKey(e => e.ReturnId);

                entity.ToTable("DMS_NapkinAreaReturn");

                entity.Property(e => e.ReturnId)
                    .ValueGeneratedNever()
                    .HasColumnName("ReturnID");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.DeliveryManId).HasColumnName("DeliveryManID");

                entity.Property(e => e.DepoId).HasColumnName("DepoID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.ReturnDate).HasColumnType("date");

                entity.Property(e => e.ReturnTypeId).HasColumnName("ReturnTypeID");

                entity.HasOne(d => d.ReturnType)
                    .WithMany(p => p.DmsNapkinAreaReturns)
                    .HasForeignKey(d => d.ReturnTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_NapkinAreaReturn_DMS_NapkinReturnType");
            });

            modelBuilder.Entity<DmsNapkinAreaReturnDetail>(entity =>
            {
                entity.HasKey(e => e.ReturnItemId);

                entity.ToTable("DMS_NapkinAreaReturnDetail");

                entity.Property(e => e.ReturnItemId)
                    .ValueGeneratedNever()
                    .HasColumnName("ReturnItemID");

                entity.Property(e => e.Asid).HasColumnName("ASID");

                entity.Property(e => e.Cause).HasMaxLength(200);

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.ReturnId).HasColumnName("ReturnID");

                entity.Property(e => e.ReturnTypeId).HasColumnName("ReturnTypeID");

                entity.HasOne(d => d.As)
                    .WithMany(p => p.DmsNapkinAreaReturnDetails)
                    .HasForeignKey(d => d.Asid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_NapkinAreaReturnDetail_DMS_NapkinAreaStock");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.DmsNapkinAreaReturnDetails)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_NapkinAreaReturnDetail_SET_NapkinProduct");

                entity.HasOne(d => d.Return)
                    .WithMany(p => p.DmsNapkinAreaReturnDetails)
                    .HasForeignKey(d => d.ReturnId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_NapkinAreaReturnDetail_DMS_NapkinAreaReturn");

                entity.HasOne(d => d.ReturnType)
                    .WithMany(p => p.DmsNapkinAreaReturnDetails)
                    .HasForeignKey(d => d.ReturnTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_NapkinAreaReturnDetail_NapkinReturnType");
            });

            modelBuilder.Entity<DmsNapkinAreaReturnReceive>(entity =>
            {
                entity.ToTable("DMS_NapkinAreaReturnReceive");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.ReceiveDate).HasColumnType("datetime");

                entity.Property(e => e.ReturnReceiveNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DmsNapkinAreaReturnReceiveDetail>(entity =>
            {
                entity.ToTable("DMS_NapkinAreaReturnReceiveDetail");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Dsid).HasColumnName("DSID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Ds)
                    .WithMany(p => p.DmsNapkinAreaReturnReceiveDetails)
                    .HasForeignKey(d => d.Dsid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_NapkinAreaReturnReceiveDetail_DMS_NapkinDepoStock");

                entity.HasOne(d => d.ReturnReceive)
                    .WithMany(p => p.DmsNapkinAreaReturnReceiveDetails)
                    .HasForeignKey(d => d.ReturnReceiveId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_NapkinAreaReturnReceiveDetail_DMS_NapkinAreaReturnReceive");
            });

            modelBuilder.Entity<DmsNapkinAreaStock>(entity =>
            {
                entity.HasKey(e => e.Asid);

                entity.ToTable("DMS_NapkinAreaStock");

                entity.Property(e => e.Asid)
                    .ValueGeneratedNever()
                    .HasColumnName("ASID");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.StockDate).HasColumnType("datetime");

                entity.Property(e => e.Tp)
                    .HasColumnType("decimal(5, 3)")
                    .HasColumnName("TP");

                entity.Property(e => e.TransactionDate).HasColumnType("date");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.DmsNapkinAreaStocks)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_NapkinAreaStock_SET_NapkinProduct");
            });

            modelBuilder.Entity<DmsNapkinAreaStockUpdateProDatum>(entity =>
            {
                entity.ToTable("DMS_NapkinAreaStock_UpdateProData");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.Asid).HasColumnName("ASID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.StockDate).HasColumnType("datetime");

                entity.Property(e => e.Tp)
                    .HasColumnType("decimal(5, 3)")
                    .HasColumnName("TP");

                entity.Property(e => e.TransactionDate).HasColumnType("date");
            });

            modelBuilder.Entity<DmsNapkinAreaStockUpdateSalesDatum>(entity =>
            {
                entity.ToTable("DMS_NapkinAreaStock_UpdateSalesData");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.Asid).HasColumnName("ASID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.StockDate).HasColumnType("datetime");

                entity.Property(e => e.Tp)
                    .HasColumnType("decimal(5, 3)")
                    .HasColumnName("TP");

                entity.Property(e => e.TransactionDate).HasColumnType("date");
            });

            modelBuilder.Entity<DmsNapkinDepoChallan>(entity =>
            {
                entity.HasKey(e => e.ChallanId);

                entity.ToTable("DMS_NapkinDepoChallan");

                entity.Property(e => e.ChallanId)
                    .ValueGeneratedNever()
                    .HasColumnName("ChallanID");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.CarNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChallanById).HasColumnName("ChallanByID");

                entity.Property(e => e.ChallanDate).HasColumnType("date");

                entity.Property(e => e.ChallanNo).HasMaxLength(100);

                entity.Property(e => e.DepoId).HasColumnName("DepoID");

                entity.Property(e => e.DriverId).HasColumnName("DriverID");

                entity.Property(e => e.DriverName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.MobileNo)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks).HasMaxLength(300);
            });

            modelBuilder.Entity<DmsNapkinDepoChallanItem>(entity =>
            {
                entity.HasKey(e => e.ChallanItemId);

                entity.ToTable("DMS_NapkinDepoChallanItem");

                entity.Property(e => e.ChallanItemId)
                    .ValueGeneratedNever()
                    .HasColumnName("ChallanItemID");

                entity.Property(e => e.ChallanId).HasColumnName("ChallanID");

                entity.Property(e => e.Dsid).HasColumnName("DSID");

                entity.Property(e => e.InsertUserId).HasColumnName("InsertUserID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Challan)
                    .WithMany(p => p.DmsNapkinDepoChallanItems)
                    .HasForeignKey(d => d.ChallanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_NapkinDepoChallanItem_DMS_NapkinDepoChallan");

                entity.HasOne(d => d.Ds)
                    .WithMany(p => p.DmsNapkinDepoChallanItems)
                    .HasForeignKey(d => d.Dsid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_NapkinDepoChallanItem_DMS_NapkinDepoStock");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.DmsNapkinDepoChallanItems)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_NapkinDepoChallanItem_SET_NapkinProduct");
            });

            modelBuilder.Entity<DmsNapkinDepoOpeningStock>(entity =>
            {
                entity.ToTable("DMS_NapkinDepoOpeningStock");

                entity.HasIndex(e => new { e.DepoId, e.ProductId }, "IX_DMS_NapkinDepoOpeningStock")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DepoId).HasColumnName("DepoID");

                entity.Property(e => e.Dsid).HasColumnName("DSID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Ds)
                    .WithMany(p => p.DmsNapkinDepoOpeningStocks)
                    .HasForeignKey(d => d.Dsid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_NapkinDepoOpeningStock_DMS_NapkinDepoStock");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.DmsNapkinDepoOpeningStocks)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_NapkinDepoOpeningStock_SET_NapkinProduct");
            });

            modelBuilder.Entity<DmsNapkinDepoStock>(entity =>
            {
                entity.HasKey(e => e.Dsid);

                entity.ToTable("DMS_NapkinDepoStock");

                entity.Property(e => e.Dsid)
                    .ValueGeneratedNever()
                    .HasColumnName("DSID");

                entity.Property(e => e.DepoId).HasColumnName("DepoID");

                entity.Property(e => e.StockDate).HasColumnType("datetime");

                entity.Property(e => e.Tp)
                    .HasColumnType("decimal(5, 3)")
                    .HasColumnName("TP");
            });

            modelBuilder.Entity<DmsNapkinDepoToDepoTransfer>(entity =>
            {
                entity.HasKey(e => e.TransferId);

                entity.ToTable("DMS_NapkinDepoToDepoTransfer");

                entity.Property(e => e.TransferId)
                    .ValueGeneratedNever()
                    .HasColumnName("TransferID");

                entity.Property(e => e.CarNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryManId).HasColumnName("DeliveryManID");

                entity.Property(e => e.DriverId).HasColumnName("DriverID");

                entity.Property(e => e.DriverMobileNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DriverName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.ReceiverDepoId).HasColumnName("ReceiverDepoID");

                entity.Property(e => e.SenderDepoId).HasColumnName("SenderDepoID");

                entity.Property(e => e.TransferDate).HasColumnType("date");
            });

            modelBuilder.Entity<DmsNapkinDepoToDepoTransferDetail>(entity =>
            {
                entity.HasKey(e => e.TransferItemId);

                entity.ToTable("DMS_NapkinDepoToDepoTransferDetails");

                entity.Property(e => e.TransferItemId)
                    .ValueGeneratedNever()
                    .HasColumnName("TransferItemID");

                entity.Property(e => e.Cause).HasMaxLength(200);

                entity.Property(e => e.Dsid).HasColumnName("DSID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.TransferId).HasColumnName("TransferID");

                entity.HasOne(d => d.Ds)
                    .WithMany(p => p.DmsNapkinDepoToDepoTransferDetails)
                    .HasForeignKey(d => d.Dsid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_NapkinDepoToDepoTransferDetails_DMS_NapkinDepoStock");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.DmsNapkinDepoToDepoTransferDetails)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_NapkinDepoToDepoTransferDetails_SET_NapkinProduct");

                entity.HasOne(d => d.Transfer)
                    .WithMany(p => p.DmsNapkinDepoToDepoTransferDetails)
                    .HasForeignKey(d => d.TransferId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_NapkinDepoToDepoTransferDetails_DMS_NapkinDepoToDepoTransfer");
            });

            modelBuilder.Entity<DmsNapkinDepoToDepoTransferReceive>(entity =>
            {
                entity.ToTable("DMS_NapkinDepoToDepoTransferReceive");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.ReceiveDate).HasColumnType("date");

                entity.Property(e => e.SenderDepoId).HasColumnName("SenderDepoID");

                entity.Property(e => e.TransferReceiveNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DmsNapkinDepoToDepoTransferReceiveDetail>(entity =>
            {
                entity.ToTable("DMS_NapkinDepoToDepoTransferReceiveDetail");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Dsid).HasColumnName("DSID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Ds)
                    .WithMany(p => p.DmsNapkinDepoToDepoTransferReceiveDetails)
                    .HasForeignKey(d => d.Dsid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_NapkinDepoToDepoTransferReceiveDetail_DMS_NapkinDepoStock");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.DmsNapkinDepoToDepoTransferReceiveDetails)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_NapkinDepoToDepoTransferReceiveDetail_SET_NapkinProduct");

                entity.HasOne(d => d.TransferReceive)
                    .WithMany(p => p.DmsNapkinDepoToDepoTransferReceiveDetails)
                    .HasForeignKey(d => d.TransferReceiveId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_NapkinDepoToDepoTransferReceiveDetail_DMS_NapkinDepoToDepoTransferReceive");
            });

            modelBuilder.Entity<DmsNapkinDmreceivedItemFromFactory>(entity =>
            {
                entity.HasKey(e => e.DmritemFfid);

                entity.ToTable("DMS_NapkinDMReceivedItemFromFactory");

                entity.Property(e => e.DmritemFfid)
                    .ValueGeneratedNever()
                    .HasColumnName("DMRItemFFID");

                entity.Property(e => e.ChallanDetailId).HasColumnName("ChallanDetailID");

                entity.Property(e => e.Dmrffid).HasColumnName("DMRFFID");

                entity.Property(e => e.Dsid).HasColumnName("DSID");

                entity.Property(e => e.InsertUserId).HasColumnName("InsertUserID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.ChallanDetail)
                    .WithMany(p => p.DmsNapkinDmreceivedItemFromFactories)
                    .HasForeignKey(d => d.ChallanDetailId)
                    .HasConstraintName("FK_DMS_NapkinDMReceivedItemFromFactory_DMS_NapkinFactoryChallanDetail");

                entity.HasOne(d => d.Dmrff)
                    .WithMany(p => p.DmsNapkinDmreceivedItemFromFactories)
                    .HasForeignKey(d => d.Dmrffid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_NapkinDMReceivedItemFromFactory_DMS_NapkinDMRecevedFromFactory");

                entity.HasOne(d => d.Ds)
                    .WithMany(p => p.DmsNapkinDmreceivedItemFromFactories)
                    .HasForeignKey(d => d.Dsid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_NapkinDMReceivedItemFromFactory_DMS_NapkinDepoStock");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.DmsNapkinDmreceivedItemFromFactories)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_NapkinDMReceivedItemFromFactory_SET_NapkinProduct");
            });

            modelBuilder.Entity<DmsNapkinDmrecevedFromFactory>(entity =>
            {
                entity.HasKey(e => e.Dmrffid);

                entity.ToTable("DMS_NapkinDMRecevedFromFactory");

                entity.HasIndex(e => e.ReceivedNo, "IX_DMS_NapkinDMRecevedFromFactory")
                    .IsUnique();

                entity.Property(e => e.Dmrffid)
                    .ValueGeneratedNever()
                    .HasColumnName("DMRFFID");

                entity.Property(e => e.DepoId).HasColumnName("DepoID");

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.ReceivedById).HasColumnName("ReceivedByID");

                entity.Property(e => e.ReceivedDate).HasColumnType("datetime");

                entity.Property(e => e.ReceivedNo).HasMaxLength(50);

                entity.Property(e => e.Remarks).HasMaxLength(300);
            });

            modelBuilder.Entity<DmsNapkinFactoryChallan>(entity =>
            {
                entity.HasKey(e => e.ChallanId);

                entity.ToTable("DMS_NapkinFactoryChallan");

                entity.HasIndex(e => e.ChallanNo, "IX_DMS_NapkinFactoryChallan")
                    .IsUnique();

                entity.Property(e => e.ChallanId)
                    .ValueGeneratedNever()
                    .HasColumnName("ChallanID");

                entity.Property(e => e.CarNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChalanById).HasColumnName("ChalanByID");

                entity.Property(e => e.ChallanDate).HasColumnType("date");

                entity.Property(e => e.ChallanNo).HasMaxLength(50);

                entity.Property(e => e.DepoId).HasColumnName("DepoID");

                entity.Property(e => e.DriverId).HasColumnName("DriverID");

                entity.Property(e => e.DriverName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.IndentationId).HasColumnName("IndentationID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.MobileNo)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks).HasMaxLength(300);
            });

            modelBuilder.Entity<DmsNapkinFactoryChallanDetail>(entity =>
            {
                entity.HasKey(e => e.ChallanDetailId);

                entity.ToTable("DMS_NapkinFactoryChallanDetail");

                entity.Property(e => e.ChallanDetailId)
                    .ValueGeneratedNever()
                    .HasColumnName("ChallanDetailID");

                entity.Property(e => e.Asid).HasColumnName("ASID");

                entity.Property(e => e.ChallanId).HasColumnName("ChallanID");

                entity.Property(e => e.InsertUserId).HasColumnName("InsertUserID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.As)
                    .WithMany(p => p.DmsNapkinFactoryChallanDetails)
                    .HasForeignKey(d => d.Asid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_NapkinFactoryChallanDetail_DMS_NapkinFactoryStock");

                entity.HasOne(d => d.Challan)
                    .WithMany(p => p.DmsNapkinFactoryChallanDetails)
                    .HasForeignKey(d => d.ChallanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_NapkinFactoryChallanDetail_DMS_NapkinFactoryChallan");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.DmsNapkinFactoryChallanDetails)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_NapkinFactoryChallanDetail_SET_NapkinProduct");
            });

            modelBuilder.Entity<DmsNapkinFactoryOpeningStock>(entity =>
            {
                entity.ToTable("DMS_NapkinFactoryOpeningStock");

                entity.HasIndex(e => new { e.FactoryId, e.ProductId }, "IX_DMS_NapkinFactoryOpeningStock")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.Fsid).HasColumnName("FSID");

                entity.Property(e => e.InsertUserId).HasColumnName("InsertUserID");

                entity.HasOne(d => d.Fs)
                    .WithMany(p => p.DmsNapkinFactoryOpeningStocks)
                    .HasForeignKey(d => d.Fsid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_NapkinFactoryOpeningStock_DMS_NapkinFactoryStock");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.DmsNapkinFactoryOpeningStocks)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_NapkinFactoryOpeningStock_SET_NapkinProduct");
            });

            modelBuilder.Entity<DmsNapkinFactoryProductionAllocation>(entity =>
            {
                entity.ToTable("DMS_NapkinFactoryProductionAllocation");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Remarks).HasMaxLength(300);

                entity.Property(e => e.Smid).HasColumnName("SMId");
            });

            modelBuilder.Entity<DmsNapkinFactoryReceive>(entity =>
            {
                entity.HasKey(e => e.Fsrid)
                    .HasName("PK_DMS_NapkinFactoryMedicineReceive");

                entity.ToTable("DMS_NapkinFactoryReceive");

                entity.Property(e => e.Fsrid)
                    .ValueGeneratedNever()
                    .HasColumnName("FSRID");

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.Fsid).HasColumnName("FSID");

                entity.Property(e => e.ReceiveById).HasColumnName("ReceiveByID");

                entity.Property(e => e.ReceiveDate).HasColumnType("datetime");

                entity.HasOne(d => d.Factory)
                    .WithMany(p => p.DmsNapkinFactoryReceives)
                    .HasForeignKey(d => d.FactoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_NapkinFactoryMedicineReceive_Factory");

                entity.HasOne(d => d.Fs)
                    .WithMany(p => p.DmsNapkinFactoryReceives)
                    .HasForeignKey(d => d.Fsid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_NapkinFactoryReceive_DMS_NapkinFactoryStock");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.DmsNapkinFactoryReceives)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_NapkinFactoryReceive_SET_NapkinProduct");
            });

            modelBuilder.Entity<DmsNapkinFactoryStock>(entity =>
            {
                entity.HasKey(e => e.Fsid)
                    .HasName("PK_DMS_NapkinFactoryMedicineStock");

                entity.ToTable("DMS_NapkinFactoryStock");

                entity.Property(e => e.Fsid)
                    .ValueGeneratedNever()
                    .HasColumnName("FSID");

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StockDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StockType)
                    .HasDefaultValueSql("((1))")
                    .HasComment("if 1 then fresh stock if 2 then damage stock");

                entity.Property(e => e.Tp)
                    .HasColumnType("decimal(5, 3)")
                    .HasColumnName("TP");

                entity.HasOne(d => d.Factory)
                    .WithMany(p => p.DmsNapkinFactoryStocks)
                    .HasForeignKey(d => d.FactoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_NapkinFactoryMedicineStock_Factory");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.DmsNapkinFactoryStocks)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_NapkinFactoryStock_SET_NapkinProduct");
            });

            modelBuilder.Entity<DmsNapkinReturnType>(entity =>
            {
                entity.HasKey(e => e.ReturnTypeId);

                entity.ToTable("DMS_NapkinReturnType");

                entity.Property(e => e.ReturnTypeId).HasColumnName("ReturnTypeID");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ReturnType)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DmsOrder>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK_Orders");

                entity.ToTable("DMS_Orders");

                entity.HasIndex(e => new { e.EmployeementId, e.OutletId, e.ChallanId, e.OrderDate, e.OrderTime }, "IX_DMS_Orders")
                    .IsUnique();

                entity.Property(e => e.OrderId)
                    .ValueGeneratedNever()
                    .HasColumnName("OrderID");

                entity.Property(e => e.ChallanId).HasColumnName("ChallanID");

                entity.Property(e => e.EmployeementId).HasColumnName("EmployeementID");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OrderDate).HasColumnType("date");

                entity.Property(e => e.OrderTime)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.OutletId).HasColumnName("OutletID");

                entity.HasOne(d => d.Employeement)
                    .WithMany(p => p.DmsOrders)
                    .HasForeignKey(d => d.EmployeementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_Orders_HRM_PIEmployement");

                entity.HasOne(d => d.Outlet)
                    .WithMany(p => p.DmsOrders)
                    .HasForeignKey(d => d.OutletId)
                    .HasConstraintName("FK_DMS_Orders_SET_Outlet");
            });

            modelBuilder.Entity<DmsOrderDelete>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DMS_OrderDelete");

                entity.Property(e => e.ChallanId).HasColumnName("ChallanID");

                entity.Property(e => e.EmployeementId).HasColumnName("EmployeementID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.OrderDate).HasColumnType("date");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.OrderTime)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.OutletId).HasColumnName("OutletID");
            });

            modelBuilder.Entity<DmsOrderDetail>(entity =>
            {
                entity.HasKey(e => e.OrderDetailId)
                    .HasName("PK_OrderDetail");

                entity.ToTable("DMS_OrderDetail");

                entity.HasIndex(e => new { e.OrderId, e.ProductId }, "IX_DMS_OrderDetail")
                    .IsUnique();

                entity.Property(e => e.OrderDetailId)
                    .ValueGeneratedNever()
                    .HasColumnName("OrderDetailID");

                entity.Property(e => e.BpacketMax).HasColumnName("BPacketMax");

                entity.Property(e => e.Fqty).HasColumnName("FQty");

                entity.Property(e => e.GrossTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IncentiveQty).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Tp)
                    .HasColumnType("decimal(7, 3)")
                    .HasColumnName("TP");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.DmsOrderDetails)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderDetail_Orders");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.DmsOrderDetails)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_OrderDetail_SET_Product");
            });

            modelBuilder.Entity<DmsOrderDetailArchive>(entity =>
            {
                entity.HasKey(e => e.OrderDetailId);

                entity.ToTable("DMS_OrderDetailArchive");

                entity.Property(e => e.OrderDetailId)
                    .ValueGeneratedNever()
                    .HasColumnName("OrderDetailID");

                entity.Property(e => e.BpacketMax).HasColumnName("BPacketMax");

                entity.Property(e => e.Fqty).HasColumnName("FQty");

                entity.Property(e => e.GrossTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IncentiveQty).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Tp)
                    .HasColumnType("decimal(7, 2)")
                    .HasColumnName("TP");
            });

            modelBuilder.Entity<DmsOrderDetailDelete>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DMS_OrderDetailDelete");

                entity.Property(e => e.BpacketMax).HasColumnName("BPacketMax");

                entity.Property(e => e.Fqty).HasColumnName("FQty");

                entity.Property(e => e.GrossTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IncentiveQty).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.OrderDetailId).HasColumnName("OrderDetailID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Tp)
                    .HasColumnType("decimal(7, 2)")
                    .HasColumnName("TP");
            });

            modelBuilder.Entity<DmsOrderDetailForPoint>(entity =>
            {
                entity.HasKey(e => e.OrderDetailId);

                entity.ToTable("DMS_OrderDetailForPoint");

                entity.HasIndex(e => new { e.OrderId, e.ProductId }, "IX_DMS_OrderDetailForPoint")
                    .IsUnique();

                entity.Property(e => e.OrderDetailId)
                    .ValueGeneratedNever()
                    .HasColumnName("OrderDetailID");

                entity.Property(e => e.BpacketMax).HasColumnName("BPacketMax");

                entity.Property(e => e.Fqty).HasColumnName("FQty");

                entity.Property(e => e.GrossTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IncentiveQty).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Tp)
                    .HasColumnType("decimal(7, 3)")
                    .HasColumnName("TP");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.DmsOrderDetailForPoints)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_OrderDetailForPoint_DMS_OrdersForPoint");
            });

            modelBuilder.Entity<DmsOrderDetailForPointDelete>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DMS_OrderDetailForPointDelete");

                entity.Property(e => e.BpacketMax).HasColumnName("BPacketMax");

                entity.Property(e => e.Fqty).HasColumnName("FQty");

                entity.Property(e => e.GrossTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IncentiveQty).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.OrderDetailId).HasColumnName("OrderDetailID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Tp)
                    .HasColumnType("decimal(7, 3)")
                    .HasColumnName("TP");
            });

            modelBuilder.Entity<DmsOrdersArchive>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.ToTable("DMS_OrdersArchive");

                entity.Property(e => e.OrderId)
                    .ValueGeneratedNever()
                    .HasColumnName("OrderID");

                entity.Property(e => e.ChallanId).HasColumnName("ChallanID");

                entity.Property(e => e.EmployeementId).HasColumnName("EmployeementID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.OrderDate).HasColumnType("date");

                entity.Property(e => e.OrderTime)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.OutletId).HasColumnName("OutletID");
            });

            modelBuilder.Entity<DmsOrdersDelete>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dms_ordersDelete");

                entity.Property(e => e.ChallanId).HasColumnName("ChallanID");

                entity.Property(e => e.EmployeementId).HasColumnName("EmployeementID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.OrderDate).HasColumnType("date");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.OrderTime)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.OutletId).HasColumnName("OutletID");
            });

            modelBuilder.Entity<DmsOrdersForPoint>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.ToTable("DMS_OrdersForPoint");

                entity.HasIndex(e => new { e.EmployeementId, e.ChallanId, e.OutletId, e.OrderDate, e.OrderTime }, "IX_DMS_OrdersForPoint")
                    .IsUnique();

                entity.Property(e => e.OrderId)
                    .ValueGeneratedNever()
                    .HasColumnName("OrderID");

                entity.Property(e => e.ChallanId).HasColumnName("ChallanID");

                entity.Property(e => e.EmployeementId).HasColumnName("EmployeementID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.OrderDate).HasColumnType("date");

                entity.Property(e => e.OrderTime)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.OutletId).HasColumnName("OutletID");

                entity.HasOne(d => d.Challan)
                    .WithMany(p => p.DmsOrdersForPoints)
                    .HasForeignKey(d => d.ChallanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_OrdersForPoint_DMS_AreaChallanForPoint");

                entity.HasOne(d => d.Outlet)
                    .WithMany(p => p.DmsOrdersForPoints)
                    .HasForeignKey(d => d.OutletId)
                    .HasConstraintName("FK_DMS_OrdersForPoint_SET_Outlet");
            });

            modelBuilder.Entity<DmsOrdersForPointDelete>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DMS_OrdersForPointDelete");

                entity.Property(e => e.ChallanId).HasColumnName("ChallanID");

                entity.Property(e => e.EmployeementId).HasColumnName("EmployeementID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.OrderDate).HasColumnType("date");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.OrderTime)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.OutletId).HasColumnName("OutletID");
            });

            modelBuilder.Entity<DmsOutletWiseHighBaseSale>(entity =>
            {
                entity.ToTable("DMS_OutletWiseHighBaseSales");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OutletId).HasColumnName("OutletID");
            });

            modelBuilder.Entity<DmsOutletWiseLatlong>(entity =>
            {
                entity.ToTable("DMS_OutletWiseLatlong");

                entity.HasIndex(e => e.OutletId, "IX_DMS_OutletWiseLatlong")
                    .IsUnique();

                entity.HasIndex(e => new { e.Latitude, e.Longitude }, "IX_DMS_OutletWiseLatlong_1")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.EntryTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Latitude).HasColumnType("decimal(11, 8)");

                entity.Property(e => e.Longitude).HasColumnType("decimal(11, 8)");

                entity.Property(e => e.OutletId).HasColumnName("OutletID");
            });

            modelBuilder.Entity<DmsOutletWiseLatlongDeleted>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DMS_OutletWiseLatlongDeleted");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.EntryTime).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Latitude).HasColumnType("decimal(9, 6)");

                entity.Property(e => e.Longitude).HasColumnType("decimal(9, 6)");

                entity.Property(e => e.OutletId).HasColumnName("OutletID");

                entity.Property(e => e.Rn).HasColumnName("RN");
            });

            modelBuilder.Entity<DmsProductWiseMposalesTarget>(entity =>
            {
                entity.ToTable("DMS_ProductWiseMPOSalesTarget");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.SalesTarget).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<DmsProductWiseMposalesTargetRawDatum>(entity =>
            {
                entity.ToTable("DMS_ProductWiseMPOSalesTargetRawData");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ErrorMessage).HasMaxLength(500);

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.Mpocode)
                    .HasMaxLength(50)
                    .HasColumnName("MPOCode");

                entity.Property(e => e.ProductCode).HasMaxLength(50);

                entity.Property(e => e.ResEmployeeId).HasColumnName("ResEmployeeID");
            });

            modelBuilder.Entity<DmsRegionActualSalesMaster>(entity =>
            {
                entity.ToTable("DMS_RegionActualSalesMaster");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AverageMemo).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.SalesDate).HasColumnType("date");
            });

            modelBuilder.Entity<DmsRegionAllocatedItem>(entity =>
            {
                entity.ToTable("DMS_RegionAllocatedItem");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.InsertUserId).HasColumnName("InsertUserID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Smid).HasColumnName("SMID");

                entity.Property(e => e.TplanId).HasColumnName("TPlanID");

                entity.HasOne(d => d.Tplan)
                    .WithMany(p => p.DmsRegionAllocatedItems)
                    .HasForeignKey(d => d.TplanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_RegionAllocatedItem_DMS_RegionAllocatedTarget");
            });

            modelBuilder.Entity<DmsRegionAllocatedTarget>(entity =>
            {
                entity.HasKey(e => e.TplanId)
                    .HasName("PK_RegionTargetPlan");

                entity.ToTable("DMS_RegionAllocatedTarget");

                entity.Property(e => e.TplanId)
                    .ValueGeneratedNever()
                    .HasColumnName("TPlanID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.Property(e => e.Remarks).HasMaxLength(300);

                entity.Property(e => e.TplanById).HasColumnName("TPlanByID");

                entity.Property(e => e.TplanNo)
                    .HasMaxLength(50)
                    .HasColumnName("TPlanNo");
            });

            modelBuilder.Entity<DmsRegionSrwiseNapkinSalesTarget>(entity =>
            {
                entity.ToTable("DMS_RegionSRWiseNapkinSalesTarget");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.RegionId).HasColumnName("RegionID");
            });

            modelBuilder.Entity<DmsRegionWiseActualSale>(entity =>
            {
                entity.ToTable("DMS_RegionWiseActualSales");

                entity.HasIndex(e => new { e.ProductId, e.RegionId, e.SalesDate }, "IX_DMS_RegionWiseActualSales")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CurrentStock).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.MasterId).HasColumnName("MasterID");

                entity.Property(e => e.SalesDate).HasColumnType("date");

                entity.Property(e => e.SalesQty).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Master)
                    .WithMany(p => p.DmsRegionWiseActualSales)
                    .HasForeignKey(d => d.MasterId)
                    .HasConstraintName("FK_DMS_RegionWiseActualSales_DMS_RegionActualSalesMaster");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.DmsRegionWiseActualSales)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_RegionWiseActualSales_SET_Product");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.DmsRegionWiseActualSales)
                    .HasForeignKey(d => d.RegionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_RegionWiseActualSales_SET_Region");
            });

            modelBuilder.Entity<DmsReportAreaChallan>(entity =>
            {
                entity.HasKey(e => e.ChallanId);

                entity.ToTable("DMS_ReportAreaChallan");

                entity.Property(e => e.ChallanId)
                    .ValueGeneratedNever()
                    .HasColumnName("ChallanID");

                entity.Property(e => e.AlternetSr)
                    .HasMaxLength(300)
                    .HasColumnName("AlternetSR");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.ChallanById).HasColumnName("ChallanByID");

                entity.Property(e => e.ChallanDate).HasColumnType("date");

                entity.Property(e => e.ChallanNo).HasMaxLength(100);

                entity.Property(e => e.Driver).HasMaxLength(100);

                entity.Property(e => e.Ieid).HasColumnName("IEID");

                entity.Property(e => e.IsApprovedByAm).HasColumnName("IsApprovedByAM");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.Remarks).HasMaxLength(300);

                entity.Property(e => e.RouteId).HasColumnName("RouteID");

                entity.Property(e => e.Srid).HasColumnName("SRID");

                entity.Property(e => e.VanNo).HasMaxLength(100);
            });

            modelBuilder.Entity<DmsReportAreaChallanItem>(entity =>
            {
                entity.HasKey(e => e.ChallanItemId);

                entity.ToTable("DMS_ReportAreaChallanItem");

                entity.Property(e => e.ChallanItemId)
                    .ValueGeneratedNever()
                    .HasColumnName("ChallanItemID");

                entity.Property(e => e.Asid).HasColumnName("ASID");

                entity.Property(e => e.ChallanId).HasColumnName("ChallanID");

                entity.Property(e => e.InsertUserId).HasColumnName("InsertUserID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ReturnAsid).HasColumnName("ReturnASID");

                entity.Property(e => e.Tp)
                    .HasColumnType("decimal(7, 3)")
                    .HasColumnName("TP");
            });

            modelBuilder.Entity<DmsRequisionIndentation>(entity =>
            {
                entity.HasKey(e => e.IndentationId);

                entity.ToTable("DMS_RequisionIndentation");

                entity.Property(e => e.IndentationId)
                    .ValueGeneratedNever()
                    .HasColumnName("IndentationID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.DepoId).HasColumnName("DepoID");

                entity.Property(e => e.Dmid).HasColumnName("DMId");

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.IndentById).HasColumnName("IndentByID");

                entity.Property(e => e.IndentationNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.Property(e => e.Remarks).HasMaxLength(300);

                entity.HasOne(d => d.Depo)
                    .WithMany(p => p.DmsRequisionIndentations)
                    .HasForeignKey(d => d.DepoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_RequisionIndentation_SET_Depo");
            });

            modelBuilder.Entity<DmsRequisition>(entity =>
            {
                entity.HasKey(e => e.RequisitionId)
                    .HasName("PK_Requisition");

                entity.ToTable("DMS_Requisition");

                entity.HasIndex(e => e.RequisitionNo, "IX_DMS_Requisition");

                entity.Property(e => e.RequisitionId)
                    .ValueGeneratedNever()
                    .HasColumnName("RequisitionID");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Remarks).HasMaxLength(300);

                entity.Property(e => e.RequisitionById).HasColumnName("RequisitionByID");

                entity.Property(e => e.RequisitionNo).HasMaxLength(50);

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.DmsRequisitions)
                    .HasForeignKey(d => d.AreaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_Requisition_SET_Area");
            });

            modelBuilder.Entity<DmsRequisitionIndentationDetail>(entity =>
            {
                entity.ToTable("DMS_RequisitionIndentationDetail");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.IndentationId).HasColumnName("IndentationID");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Indentation)
                    .WithMany(p => p.DmsRequisitionIndentationDetails)
                    .HasForeignKey(d => d.IndentationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_RequisitionIndentationDetail_DMS_RequisionIndentation");
            });

            modelBuilder.Entity<DmsRequisitionItem>(entity =>
            {
                entity.HasKey(e => e.RequisitionItemId)
                    .HasName("PK_RequisItem");

                entity.ToTable("DMS_RequisitionItem");

                entity.Property(e => e.RequisitionItemId)
                    .ValueGeneratedNever()
                    .HasColumnName("RequisitionItemID");

                entity.Property(e => e.InsertUserId).HasColumnName("InsertUserID");

                entity.Property(e => e.IsApprovedByRm).HasColumnName("IsApprovedByRM");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.RequisitionId).HasColumnName("RequisitionID");

                entity.Property(e => e.RmapprovalQty).HasColumnName("RMApprovalQty");

                entity.Property(e => e.Rmid).HasColumnName("RMID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.DmsRequisitionItems)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_RequisitItem_SET_Product");

                entity.HasOne(d => d.Requisition)
                    .WithMany(p => p.DmsRequisitionItems)
                    .HasForeignKey(d => d.RequisitionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RequisitionItem_Requisition");
            });

            modelBuilder.Entity<DmsRequisitionToRegionApproveAndAssign>(entity =>
            {
                entity.HasKey(e => e.ApprovedId);

                entity.ToTable("DMS_RequisitionToRegionApproveAndAssign");

                entity.Property(e => e.ApprovedId)
                    .ValueGeneratedNever()
                    .HasColumnName("ApprovedID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Remarks).HasMaxLength(300);

                entity.Property(e => e.RequestToAreaId).HasColumnName("RequestToAreaID");

                entity.Property(e => e.RequisitionId).HasColumnName("RequisitionID");

                entity.Property(e => e.Rmid).HasColumnName("RMID");

                entity.HasOne(d => d.Requisition)
                    .WithMany(p => p.DmsRequisitionToRegionApproveAndAssigns)
                    .HasForeignKey(d => d.RequisitionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_RequisitionToRegionApproveAndAssign_DMS_AreaRequisitionToRegion");
            });

            modelBuilder.Entity<DmsRequisitionToRegionApproveAndAssignDetail>(entity =>
            {
                entity.ToTable("DMS_RequisitionToRegionApproveAndAssignDetail");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ApprovedId).HasColumnName("ApprovedID");

                entity.Property(e => e.RequisitionItemId).HasColumnName("RequisitionItemID");

                entity.Property(e => e.RmapprovalQty).HasColumnName("RMApprovalQty");

                entity.HasOne(d => d.Approved)
                    .WithMany(p => p.DmsRequisitionToRegionApproveAndAssignDetails)
                    .HasForeignKey(d => d.ApprovedId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_RequisitionToRegionApproveAndAssignDetail_DMS_RequisitionToRegionApproveAndAssign");

                entity.HasOne(d => d.RequisitionItem)
                    .WithMany(p => p.DmsRequisitionToRegionApproveAndAssignDetails)
                    .HasForeignKey(d => d.RequisitionItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_RequisitionToRegionApproveAndAssignDetail_DMS_RequisitionToRegionDetail");
            });

            modelBuilder.Entity<DmsRequisitionToRegionDetail>(entity =>
            {
                entity.HasKey(e => e.RequisitionItemId);

                entity.ToTable("DMS_RequisitionToRegionDetail");

                entity.Property(e => e.RequisitionItemId)
                    .ValueGeneratedNever()
                    .HasColumnName("RequisitionItemID");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.RequisitionId).HasColumnName("RequisitionID");

                entity.HasOne(d => d.Requisition)
                    .WithMany(p => p.DmsRequisitionToRegionDetails)
                    .HasForeignKey(d => d.RequisitionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_RequisitionToRegionDetail_DMS_AreaRequisitionToRegion");
            });

            modelBuilder.Entity<DmsReturnDetail>(entity =>
            {
                entity.HasKey(e => e.ReturnItemId)
                    .HasName("PK_ReturnDetail");

                entity.ToTable("DMS_ReturnDetail");

                entity.Property(e => e.ReturnItemId)
                    .ValueGeneratedNever()
                    .HasColumnName("ReturnItemID");

                entity.Property(e => e.BatchId).HasColumnName("BatchID");

                entity.Property(e => e.Cause).HasMaxLength(200);

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.Ppid).HasColumnName("PPID");

                entity.Property(e => e.Qty).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ReturnAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ReturnId).HasColumnName("ReturnID");

                entity.Property(e => e.ReturnTypeId).HasColumnName("ReturnTypeID");

                entity.HasOne(d => d.Pp)
                    .WithMany(p => p.DmsReturnDetails)
                    .HasForeignKey(d => d.Ppid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_ReturnDetail_SET_ProductPrice");

                entity.HasOne(d => d.ReturnType)
                    .WithMany(p => p.DmsReturnDetails)
                    .HasForeignKey(d => d.ReturnTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_ReturnDetail_ReturnType");
            });

            modelBuilder.Entity<DmsRoutePlan>(entity =>
            {
                entity.HasKey(e => e.PlanId);

                entity.ToTable("DMS_RoutePlan");

                entity.HasIndex(e => new { e.RouteId, e.EmployeeId, e.Date }, "DuplicatePlanCheck")
                    .IsUnique();

                entity.Property(e => e.PlanId)
                    .ValueGeneratedNever()
                    .HasColumnName("PlanID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.RouteId).HasColumnName("RouteID");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.DmsRoutePlans)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_RoutePlan_HRM_PI");

                entity.HasOne(d => d.Route)
                    .WithMany(p => p.DmsRoutePlans)
                    .HasForeignKey(d => d.RouteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_RoutePlan_SET_Route");
            });

            modelBuilder.Entity<DmsRouteWiseHighLowBase>(entity =>
            {
                entity.ToTable("DMS_RouteWiseHighLowBase");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.BaseAb8).HasColumnName("BaseAB8");

                entity.Property(e => e.BaseAbr).HasColumnName("BaseABR");

                entity.Property(e => e.BaseGb).HasColumnName("BaseGB");

                entity.Property(e => e.BasePb).HasColumnName("BasePB");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.RouteId).HasColumnName("RouteID");

                entity.Property(e => e.Srid).HasColumnName("SRID");
            });

            modelBuilder.Entity<DmsSample>(entity =>
            {
                entity.HasKey(e => e.SampleId)
                    .HasName("PK_Samples");

                entity.ToTable("DMS_Samples");

                entity.Property(e => e.SampleId)
                    .ValueGeneratedNever()
                    .HasColumnName("SampleID");

                entity.Property(e => e.ChallanId).HasColumnName("ChallanID");

                entity.Property(e => e.EmployeementId).HasColumnName("EmployeementID");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SampleDate).HasColumnType("date");

                entity.HasOne(d => d.Challan)
                    .WithMany(p => p.DmsSamples)
                    .HasForeignKey(d => d.ChallanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_Samples_DMS_AreaDeliveryChallan");

                entity.HasOne(d => d.Employeement)
                    .WithMany(p => p.DmsSamples)
                    .HasForeignKey(d => d.EmployeementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_Samples_HRM_PIEmployement");
            });

            modelBuilder.Entity<DmsSampleItem>(entity =>
            {
                entity.HasKey(e => e.SampleItemId)
                    .HasName("PK_SampleItem");

                entity.ToTable("DMS_SampleItem");

                entity.HasIndex(e => new { e.SampleId, e.ProductId }, "IX_DMS_SampleItem")
                    .IsUnique();

                entity.Property(e => e.SampleItemId)
                    .ValueGeneratedNever()
                    .HasColumnName("SampleItemID");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.SampleId).HasColumnName("SampleID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.DmsSampleItems)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_SampleItem_SET_Product");

                entity.HasOne(d => d.Sample)
                    .WithMany(p => p.DmsSampleItems)
                    .HasForeignKey(d => d.SampleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SampleItem_Samples");
            });

            modelBuilder.Entity<DmsSampleItemSmoker>(entity =>
            {
                entity.ToTable("DMS_SampleItemSmoker");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MobileNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PreBrand)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Profession)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SampleItemId).HasColumnName("SampleItemID");

                entity.HasOne(d => d.SampleItem)
                    .WithMany(p => p.DmsSampleItemSmokers)
                    .HasForeignKey(d => d.SampleItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SampleItemSmoker_DMS_SampleItem");
            });

            modelBuilder.Entity<DmsSetFactoryProductionTarget>(entity =>
            {
                entity.ToTable("DMS_SetFactoryProductionTarget");

                entity.HasIndex(e => new { e.CurrentDate, e.FactoryId, e.ProductId }, "IX_DMS_SetFactoryProductionTarget")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CurrentDate).HasColumnType("date");

                entity.Property(e => e.EntryById).HasColumnName("EntryByID");

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");
            });

            modelBuilder.Entity<DmsSrandRouteWiseNapkinSalesTarget>(entity =>
            {
                entity.ToTable("DMS_SRAndRouteWiseNapkinSalesTarget");

                entity.HasIndex(e => new { e.RouteId, e.Srid, e.ProductId, e.Month, e.Year, e.TargetQty }, "IX_DMS_SRAndRouteWiseNapkinSalesTarget");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.RouteId).HasColumnName("RouteID");

                entity.Property(e => e.Srid).HasColumnName("SRID");

                entity.Property(e => e.TargetQty).HasColumnType("decimal(10, 2)");
            });

            modelBuilder.Entity<DmsSrandRouteWiseSalesTarget>(entity =>
            {
                entity.ToTable("DMS_SRAndRouteWiseSalesTarget");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.RouteId).HasColumnName("RouteID");

                entity.Property(e => e.Srid).HasColumnName("SRID");
            });

            modelBuilder.Entity<DmsSrprojectInfo>(entity =>
            {
                entity.ToTable("DMS_SRProjectInfo");

                entity.HasIndex(e => new { e.Date, e.RouteId }, "IX_DMS_SRProjectInfo");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.Biri).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Comments)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Matches).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Napkin).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ParameterId).HasColumnName("ParameterID");

                entity.Property(e => e.Pharma).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ResEmployeeId).HasColumnName("ResEmployeeID");

                entity.Property(e => e.RouteId).HasColumnName("RouteID");

                entity.Property(e => e.Srid).HasColumnName("SRID");

                entity.Property(e => e.TerritoryId).HasColumnName("TerritoryID");

                entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Parameter)
                    .WithMany(p => p.DmsSrprojectInfos)
                    .HasForeignKey(d => d.ParameterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_SRProjectInfo_DMS_SRProjectParameter");
            });

            modelBuilder.Entity<DmsSrprojectParameter>(entity =>
            {
                entity.HasKey(e => e.ParameterId);

                entity.ToTable("DMS_SRProjectParameter");

                entity.Property(e => e.ParameterId)
                    .ValueGeneratedNever()
                    .HasColumnName("ParameterID");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Lastupdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ParameterName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DmsSrwiseDailyActivitiesBackup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DMS_SRWiseDailyActivities_Backup");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.ResEmployeeId).HasColumnName("ResEmployeeID");

                entity.Property(e => e.RouteId).HasColumnName("RouteID");

                entity.Property(e => e.Srid).HasColumnName("SRID");

                entity.Property(e => e.TerritoryId).HasColumnName("TerritoryID");
            });

            modelBuilder.Entity<DmsSrwiseDailyActivitiesDel>(entity =>
            {
                entity.ToTable("DMS_SRWiseDailyActivities_Del");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ActivitiesId).HasColumnName("ActivitiesID");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.ResEmployeeId).HasColumnName("ResEmployeeID");

                entity.Property(e => e.RouteId).HasColumnName("RouteID");

                entity.Property(e => e.Srid).HasColumnName("SRID");

                entity.Property(e => e.TerritoryId).HasColumnName("TerritoryID");
            });

            modelBuilder.Entity<DmsSrwiseDailyActivitiesItem>(entity =>
            {
                entity.ToTable("DMS_SRWiseDailyActivitiesItem");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ActivitesItem)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<DmsSrwiseDailyActivity>(entity =>
            {
                entity.ToTable("DMS_SRWiseDailyActivities");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.ResEmployeeId).HasColumnName("ResEmployeeID");

                entity.Property(e => e.RouteId).HasColumnName("RouteID");

                entity.Property(e => e.Srid).HasColumnName("SRID");

                entity.Property(e => e.TerritoryId).HasColumnName("TerritoryID");
            });

            modelBuilder.Entity<DmsSrwiseMatchSale>(entity =>
            {
                entity.ToTable("DMS_SRWiseMatchSales");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.Asid).HasColumnName("ASID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ResEmployeeId).HasColumnName("ResEmployeeID");

                entity.Property(e => e.RouteId).HasColumnName("RouteID");

                entity.Property(e => e.Srid).HasColumnName("SRID");

                entity.Property(e => e.TerritoryId).HasColumnName("TerritoryID");

                entity.Property(e => e.TotalPrice).HasColumnType("decimal(18, 3)");
            });

            modelBuilder.Entity<DmsSrwiseNapkinPromotion>(entity =>
            {
                entity.ToTable("DMS_SRWiseNapkinPromotion");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.Asid).HasColumnName("ASID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.PromotionTypeId).HasColumnName("PromotionTypeID");

                entity.Property(e => e.ResEmployeeId).HasColumnName("ResEmployeeID");

                entity.Property(e => e.RouteId).HasColumnName("RouteID");

                entity.Property(e => e.Srid).HasColumnName("SRID");

                entity.Property(e => e.TerritoryId).HasColumnName("TerritoryID");

                entity.Property(e => e.TotalPrice).HasColumnType("decimal(18, 3)");
            });

            modelBuilder.Entity<DmsSrwiseNapkinPromotionUpdateDatum>(entity =>
            {
                entity.HasKey(e => e.Idai);

                entity.ToTable("DMS_SRWiseNapkinPromotion_UpdateData");

                entity.Property(e => e.Idai).HasColumnName("IDAI");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.Asid).HasColumnName("ASID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ResEmployeeId).HasColumnName("ResEmployeeID");

                entity.Property(e => e.RouteId).HasColumnName("RouteID");

                entity.Property(e => e.Srid).HasColumnName("SRID");

                entity.Property(e => e.TerritoryId).HasColumnName("TerritoryID");

                entity.Property(e => e.TotalPrice).HasColumnType("decimal(18, 3)");
            });

            modelBuilder.Entity<DmsSrwiseNapkinSale>(entity =>
            {
                entity.ToTable("DMS_SRWiseNapkinSales");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.Asid).HasColumnName("ASID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ResEmployeeId).HasColumnName("ResEmployeeID");

                entity.Property(e => e.RouteId).HasColumnName("RouteID");

                entity.Property(e => e.Srid).HasColumnName("SRID");

                entity.Property(e => e.TerritoryId).HasColumnName("TerritoryID");

                entity.Property(e => e.TotalPrice).HasColumnType("decimal(18, 3)");
            });

            modelBuilder.Entity<DmsSrwiseNapkinSalesUpdateDatum>(entity =>
            {
                entity.HasKey(e => e.Idai);

                entity.ToTable("DMS_SRWiseNapkinSales_UpdateData");

                entity.Property(e => e.Idai).HasColumnName("IDAI");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.Asid).HasColumnName("ASID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ResEmployeeId).HasColumnName("ResEmployeeID");

                entity.Property(e => e.RouteId).HasColumnName("RouteID");

                entity.Property(e => e.Srid).HasColumnName("SRID");

                entity.Property(e => e.TerritoryId).HasColumnName("TerritoryID");

                entity.Property(e => e.TotalPrice).HasColumnType("decimal(18, 3)");
            });

            modelBuilder.Entity<DmsSrwiseTarget>(entity =>
            {
                entity.ToTable("DMS_SRWiseTarget");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Ab8targetQty).HasColumnName("AB8TargetQty");

                entity.Property(e => e.AbrtargetQty).HasColumnName("ABRTargetQty");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.EmploymentId).HasColumnName("EmploymentID");

                entity.Property(e => e.GbtargetQty).HasColumnName("GBTargetQty");

                entity.Property(e => e.H12targetQty).HasColumnName("H12TargetQty");

                entity.Property(e => e.H25targetQty).HasColumnName("H25TargetQty");

                entity.Property(e => e.K20targetQty).HasColumnName("K20TargetQty");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.PbtargetQty).HasColumnName("PBTargetQty");

                entity.Property(e => e.ResEmployeeId).HasColumnName("ResEmployeeID");

                entity.Property(e => e.RouteId).HasColumnName("RouteID");

                entity.Property(e => e.TerritoryId).HasColumnName("TerritoryID");
            });

            modelBuilder.Entity<DmsSrwiseTargetDel>(entity =>
            {
                entity.ToTable("DMS_SRWiseTarget_Del");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.EmploymentId).HasColumnName("EmploymentID");

                entity.Property(e => e.TerritoryId).HasColumnName("TerritoryID");
            });

            modelBuilder.Entity<DmsTargetPlan>(entity =>
            {
                entity.HasKey(e => e.TplanId)
                    .HasName("PK_TargetPlan");

                entity.ToTable("DMS_TargetPlan");

                entity.Property(e => e.TplanId)
                    .ValueGeneratedNever()
                    .HasColumnName("TPlanID");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Remarks).HasMaxLength(300);

                entity.Property(e => e.TplanById).HasColumnName("TPlanByID");

                entity.Property(e => e.TplanNo)
                    .HasMaxLength(50)
                    .HasColumnName("TPlanNo");

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.DmsTargetPlans)
                    .HasForeignKey(d => d.AreaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_TargetPlan_SET_Area");
            });

            modelBuilder.Entity<DmsTargetPlanItem>(entity =>
            {
                entity.HasKey(e => e.TplanItemId)
                    .HasName("PK_RequisitionItem");

                entity.ToTable("DMS_TargetPlanItem");

                entity.Property(e => e.TplanItemId)
                    .ValueGeneratedNever()
                    .HasColumnName("TPlanItemID");

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.InsertUserId).HasColumnName("InsertUserID");

                entity.Property(e => e.IsApprovedByRm).HasColumnName("IsApprovedByRM");

                entity.Property(e => e.IsApprovedBySm).HasColumnName("IsApprovedBySM");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RmapprovalQty).HasColumnName("RMApprovalQty");

                entity.Property(e => e.Rmid).HasColumnName("RMID");

                entity.Property(e => e.SmapprovalQty).HasColumnName("SMApprovalQty");

                entity.Property(e => e.Smid).HasColumnName("SMID");

                entity.Property(e => e.TplanId).HasColumnName("TPlanID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.DmsTargetPlanItems)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMS_TPlanItemItem_SET_Product");

                entity.HasOne(d => d.Rm)
                    .WithMany(p => p.DmsTargetPlanItems)
                    .HasForeignKey(d => d.Rmid)
                    .HasConstraintName("FK_DMS_TargetPlanItem_HRM_PIEmployement");

                entity.HasOne(d => d.Tplan)
                    .WithMany(p => p.DmsTargetPlanItems)
                    .HasForeignKey(d => d.TplanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TargetPlanItem_TargetPlan");
            });

            modelBuilder.Entity<FacBandRollCounting>(entity =>
            {
                entity.ToTable("FAC_BandRollCounting");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.BoxNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.FimageUrl)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("FImageUrl");

                entity.Property(e => e.FirstImage).HasColumnType("image");

                entity.Property(e => e.FphotoName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("FPhotoName");

                entity.Property(e => e.FphotoType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("FPhotoType");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastImage).HasColumnType("image");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LimageUrl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LImageUrl");

                entity.Property(e => e.LphotoName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LPhotoName");

                entity.Property(e => e.LphotoType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LPhotoType");

                entity.Property(e => e.Remarks).HasMaxLength(500);
            });

            modelBuilder.Entity<FacBandRollReceivedInfo>(entity =>
            {
                entity.ToTable("FAC_BandRollReceivedInfo");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BoxSlNo)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ChallanNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.GateEntryNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<FacDailyItemDisToWorker>(entity =>
            {
                entity.ToTable("FAC_DailyItemDisToWorker");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.WorkerId).HasColumnName("WorkerID");
            });

            modelBuilder.Entity<FacDailyItemDisToWorkerDetail>(entity =>
            {
                entity.ToTable("FAC_DailyItemDisToWorkerDetails");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Didw).HasColumnName("DIDW");

                entity.Property(e => e.DisQty).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Fisid).HasColumnName("FISID");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.DidwNavigation)
                    .WithMany(p => p.FacDailyItemDisToWorkerDetails)
                    .HasForeignKey(d => d.Didw)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FAC_DailyItemDisToWorkerDetails_FAC_DailyItemDisToWorker");

                entity.HasOne(d => d.Fis)
                    .WithMany(p => p.FacDailyItemDisToWorkerDetails)
                    .HasForeignKey(d => d.Fisid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FAC_DailyItemDisToWorkerDetails_FAC_FactoryItemStock");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.FacDailyItemDisToWorkerDetails)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FAC_DailyItemDisToWorkerDetails_FAC_ItemInfo");
            });

            modelBuilder.Entity<FacDailyToabaccoUse>(entity =>
            {
                entity.ToTable("FAC_DailyToabaccoUse");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Dtiid).HasColumnName("DTIID");

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.JarTamakQty).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Jtfsid).HasColumnName("JTFSID");

                entity.Property(e => e.Lastupdate).HasColumnType("datetime");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UseQty).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Dti)
                    .WithMany(p => p.FacDailyToabaccoUses)
                    .HasForeignKey(d => d.Dtiid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FAC_DailyToabaccoUse_FAC_DailyTobaccoIssue");
            });

            modelBuilder.Entity<FacDailyTobaccoIssue>(entity =>
            {
                entity.ToTable("FAC_DailyTobaccoIssue");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.Fisid).HasColumnName("FISID");

                entity.Property(e => e.IssueDate).HasColumnType("date");

                entity.Property(e => e.IssueQty).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.Lastupdate).HasColumnType("datetime");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Fis)
                    .WithMany(p => p.FacDailyTobaccoIssues)
                    .HasForeignKey(d => d.Fisid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FAC_DailyTobaccoIssue_FAC_FactoryItemStock");

                entity.HasOne(d => d.IssueTypeNavigation)
                    .WithMany(p => p.FacDailyTobaccoIssues)
                    .HasForeignKey(d => d.IssueType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FAC_DailyTobaccoIssue_FAC_TobaccoIssueType");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.FacDailyTobaccoIssues)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FAC_DailyTobaccoIssue_FAC_ItemInfo");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.FacDailyTobaccoIssues)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FAC_DailyTobaccoIssue_SET_Product");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.FacDailyTobaccoIssues)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FAC_DailyTobaccoIssue_FAC_ItemUnit");
            });

            modelBuilder.Entity<FacDailyWorkerWage>(entity =>
            {
                entity.ToTable("FAC_DailyWorkerWages");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Lastupdate).HasColumnType("datetime");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.TotalIncentive).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalWages).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.WorkerId).HasColumnName("WorkerID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.FacDailyWorkerWages)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FAC_DailyWorkerWages_SET_Product");
            });

            modelBuilder.Entity<FacFacToFacItemDistribution>(entity =>
            {
                entity.ToTable("FAC_FacToFacItemDistribution");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CarNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ChallanDate).HasColumnType("date");

                entity.Property(e => e.ChallanNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DriverMobileNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DriverName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FromFactoryId).HasColumnName("FromFactoryID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.ToFactoryId).HasColumnName("ToFactoryID");

                entity.HasOne(d => d.FromFactory)
                    .WithMany(p => p.FacFacToFacItemDistributionFromFactories)
                    .HasForeignKey(d => d.FromFactoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FAC_FacToFacItemDistribution_SET_Factory");

                entity.HasOne(d => d.ToFactory)
                    .WithMany(p => p.FacFacToFacItemDistributionToFactories)
                    .HasForeignKey(d => d.ToFactoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FAC_FacToFacItemDistribution_SET_Factory1");
            });

            modelBuilder.Entity<FacFacToFacItemDistributionDetail>(entity =>
            {
                entity.ToTable("FAC_FacToFacItemDistributionDetails");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Ffid).HasColumnName("FFID");

                entity.Property(e => e.Fisid).HasColumnName("FISID");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.Qty).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Ff)
                    .WithMany(p => p.FacFacToFacItemDistributionDetails)
                    .HasForeignKey(d => d.Ffid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FAC_FacToFacItemDistributionDetails_FAC_FacToFacItemDistribution");

                entity.HasOne(d => d.Fis)
                    .WithMany(p => p.FacFacToFacItemDistributionDetails)
                    .HasForeignKey(d => d.Fisid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FAC_FacToFacItemDistributionDetails_FAC_FactoryItemStock");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.FacFacToFacItemDistributionDetails)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FAC_FacToFacItemDistributionDetails_FAC_ItemInfo");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.FacFacToFacItemDistributionDetails)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FAC_FacToFacItemDistributionDetails_FAC_ItemUnit");
            });

            modelBuilder.Entity<FacFacToFacItemReceive>(entity =>
            {
                entity.ToTable("FAC_FacToFacItemReceive");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ChallanDate).HasColumnType("date");

                entity.Property(e => e.Ffid).HasColumnName("FFID");

                entity.Property(e => e.FromFactoryId).HasColumnName("FromFactoryID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.ReceiveDate).HasColumnType("date");

                entity.Property(e => e.ToFactoryId).HasColumnName("ToFactoryID");

                entity.HasOne(d => d.Ff)
                    .WithMany(p => p.FacFacToFacItemReceives)
                    .HasForeignKey(d => d.Ffid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FAC_FacToFacItemReceive_FAC_FacToFacItemDistribution");

                entity.HasOne(d => d.FromFactory)
                    .WithMany(p => p.FacFacToFacItemReceiveFromFactories)
                    .HasForeignKey(d => d.FromFactoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FAC_FacToFacItemReceive_SET_Factory");

                entity.HasOne(d => d.ToFactory)
                    .WithMany(p => p.FacFacToFacItemReceiveToFactories)
                    .HasForeignKey(d => d.ToFactoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FAC_FacToFacItemReceive_SET_Factory1");
            });

            modelBuilder.Entity<FacFacToFacItemReceiveDetail>(entity =>
            {
                entity.ToTable("FAC_FacToFacItemReceiveDetails");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ChallanQty).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Ffidd).HasColumnName("FFIDD");

                entity.Property(e => e.Ffir).HasColumnName("FFIR");

                entity.Property(e => e.Fsid).HasColumnName("FSID");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.ReceiveQty).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.HasOne(d => d.FfiddNavigation)
                    .WithMany(p => p.FacFacToFacItemReceiveDetails)
                    .HasForeignKey(d => d.Ffidd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FAC_FacToFacItemReceiveDetails_FAC_FacToFacItemDistributionDetails");

                entity.HasOne(d => d.FfirNavigation)
                    .WithMany(p => p.FacFacToFacItemReceiveDetails)
                    .HasForeignKey(d => d.Ffir)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FAC_FacToFacItemReceiveDetails_FAC_FacToFacItemReceive");

                entity.HasOne(d => d.Fs)
                    .WithMany(p => p.FacFacToFacItemReceiveDetails)
                    .HasForeignKey(d => d.Fsid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FAC_FacToFacItemReceiveDetails_FAC_FactoryItemStock");
            });

            modelBuilder.Entity<FacFactoryItemStock>(entity =>
            {
                entity.HasKey(e => e.Fisid);

                entity.ToTable("FAC_FactoryItemStock");

                entity.Property(e => e.Fisid)
                    .ValueGeneratedNever()
                    .HasColumnName("FISID");

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Qty).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.StockDate).HasColumnType("date");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Factory)
                    .WithMany(p => p.FacFactoryItemStocks)
                    .HasForeignKey(d => d.FactoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FAC_FactoryItemStock_SET_Factory");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.FacFactoryItemStocks)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FAC_FactoryItemStock_FAC_ItemInfo");
            });

            modelBuilder.Entity<FacItemInfo>(entity =>
            {
                entity.ToTable("FAC_ItemInfo");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ItemName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ItemTypeId).HasColumnName("ItemTypeID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<FacItemPackSize>(entity =>
            {
                entity.HasKey(e => e.ItemPackSizeId);

                entity.ToTable("FAC_ItemPackSize");

                entity.Property(e => e.ItemPackSizeId).HasColumnName("ItemPackSizeID");

                entity.Property(e => e.ItemPackSize)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Lastupdate).HasColumnType("datetime");
            });

            modelBuilder.Entity<FacItemType>(entity =>
            {
                entity.HasKey(e => e.ItemTypeId);

                entity.ToTable("FAC_ItemType");

                entity.Property(e => e.ItemTypeId).HasColumnName("ItemTypeID");

                entity.Property(e => e.ItemType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Lastupdate).HasColumnType("datetime");
            });

            modelBuilder.Entity<FacItemUnit>(entity =>
            {
                entity.ToTable("FAC_ItemUnit");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Unit)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FacItemUnitWisePackSize>(entity =>
            {
                entity.ToTable("FAC_ItemUnitWisePackSize");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AssignItemUnitId).HasColumnName("AssignItemUnitID");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.ItemUnitId).HasColumnName("ItemUnitID");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<FacJarTamakFactoryItemStock>(entity =>
            {
                entity.HasKey(e => e.Jtfisid);

                entity.ToTable("FAC_JarTamakFactoryItemStock");

                entity.Property(e => e.Jtfisid)
                    .ValueGeneratedNever()
                    .HasColumnName("JTFISID");

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.Qty).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.StockDate).HasColumnType("date");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Factory)
                    .WithMany(p => p.FacJarTamakFactoryItemStocks)
                    .HasForeignKey(d => d.FactoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FAC_JarTamakFactoryItemStock_SET_Factory");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.FacJarTamakFactoryItemStocks)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FAC_JarTamakFactoryItemStock_FAC_ItemInfo");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.FacJarTamakFactoryItemStocks)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FAC_JarTamakFactoryItemStock_FAC_ItemUnit");
            });

            modelBuilder.Entity<FacJarTobaccoIssueToChatal>(entity =>
            {
                entity.ToTable("FAC_JarTobaccoIssueToChatal");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.JarTobaccoIssue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.JarTobaccoStock).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Factory)
                    .WithMany(p => p.FacJarTobaccoIssueToChatals)
                    .HasForeignKey(d => d.FactoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FAC_JarTobaccoIssueToChatal_SET_Factory");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.FacJarTobaccoIssueToChatals)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FAC_JarTobaccoIssueToChatal_FAC_ItemInfo");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.FacJarTobaccoIssueToChatals)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FAC_JarTobaccoIssueToChatal_SET_Product");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.FacJarTobaccoIssueToChatals)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FAC_JarTobaccoIssueToChatal_FAC_ItemUnit");
            });

            modelBuilder.Entity<FacJarTobaccoReceiveFromChatal>(entity =>
            {
                entity.ToTable("FAC_JarTobaccoReceiveFromChatal");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.IssueDate).HasColumnType("date");

                entity.Property(e => e.IssueJarTobacco).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Jtic).HasColumnName("JTIC");

                entity.Property(e => e.Lastupdate).HasColumnType("datetime");

                entity.Property(e => e.ReceiveDate).HasColumnType("date");

                entity.Property(e => e.ReceiveJarTobacco).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShortageJarTobacco).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Factory)
                    .WithMany(p => p.FacJarTobaccoReceiveFromChatals)
                    .HasForeignKey(d => d.FactoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FAC_JarTobaccoReceiveFromChatal_SET_Factory");

                entity.HasOne(d => d.JticNavigation)
                    .WithMany(p => p.FacJarTobaccoReceiveFromChatals)
                    .HasForeignKey(d => d.Jtic)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FAC_JarTobaccoReceiveFromChatal_FAC_JarTobaccoIssueToChatal");
            });

            modelBuilder.Entity<FacProductionReceiveFromWorker>(entity =>
            {
                entity.ToTable("FAC_ProductionReceiveFromWorker");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Didw).HasColumnName("DIDW");

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ReceiveDate).HasColumnType("date");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WorkerId).HasColumnName("WorkerID");

                entity.HasOne(d => d.DidwNavigation)
                    .WithMany(p => p.FacProductionReceiveFromWorkers)
                    .HasForeignKey(d => d.Didw)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FAC_ProductionReceiveFromWorker_FAC_DailyItemDisToWorker");
            });

            modelBuilder.Entity<FacProductionReceiveFromWorkerDetial>(entity =>
            {
                entity.ToTable("FAC_ProductionReceiveFromWorkerDetials");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.Prfwid).HasColumnName("PRFWID");

                entity.Property(e => e.Qty).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ReceiveQty).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ReturnQty).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Prfw)
                    .WithMany(p => p.FacProductionReceiveFromWorkerDetials)
                    .HasForeignKey(d => d.Prfwid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FAC_ProductionReceiveFromWorkerDetials_FAC_ProductionReceiveFromWorker");
            });

            modelBuilder.Entity<FacReceiveItemFromHo>(entity =>
            {
                entity.HasKey(e => e.Frihoid);

                entity.ToTable("FAC_ReceiveItemFromHO");

                entity.Property(e => e.Frihoid)
                    .ValueGeneratedNever()
                    .HasColumnName("FRIHOID");

                entity.Property(e => e.CarNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ChallanDate).HasColumnType("date");

                entity.Property(e => e.ChallanNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DriverMobileNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DriverName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ReceiveDate).HasColumnType("date");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FacReceiveItemFromHodetail>(entity =>
            {
                entity.HasKey(e => e.FridetailId);

                entity.ToTable("FAC_ReceiveItemFromHODetail");

                entity.Property(e => e.FridetailId)
                    .ValueGeneratedNever()
                    .HasColumnName("FRIDetailID");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Fisid).HasColumnName("FISID");

                entity.Property(e => e.Frihoid).HasColumnName("FRIHOID");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.Lastupdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ReceiveQty).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Fis)
                    .WithMany(p => p.FacReceiveItemFromHodetails)
                    .HasForeignKey(d => d.Fisid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FAC_ReceiveItemFromHODetail_FAC_FactoryItemStock");

                entity.HasOne(d => d.Friho)
                    .WithMany(p => p.FacReceiveItemFromHodetails)
                    .HasForeignKey(d => d.Frihoid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FAC_ReceiveItemFromHODetail_FAC_ReceiveItemFromHO");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.FacReceiveItemFromHodetails)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FAC_ReceiveItemFromHODetail_FAC_ItemInfo");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.FacReceiveItemFromHodetails)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FAC_ReceiveItemFromHODetail_FAC_ItemUnit");
            });

            modelBuilder.Entity<FacTobaccoIssueType>(entity =>
            {
                entity.ToTable("FAC_TobaccoIssueType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IssueType)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FacWorkerCanteenBill>(entity =>
            {
                entity.ToTable("FAC_WorkerCanteenBill");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CanteenBill).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Lastupdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OthersBill).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Remarks).HasMaxLength(500);

                entity.Property(e => e.WorkerId).HasColumnName("WorkerID");

                entity.Property(e => e.WorkerName).HasMaxLength(500);

                entity.Property(e => e.WorkerRegNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FacWorkerWage>(entity =>
            {
                entity.ToTable("FAC_WorkerWages");

                entity.HasIndex(e => new { e.FactoryId, e.ProductId, e.Fwtype }, "IX_FAC_WorkerWages")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.Fwtype).HasColumnName("FWType");

                entity.Property(e => e.Incentive).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Lastupdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.WagesPerTh)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("WagesPerTH");

                entity.HasOne(d => d.Factory)
                    .WithMany(p => p.FacWorkerWages)
                    .HasForeignKey(d => d.FactoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FAC_WorkerWages_SET_Factory");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.FacWorkerWages)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FAC_WorkerWages_SET_Product");
            });

            modelBuilder.Entity<FtAggreementType>(entity =>
            {
                entity.ToTable("FT_AggreementType");

                entity.HasIndex(e => e.Name, "IX_FT_AggreementType")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<FtApprovalStatus>(entity =>
            {
                entity.ToTable("FT_ApprovalStatus");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.StatusName).HasMaxLength(50);
            });

            modelBuilder.Entity<FtAttendanceStatus>(entity =>
            {
                entity.ToTable("FT_AttendanceStatus");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<FtBloodGroup>(entity =>
            {
                entity.ToTable("FT_BloodGroup");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<FtChoiceType>(entity =>
            {
                entity.ToTable("FT_ChoiceType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ChoiceType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FtEmployeeStatus>(entity =>
            {
                entity.ToTable("FT_EmployeeStatus");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<FtGender>(entity =>
            {
                entity.ToTable("FT_Gender");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<FtHrleaveType>(entity =>
            {
                entity.ToTable("FT_HRLeaveType");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.Name).HasMaxLength(10);
            });

            modelBuilder.Entity<FtMeritalStatus>(entity =>
            {
                entity.ToTable("FT_MeritalStatus");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<FtOutletOther>(entity =>
            {
                entity.HasKey(e => e.OutletId)
                    .HasName("PK_Outlet");

                entity.ToTable("FT_OutletOthers");

                entity.HasIndex(e => e.OutletCode, "IX_Outlet")
                    .IsUnique();

                entity.Property(e => e.OutletId)
                    .ValueGeneratedNever()
                    .HasColumnName("OutletID");

                entity.Property(e => e.Address).HasMaxLength(200);

                entity.Property(e => e.ContactNo).HasMaxLength(50);

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.OutletCode).HasMaxLength(50);

                entity.Property(e => e.OutletName).HasMaxLength(100);

                entity.Property(e => e.Owner).HasMaxLength(100);
            });

            modelBuilder.Entity<FtReligion>(entity =>
            {
                entity.ToTable("FT_Religion");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<FtShiftProfileItem>(entity =>
            {
                entity.ToTable("FT_ShiftProfileItem");

                entity.HasIndex(e => e.ProfileItemName, "IX_FT_ShiftProfileItem")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ProfileItemName).HasMaxLength(50);
            });

            modelBuilder.Entity<FtTerminationType>(entity =>
            {
                entity.ToTable("FT_TerminationType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<FtTerritoryType>(entity =>
            {
                entity.ToTable("FT_TerritoryType");

                entity.HasIndex(e => e.Name, "IX_FT_TerritoryType")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<FtWorkingDay>(entity =>
            {
                entity.ToTable("FT_WorkingDays");

                entity.HasIndex(e => e.DayName, "IX_FT_WorkingDays")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DayName).HasMaxLength(50);
            });

            modelBuilder.Entity<Gpstracking>(entity =>
            {
                entity.HasKey(e => e.GpstracId);

                entity.ToTable("GPSTracking");

                entity.HasIndex(e => new { e.TrackingTime, e.EmployeeId }, "IX_GPSTracking");

                entity.Property(e => e.GpstracId)
                    .ValueGeneratedNever()
                    .HasColumnName("GPSTracID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.ImageCaptureId).HasColumnName("ImageCaptureID");

                entity.Property(e => e.Latitude).HasColumnType("decimal(9, 6)");

                entity.Property(e => e.Longitude).HasColumnType("decimal(9, 6)");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.OutletId).HasColumnName("OutletID");

                entity.Property(e => e.TrackingTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<GpstrackingArchive>(entity =>
            {
                entity.HasKey(e => e.GpstracId)
                    .HasName("PK_GPSTrackingBackup");

                entity.ToTable("GPSTrackingArchive");

                entity.HasIndex(e => new { e.TrackingTime, e.EmployeeId }, "IX_GPSTrackingArchive");

                entity.Property(e => e.GpstracId)
                    .ValueGeneratedNever()
                    .HasColumnName("GPSTracID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.ImageCaptureId).HasColumnName("ImageCaptureID");

                entity.Property(e => e.Latitude).HasColumnType("decimal(9, 6)");

                entity.Property(e => e.Longitude).HasColumnType("decimal(9, 6)");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.OutletId).HasColumnName("OutletID");

                entity.Property(e => e.TrackingTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<GpstrackingOrder>(entity =>
            {
                entity.HasKey(e => e.GpstracId);

                entity.ToTable("GPSTrackingOrder");

                entity.Property(e => e.GpstracId)
                    .ValueGeneratedNever()
                    .HasColumnName("GPSTracID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.ImageCaptureId).HasColumnName("ImageCaptureID");

                entity.Property(e => e.IsProcess).HasDefaultValueSql("((0))");

                entity.Property(e => e.Latitude).HasColumnType("decimal(9, 6)");

                entity.Property(e => e.Longitude).HasColumnType("decimal(9, 6)");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.OutletId).HasColumnName("OutletID");

                entity.Property(e => e.TrackingTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<GpstrackingRaw>(entity =>
            {
                entity.HasKey(e => e.GpstracId);

                entity.ToTable("GPSTrackingRaw");

                entity.Property(e => e.GpstracId).HasColumnName("GPSTracID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.ImageCaptureId).HasColumnName("ImageCaptureID");

                entity.Property(e => e.Latitude).HasColumnType("decimal(9, 6)");

                entity.Property(e => e.Longitude).HasColumnType("decimal(9, 6)");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.TrackingTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<GpstrackingTemp>(entity =>
            {
                entity.HasKey(e => e.GpstracId);

                entity.ToTable("GPSTrackingTemp");

                entity.HasIndex(e => e.TrackingTime, "IX_GPSTrackingTemp_1");

                entity.Property(e => e.GpstracId)
                    .ValueGeneratedNever()
                    .HasColumnName("GPSTracID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.ImageCaptureId).HasColumnName("ImageCaptureID");

                entity.Property(e => e.Latitude).HasColumnType("decimal(9, 6)");

                entity.Property(e => e.Longitude).HasColumnType("decimal(9, 6)");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.OutletId).HasColumnName("OutletID");

                entity.Property(e => e.TrackingTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<HrLeaveBalanceLeave>(entity =>
            {
                entity.ToTable("HR_LeaveBalanceLeave");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.LeaveProfileId).HasColumnName("LeaveProfileID");

                entity.Property(e => e.TotalLeave).HasColumnType("numeric(8, 4)");
            });

            modelBuilder.Entity<HrLeaveCancelApplication>(entity =>
            {
                entity.ToTable("HR_LeaveCancelApplication");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.AppDate).HasColumnType("datetime");

                entity.Property(e => e.ApprovedById).HasColumnName("ApprovedByID");

                entity.Property(e => e.ApprovedDate).HasColumnType("date");

                entity.Property(e => e.CancelledById).HasColumnName("CancelledByID");

                entity.Property(e => e.Comments)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.LevApplicationId).HasColumnName("LevApplicationID");

                entity.HasOne(d => d.LevApplication)
                    .WithMany(p => p.HrLeaveCancelApplications)
                    .HasForeignKey(d => d.LevApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HR_LeaveCancelApplication_HRM_LeaveApplication");
            });

            modelBuilder.Entity<HrmAdvanceApplication>(entity =>
            {
                entity.ToTable("HRM_AdvanceApplication");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.AppDate).HasColumnType("date");

                entity.Property(e => e.ApplyById).HasColumnName("ApplyByID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.GrossSalary).HasColumnType("money");

                entity.Property(e => e.NeedDate).HasColumnType("date");

                entity.Property(e => e.Note).HasMaxLength(200);

                entity.HasOne(d => d.ApplyBy)
                    .WithMany(p => p.HrmAdvanceApplicationApplyBies)
                    .HasForeignKey(d => d.ApplyById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HRM_AdvanceApplication_HRM_PI1");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.HrmAdvanceApplicationEmployees)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HRM_AdvanceApplication_HRM_PI");
            });

            modelBuilder.Entity<HrmAdvanceApproval>(entity =>
            {
                entity.ToTable("HRM_AdvanceApproval");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AdvanceId).HasColumnName("AdvanceID");

                entity.Property(e => e.ApprovedById).HasColumnName("ApprovedByID");

                entity.HasOne(d => d.Advance)
                    .WithMany(p => p.HrmAdvanceApprovals)
                    .HasForeignKey(d => d.AdvanceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HRM_AdvanceApproval_HRM_AdvanceApplication");

                entity.HasOne(d => d.ApprovedBy)
                    .WithMany(p => p.HrmAdvanceApprovals)
                    .HasForeignKey(d => d.ApprovedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HRM_AdvanceApproval_HRM_PI");
            });

            modelBuilder.Entity<HrmAdvanceRepay>(entity =>
            {
                entity.ToTable("HRM_AdvanceRepay");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AdvanceId).HasColumnName("AdvanceID");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.HasOne(d => d.Advance)
                    .WithMany(p => p.HrmAdvanceRepays)
                    .HasForeignKey(d => d.AdvanceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HRM_AdvanceRepay_HRM_AdvanceApplication");
            });

            modelBuilder.Entity<HrmAssignEmployeeShiftPattern>(entity =>
            {
                entity.ToTable("HRM_AssignEmployeeShiftPattern");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AssignById).HasColumnName("AssignByID");

                entity.Property(e => e.AssignDate).HasColumnType("date");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.ShiftTypeId).HasColumnName("ShiftTypeID");
            });

            modelBuilder.Entity<HrmAttendance>(entity =>
            {
                entity.ToTable("HRM_Attendance");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.DeviceId)
                    .HasMaxLength(40)
                    .HasColumnName("DeviceID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.InsertUserId).HasColumnName("InsertUserID");

                entity.Property(e => e.SignInTime).HasMaxLength(50);

                entity.Property(e => e.SignOutTime).HasMaxLength(50);

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.HrmAttendances)
                    .HasForeignKey(d => d.Status)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HRM_Attendance_FT_AttendanceStatus");
            });

            modelBuilder.Entity<HrmAttendanceArchive>(entity =>
            {
                entity.ToTable("HRM_AttendanceArchive");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.DeviceId)
                    .HasMaxLength(40)
                    .HasColumnName("DeviceID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.InsertUserId).HasColumnName("InsertUserID");

                entity.Property(e => e.SignInTime).HasMaxLength(50);

                entity.Property(e => e.SignOutTime).HasMaxLength(50);
            });

            modelBuilder.Entity<HrmAttendanceDevice>(entity =>
            {
                entity.ToTable("HRM_AttendanceDevice");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.DepoId).HasColumnName("DepoID");

                entity.Property(e => e.DeviceId)
                    .HasMaxLength(20)
                    .HasColumnName("DeviceID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.RegionId).HasColumnName("RegionID");
            });

            modelBuilder.Entity<HrmCarInfo>(entity =>
            {
                entity.ToTable("HRM_CarInfo");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Capacity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CheasisNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Color)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EngineNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GearType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsuranceAmount).HasColumnType("money");

                entity.Property(e => e.InsuranceCompany)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsuranceExpireDate).HasColumnType("date");

                entity.Property(e => e.InsuranceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Make)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Model)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NextServiceDate).HasColumnType("date");

                entity.Property(e => e.Origin)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegistrationDate).HasColumnType("date");

                entity.Property(e => e.RegistrationNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RoadTaxAmount).HasColumnType("money");

                entity.Property(e => e.RoadTaxExpireDate).HasColumnType("date");

                entity.Property(e => e.RoadTaxNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrmDeviceInOut>(entity =>
            {
                entity.ToTable("HRM_DeviceInOut");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DeviceId)
                    .HasMaxLength(20)
                    .HasColumnName("DeviceID");

                entity.Property(e => e.EmpAccessId)
                    .HasMaxLength(20)
                    .HasColumnName("EmpAccessID");

                entity.Property(e => e.InOutDate).HasColumnType("date");

                entity.Property(e => e.InOutTime).HasMaxLength(10);
            });

            modelBuilder.Entity<HrmDeviceInOutArchive>(entity =>
            {
                entity.ToTable("HRM_DeviceInOutArchive");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.DeviceId)
                    .HasMaxLength(20)
                    .HasColumnName("DeviceID");

                entity.Property(e => e.EmpAccessId)
                    .HasMaxLength(20)
                    .HasColumnName("EmpAccessID");

                entity.Property(e => e.InOutDate).HasColumnType("date");

                entity.Property(e => e.InOutTime).HasMaxLength(10);
            });

            modelBuilder.Entity<HrmEmployeeSalaryInfo>(entity =>
            {
                entity.ToTable("HRM_EmployeeSalaryInfo");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Basic).HasColumnType("money");

                entity.Property(e => e.Da)
                    .HasColumnType("money")
                    .HasColumnName("DA");

                entity.Property(e => e.EmployeementId).HasColumnName("EmployeementID");

                entity.Property(e => e.GrossSalary).HasColumnType("money");

                entity.Property(e => e.HouseRent).HasColumnType("money");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ma)
                    .HasColumnType("money")
                    .HasColumnName("MA");

                entity.Property(e => e.Ta)
                    .HasColumnType("money")
                    .HasColumnName("TA");

                entity.Property(e => e.TotalSalary).HasColumnType("money");

                entity.HasOne(d => d.Employeement)
                    .WithMany(p => p.HrmEmployeeSalaryInfos)
                    .HasForeignKey(d => d.EmployeementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HRM_EmployeeSalaryInfo_HRM_PIEmployement");
            });

            modelBuilder.Entity<HrmEmployeeShiftPattern>(entity =>
            {
                entity.ToTable("HRM_EmployeeShiftPattern");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AssignPatternId).HasColumnName("AssignPatternID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.ShiftPatternId).HasColumnName("ShiftPatternID");

                entity.HasOne(d => d.AssignPattern)
                    .WithMany(p => p.HrmEmployeeShiftPatterns)
                    .HasForeignKey(d => d.AssignPatternId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HRM_EmployeeShiftPattern_HRM_AssignEmployeeShiftPattern");

                entity.HasOne(d => d.ShiftPattern)
                    .WithMany(p => p.HrmEmployeeShiftPatterns)
                    .HasForeignKey(d => d.ShiftPatternId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HRM_EmployeeShiftPattern_HRM_ShiftPattern");
            });

            modelBuilder.Entity<HrmEmployeeShiftPatternDetail>(entity =>
            {
                entity.ToTable("HRM_EmployeeShiftPatternDetail");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.EmpPatternId).HasColumnName("EmpPatternID");

                entity.Property(e => e.WorkingDay).HasColumnType("date");

                entity.HasOne(d => d.EmpPattern)
                    .WithMany(p => p.HrmEmployeeShiftPatternDetails)
                    .HasForeignKey(d => d.EmpPatternId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HRM_EmployeeShiftPatternDetail_HRM_EmployeeShiftPattern");
            });

            modelBuilder.Entity<HrmEmployeeTransfer>(entity =>
            {
                entity.ToTable("HRM_EmployeeTransfer");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ApplyDate).HasColumnType("date");

                entity.Property(e => e.EmployementId).HasColumnName("EmployementID");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.JoinDesignationId).HasColumnName("JoinDesignationID");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkingDuration)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Employement)
                    .WithMany(p => p.HrmEmployeeTransfers)
                    .HasForeignKey(d => d.EmployementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HRM_EmployeeTransfer_HRM_PIEmployement");
            });

            modelBuilder.Entity<HrmEmployeeWiseImage>(entity =>
            {
                entity.ToTable("HRM_EmployeeWiseImage");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CaptureDate).HasColumnType("date");

                entity.Property(e => e.ImageName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ImageTypeId).HasColumnName("ImageTypeID");

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ImageURL");

                entity.Property(e => e.Lastupdate).HasColumnType("datetime");

                entity.Property(e => e.Piid).HasColumnName("PIID");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrmEtchoicePlace>(entity =>
            {
                entity.ToTable("HRM_ETChoicePlace");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.ChoiceTypeId).HasColumnName("ChoiceTypeID");

                entity.Property(e => e.DepoId).HasColumnName("DepoID");

                entity.Property(e => e.DivisionId).HasColumnName("DivisionID");

                entity.Property(e => e.Etid).HasColumnName("ETID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.Property(e => e.TerritoryId).HasColumnName("TerritoryID");

                entity.HasOne(d => d.ChoiceType)
                    .WithMany(p => p.HrmEtchoicePlaces)
                    .HasForeignKey(d => d.ChoiceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HRM_ETChoicePlace_FT_ChoiceType");

                entity.HasOne(d => d.Et)
                    .WithMany(p => p.HrmEtchoicePlaces)
                    .HasForeignKey(d => d.Etid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HRM_ETChoicePlace_HRM_EmployeeTransfer");
            });

            modelBuilder.Entity<HrmEtpreviousWorkPlace>(entity =>
            {
                entity.ToTable("HRM_ETPreviousWorkPlace");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.DepoId).HasColumnName("DepoID");

                entity.Property(e => e.DivisionId).HasColumnName("DivisionID");

                entity.Property(e => e.Etid).HasColumnName("ETID");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.JoinDate).HasColumnType("date");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PostId).HasColumnName("PostID");

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.Property(e => e.TerritoryId).HasColumnName("TerritoryID");

                entity.HasOne(d => d.Et)
                    .WithMany(p => p.HrmEtpreviousWorkPlaces)
                    .HasForeignKey(d => d.Etid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HRM_ETPreviousWorkPalce_HRM_EmployeeTransfer");
            });

            modelBuilder.Entity<HrmFactoryWorker>(entity =>
            {
                entity.ToTable("HRM_FactoryWorker");

                entity.HasIndex(e => new { e.FactoryId, e.WorkerTypeId, e.FacAndWtcardNo, e.RegNo }, "IX_HRM_FactoryWorker")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.CardType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CheckerCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CheckerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateofBirth).HasColumnType("date");

                entity.Property(e => e.FacAndWtcardNo).HasColumnName("FacAndWTCardNo");

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.FactoryName).HasMaxLength(100);

                entity.Property(e => e.FathersName).HasMaxLength(500);

                entity.Property(e => e.ImageUrl)
                    .IsUnicode(false)
                    .HasColumnName("ImageURL");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MobileNo).HasMaxLength(50);

                entity.Property(e => e.MothersName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NationalIdno)
                    .HasMaxLength(100)
                    .HasColumnName("NationalIDNo");

                entity.Property(e => e.PhotoType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PostOfficeId).HasColumnName("PostOfficeID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.RegNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UnionId).HasColumnName("UnionID");

                entity.Property(e => e.VillageName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.WorkerName).HasMaxLength(500);

                entity.Property(e => e.WorkerPhoto).HasColumnType("image");

                entity.Property(e => e.WorkerTypeId).HasColumnName("WorkerTypeID");

                entity.HasOne(d => d.Factory)
                    .WithMany(p => p.HrmFactoryWorkers)
                    .HasForeignKey(d => d.FactoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HRM_FactoryWorker_SET_Factory");
            });

            modelBuilder.Entity<HrmFactoryWorkerBackup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HRM_FactoryWorkerBackup");

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.FactoryName).HasMaxLength(100);

                entity.Property(e => e.FathersName).HasMaxLength(500);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ImageUrl)
                    .IsUnicode(false)
                    .HasColumnName("ImageURL");

                entity.Property(e => e.MobileNo).HasMaxLength(50);

                entity.Property(e => e.NationalIdno)
                    .HasMaxLength(100)
                    .HasColumnName("NationalIDNo");

                entity.Property(e => e.WorkerName).HasMaxLength(500);

                entity.Property(e => e.WorkerPhoto).HasColumnType("image");
            });

            modelBuilder.Entity<HrmHoliday>(entity =>
            {
                entity.ToTable("HRM_Holiday");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InsertById).HasColumnName("InsertByID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<HrmLeaveAppDetail>(entity =>
            {
                entity.ToTable("HRM_LeaveAppDetail");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.LeaveAppId).HasColumnName("LeaveAppID");

                entity.HasOne(d => d.LeaveApp)
                    .WithMany(p => p.HrmLeaveAppDetails)
                    .HasForeignKey(d => d.LeaveAppId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HRM_LeaveAppDetail_HRM_LeaveApplication");
            });

            modelBuilder.Entity<HrmLeaveApplication>(entity =>
            {
                entity.ToTable("HRM_LeaveApplication");

                entity.HasIndex(e => new { e.EmployeeId, e.LeaveFrom, e.LeaveTo }, "IX_HRM_LeaveApplication")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AlternateConNo).HasMaxLength(20);

                entity.Property(e => e.AlternateEmployeeId).HasColumnName("AlternateEmployeeID");

                entity.Property(e => e.AppDate).HasColumnType("datetime");

                entity.Property(e => e.ApplyById).HasColumnName("ApplyByID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.LeaveFrom).HasColumnType("date");

                entity.Property(e => e.LeaveProfileId).HasColumnName("LeaveProfileID");

                entity.Property(e => e.LeaveTo).HasColumnType("date");

                entity.Property(e => e.Reason).HasMaxLength(500);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.HrmLeaveApplications)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HRM_LeaveApplication_HRM_PI");

                entity.HasOne(d => d.LeaveProfile)
                    .WithMany(p => p.HrmLeaveApplications)
                    .HasForeignKey(d => d.LeaveProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HRM_LeaveApplication_SET_HRLeaveProfile");
            });

            modelBuilder.Entity<HrmLeaveApproval>(entity =>
            {
                entity.ToTable("HRM_LeaveApproval");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ApprovedById).HasColumnName("ApprovedByID");

                entity.Property(e => e.LeaveId).HasColumnName("LeaveID");

                entity.HasOne(d => d.ApprovalStatusNavigation)
                    .WithMany(p => p.HrmLeaveApprovals)
                    .HasForeignKey(d => d.ApprovalStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HRM_LeaveApproval_FT_ApprovalStatus");

                entity.HasOne(d => d.ApprovedBy)
                    .WithMany(p => p.HrmLeaveApprovals)
                    .HasForeignKey(d => d.ApprovedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HRM_LeaveApproval_HRM_PI");

                entity.HasOne(d => d.Leave)
                    .WithMany(p => p.HrmLeaveApprovals)
                    .HasForeignKey(d => d.LeaveId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HRM_LeaveApproval_HRM_LeaveApplication");
            });

            modelBuilder.Entity<HrmLoanApplication>(entity =>
            {
                entity.ToTable("HRM_LoanApplication");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AppDate).HasColumnType("date");

                entity.Property(e => e.ApplyById).HasColumnName("ApplyByID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.GrossSalary).HasColumnType("money");

                entity.Property(e => e.LoanAmount).HasColumnType("money");

                entity.Property(e => e.LoanNeedDate).HasColumnType("date");

                entity.Property(e => e.LoanTypeId).HasColumnName("LoanTypeID");

                entity.Property(e => e.Note).HasMaxLength(200);

                entity.HasOne(d => d.ApplyBy)
                    .WithMany(p => p.HrmLoanApplicationApplyBies)
                    .HasForeignKey(d => d.ApplyById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HRM_LoanApplication_HRM_PI");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.HrmLoanApplicationEmployees)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HRM_LoanApplication_HRM_PI1");

                entity.HasOne(d => d.LoanType)
                    .WithMany(p => p.HrmLoanApplications)
                    .HasForeignKey(d => d.LoanTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HRM_LoanApplication_SET_LoanType");
            });

            modelBuilder.Entity<HrmLoanApproval>(entity =>
            {
                entity.ToTable("HRM_LoanApproval");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ApprovedById).HasColumnName("ApprovedByID");

                entity.Property(e => e.LoanId).HasColumnName("LoanID");

                entity.HasOne(d => d.ApprovedBy)
                    .WithMany(p => p.HrmLoanApprovals)
                    .HasForeignKey(d => d.ApprovedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HRM_LoanApproval_HRM_PI");

                entity.HasOne(d => d.Loan)
                    .WithMany(p => p.HrmLoanApprovals)
                    .HasForeignKey(d => d.LoanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HRM_LoanApproval_HRM_LoanApplication");
            });

            modelBuilder.Entity<HrmLoanInstallment>(entity =>
            {
                entity.ToTable("HRM_LoanInstallment");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.InstallmentAmount).HasColumnType("money");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.LoanId).HasColumnName("LoanID");

                entity.HasOne(d => d.Loan)
                    .WithMany(p => p.HrmLoanInstallments)
                    .HasForeignKey(d => d.LoanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HRM_LoanInstallment_HRM_LoanApplication");
            });

            modelBuilder.Entity<HrmLoanPaid>(entity =>
            {
                entity.ToTable("HRM_LoanPaid");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.InstallmentAmount).HasColumnType("money");

                entity.Property(e => e.LoanId).HasColumnName("LoanID");

                entity.Property(e => e.PayDate).HasColumnType("datetime");

                entity.HasOne(d => d.Loan)
                    .WithMany(p => p.HrmLoanPaids)
                    .HasForeignKey(d => d.LoanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HRM_LoanPaid_HRM_LoanApplication");
            });

            modelBuilder.Entity<HrmPayRollSalaryMaster>(entity =>
            {
                entity.ToTable("HRM_PayRollSalaryMaster");

                entity.HasIndex(e => new { e.Month, e.Year }, "IX_HRM_PayRollSalaryMaster")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ResponsibleId).HasColumnName("ResponsibleID");

                entity.Property(e => e.SalaryDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<HrmPayrollSalaryDetail>(entity =>
            {
                entity.ToTable("HRM_PayrollSalaryDetail");

                entity.HasIndex(e => new { e.SalaryMasterId, e.EmployeeId }, "IX_HRM_PayrollSalaryDetail")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AbsentDeduction).HasColumnType("money");

                entity.Property(e => e.AdvanceSalaryDeduction).HasColumnType("money");

                entity.Property(e => e.BasicSalary).HasColumnType("money");

                entity.Property(e => e.Bonus).HasColumnType("money");

                entity.Property(e => e.Da)
                    .HasColumnType("money")
                    .HasColumnName("DA");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.Gratuity).HasColumnType("money");

                entity.Property(e => e.GrossSalary).HasColumnType("money");

                entity.Property(e => e.HouseRent).HasColumnType("money");

                entity.Property(e => e.IsPrinted).HasDefaultValueSql("((0))");

                entity.Property(e => e.LoanDeduction).HasColumnType("money");

                entity.Property(e => e.MedicalAllowance).HasColumnType("money");

                entity.Property(e => e.NetSalary).HasColumnType("money");

                entity.Property(e => e.Pf)
                    .HasColumnType("money")
                    .HasColumnName("PF");

                entity.Property(e => e.Pfcompany)
                    .HasColumnType("money")
                    .HasColumnName("PFCompany");

                entity.Property(e => e.SalaryMasterId).HasColumnName("SalaryMasterID");

                entity.Property(e => e.Ta)
                    .HasColumnType("money")
                    .HasColumnName("TA");

                entity.Property(e => e.TotalSalary).HasColumnType("money");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.HrmPayrollSalaryDetails)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HRM_PayrollSalaryDetail_HRM_PI");

                entity.HasOne(d => d.SalaryMaster)
                    .WithMany(p => p.HrmPayrollSalaryDetails)
                    .HasForeignKey(d => d.SalaryMasterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HRM_PayrollSalaryDetail_HRM_PayRollSalaryMaster");
            });

            modelBuilder.Entity<HrmPfaccount>(entity =>
            {
                entity.ToTable("HRM_PFAccount");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.Pfno)
                    .HasMaxLength(50)
                    .HasColumnName("PFNo");
            });

            modelBuilder.Entity<HrmPfaccountDetail>(entity =>
            {
                entity.ToTable("HRM_PFAccountDetail");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CompanyShareInPc)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("CompanyShareInPC");

                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.Property(e => e.PfaccId).HasColumnName("PFAccID");

                entity.Property(e => e.SelfShareInPc)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("SelfShareInPC");

                entity.HasOne(d => d.Pfacc)
                    .WithMany(p => p.HrmPfaccountDetails)
                    .HasForeignKey(d => d.PfaccId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HRM_PFAccountDetail_HRM_PFAccount");
            });

            modelBuilder.Entity<HrmPfdddetail>(entity =>
            {
                entity.ToTable("HRM_PFDDDetail");

                entity.HasIndex(e => new { e.PfaccId, e.Month, e.Year }, "NonClusteredIndex-20180318-130625")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.BasicSalary).HasColumnType("money");

                entity.Property(e => e.CompanyShare).HasColumnType("money");

                entity.Property(e => e.EmployeeShare).HasColumnType("money");

                entity.Property(e => e.Graturity).HasColumnType("money");

                entity.Property(e => e.PfaccId).HasColumnName("PFAccID");

                entity.Property(e => e.Pfddid).HasColumnName("PFDDID");

                entity.Property(e => e.TransactionId).HasColumnName("TransactionID");

                entity.HasOne(d => d.Pfacc)
                    .WithMany(p => p.HrmPfdddetails)
                    .HasForeignKey(d => d.PfaccId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HRM_PFDDDetail_HRM_PFAccount");

                entity.HasOne(d => d.Pfdd)
                    .WithMany(p => p.HrmPfdddetails)
                    .HasForeignKey(d => d.Pfddid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HRM_PayrollProvidentFund_HRM_PayrollProvidentFundMaster");

                entity.HasOne(d => d.Transaction)
                    .WithMany(p => p.HrmPfdddetails)
                    .HasForeignKey(d => d.TransactionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HRM_PFDDDetail_HRM_PFTransaction");
            });

            modelBuilder.Entity<HrmPfddinfo>(entity =>
            {
                entity.ToTable("HRM_PFDDInfo");

                entity.HasIndex(e => e.Ddno, "NonClusteredIndex-20180318-130557")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Ddamount)
                    .HasColumnType("money")
                    .HasColumnName("DDAmount");

                entity.Property(e => e.Ddno)
                    .HasMaxLength(100)
                    .HasColumnName("DDNo")
                    .IsFixedLength();

                entity.Property(e => e.ResponsibleId).HasColumnName("ResponsibleID");
            });

            modelBuilder.Entity<HrmPfinstallment>(entity =>
            {
                entity.ToTable("HRM_PFInstallment");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            });

            modelBuilder.Entity<HrmPfopeningBalance>(entity =>
            {
                entity.ToTable("HRM_PFOpeningBalance");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.GraturityAmount).HasColumnType("money");

                entity.Property(e => e.PfaccId).HasColumnName("PFAccID");

                entity.Property(e => e.Pfamount)
                    .HasColumnType("money")
                    .HasColumnName("PFAmount");

                entity.Property(e => e.ResponsibleId).HasColumnName("ResponsibleID");

                entity.Property(e => e.TransactionId).HasColumnName("TransactionID");

                entity.HasOne(d => d.Pfacc)
                    .WithMany(p => p.HrmPfopeningBalances)
                    .HasForeignKey(d => d.PfaccId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HRM_PFOpeningBalance_HRM_PFAccount");

                entity.HasOne(d => d.Transaction)
                    .WithMany(p => p.HrmPfopeningBalances)
                    .HasForeignKey(d => d.TransactionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HRM_PFOpeningBalance_HRM_PFTransaction");
            });

            modelBuilder.Entity<HrmPfrule>(entity =>
            {
                entity.ToTable("HRM_PFRules");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompanyShareInPc)
                    .HasColumnType("decimal(5, 3)")
                    .HasColumnName("CompanyShareInPC");

                entity.Property(e => e.GraturityInPc)
                    .HasColumnType("decimal(5, 3)")
                    .HasColumnName("GraturityInPC");

                entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.SelfShareInPc)
                    .HasColumnType("decimal(5, 3)")
                    .HasColumnName("SelfShareInPC");
            });

            modelBuilder.Entity<HrmPftransaction>(entity =>
            {
                entity.ToTable("HRM_PFTransaction");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.Balance).HasColumnType("money");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.PfaccId).HasColumnName("PFAccID");

                entity.HasOne(d => d.Pfacc)
                    .WithMany(p => p.HrmPftransactions)
                    .HasForeignKey(d => d.PfaccId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HRM_PFTransaction_HRM_PFAccount");
            });

            modelBuilder.Entity<HrmPi>(entity =>
            {
                entity.ToTable("HRM_PI");

                entity.HasIndex(e => e.EmployeeId, "IX_HRM_PI")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.BloodGroupId).HasColumnName("BloodGroupID");

                entity.Property(e => e.ContactNo1).HasMaxLength(20);

                entity.Property(e => e.ContactNo2).HasMaxLength(20);

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("EMail");

                entity.Property(e => e.EmployeeId).HasMaxLength(50);

                entity.Property(e => e.FatherName).HasMaxLength(50);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.HomePhone).HasMaxLength(20);

                entity.Property(e => e.JoinDate).HasColumnType("date");

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.MiddleName).HasMaxLength(50);

                entity.Property(e => e.MotherName).HasMaxLength(50);

                entity.Property(e => e.NationalIdno)
                    .HasMaxLength(50)
                    .HasColumnName("NationalIDNo");

                entity.Property(e => e.Nationality).HasMaxLength(50);

                entity.Property(e => e.NickName).HasMaxLength(50);

                entity.Property(e => e.ParmanentCity).HasMaxLength(50);

                entity.Property(e => e.ParmanentZip).HasMaxLength(50);

                entity.Property(e => e.PassportNo).HasMaxLength(50);

                entity.Property(e => e.Pfid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PFId");

                entity.Property(e => e.PhotoPath).HasMaxLength(500);

                entity.Property(e => e.PresentCity).HasMaxLength(50);

                entity.Property(e => e.PresentZip).HasMaxLength(50);

                entity.Property(e => e.ProximityId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ProximityID");

                entity.HasOne(d => d.Gender)
                    .WithMany(p => p.HrmPis)
                    .HasForeignKey(d => d.GenderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HRM_PI_FT_Gender");
            });

            modelBuilder.Entity<HrmPiemergencyContact>(entity =>
            {
                entity.ToTable("HRM_PIEmergencyContacts");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ContactName).HasMaxLength(50);

                entity.Property(e => e.HomeTele).HasMaxLength(20);

                entity.Property(e => e.Mobile).HasMaxLength(20);

                entity.Property(e => e.Piid).HasColumnName("PIID");

                entity.Property(e => e.Relationship).HasMaxLength(50);

                entity.Property(e => e.WorkTele).HasMaxLength(20);
            });

            modelBuilder.Entity<HrmPiemployement>(entity =>
            {
                entity.ToTable("HRM_PIEmployement");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.Basic).HasColumnType("money");

                entity.Property(e => e.CityAllowance).HasColumnType("money");

                entity.Property(e => e.Conveyence).HasColumnType("money");

                entity.Property(e => e.DepoId).HasColumnName("DepoID");

                entity.Property(e => e.DivisionId).HasColumnName("DivisionID");

                entity.Property(e => e.EmployeeCategoryId).HasColumnName("EmployeeCategoryID");

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.HouseRent).HasColumnType("money");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.JobPositionId).HasColumnName("JobPositionID");

                entity.Property(e => e.JoiningDate).HasColumnType("date");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MedicalAllowance).HasColumnType("money");

                entity.Property(e => e.PayGradeId).HasColumnName("PayGradeID");

                entity.Property(e => e.Piid).HasColumnName("PIID");

                entity.Property(e => e.PpendDate)
                    .HasColumnType("date")
                    .HasColumnName("PPEndDate");

                entity.Property(e => e.PpstartDate)
                    .HasColumnType("date")
                    .HasColumnName("PPStartDate");

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.Property(e => e.TerritoryId).HasColumnName("TerritoryID");

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.HrmPiemployements)
                    .HasForeignKey(d => d.AreaId)
                    .HasConstraintName("FK_HRM_PIEmployement_SET_Area");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.HrmPiemployements)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_HRM_PIEmployement_SET_Department");

                entity.HasOne(d => d.Depo)
                    .WithMany(p => p.HrmPiemployements)
                    .HasForeignKey(d => d.DepoId)
                    .HasConstraintName("FK_HRM_PIEmployement_SET_Depo");

                entity.HasOne(d => d.Designation)
                    .WithMany(p => p.HrmPiemployements)
                    .HasForeignKey(d => d.DesignationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HRM_PIEmployement_SET_HRDesignation");

                entity.HasOne(d => d.Division)
                    .WithMany(p => p.HrmPiemployements)
                    .HasForeignKey(d => d.DivisionId)
                    .HasConstraintName("FK_HRM_PIEmployement_SET_Division");

                entity.HasOne(d => d.Factory)
                    .WithMany(p => p.HrmPiemployements)
                    .HasForeignKey(d => d.FactoryId)
                    .HasConstraintName("FK_HRM_PIEmployement_SET_Factory");

                entity.HasOne(d => d.Pi)
                    .WithMany(p => p.HrmPiemployements)
                    .HasForeignKey(d => d.Piid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HRM_PIEmployement_HRM_PI");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.HrmPiemployements)
                    .HasForeignKey(d => d.RegionId)
                    .HasConstraintName("FK_HRM_PIEmployement_SET_Region");

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.HrmPiemployements)
                    .HasForeignKey(d => d.SectionId)
                    .HasConstraintName("FK_HRM_PIEmployement_SET_Section");

                entity.HasOne(d => d.Territory)
                    .WithMany(p => p.HrmPiemployements)
                    .HasForeignKey(d => d.TerritoryId)
                    .HasConstraintName("FK_HRM_PIEmployement_SET_Territory");
            });

            modelBuilder.Entity<HrmPiemploymentDetail>(entity =>
            {
                entity.ToTable("HRM_PIEmploymentDetail");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.Basic).HasColumnType("money");

                entity.Property(e => e.CityAllowance).HasColumnType("money");

                entity.Property(e => e.Conveyence).HasColumnType("money");

                entity.Property(e => e.DepoId).HasColumnName("DepoID");

                entity.Property(e => e.DivisionId).HasColumnName("DivisionID");

                entity.Property(e => e.EmployeeCategoryId).HasColumnName("EmployeeCategoryID");

                entity.Property(e => e.EmploymentId).HasColumnName("EmploymentID");

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.HostId).HasMaxLength(100);

                entity.Property(e => e.HouseRent).HasColumnType("money");

                entity.Property(e => e.JobPositionId).HasColumnName("JobPositionID");

                entity.Property(e => e.JoiningDate).HasColumnType("date");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.MedicalAllowance).HasColumnType("money");

                entity.Property(e => e.PayGradeId).HasColumnName("PayGradeID");

                entity.Property(e => e.Piid).HasColumnName("PIID");

                entity.Property(e => e.PpendDate)
                    .HasColumnType("date")
                    .HasColumnName("PPEndDate");

                entity.Property(e => e.PpstartDate)
                    .HasColumnType("date")
                    .HasColumnName("PPStartDate");

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.Property(e => e.TerritoryId).HasColumnName("TerritoryID");
            });

            modelBuilder.Entity<HrmPifamilyInfo>(entity =>
            {
                entity.ToTable("HRM_PIFamilyInfo");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.MemberName).HasMaxLength(100);

                entity.Property(e => e.OthersInfo).HasMaxLength(500);

                entity.Property(e => e.Piid).HasColumnName("PIID");

                entity.Property(e => e.Relationship).HasMaxLength(100);

                entity.HasOne(d => d.Pi)
                    .WithMany(p => p.HrmPifamilyInfos)
                    .HasForeignKey(d => d.Piid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HRM_PIFamilyInfo_HRM_PI");
            });

            modelBuilder.Entity<HrmPiincrement>(entity =>
            {
                entity.HasKey(e => e.IncrementId);

                entity.ToTable("HRM_PIIncrement");

                entity.Property(e => e.IncrementId)
                    .ValueGeneratedNever()
                    .HasColumnName("IncrementID");

                entity.Property(e => e.Basic).HasColumnType("money");

                entity.Property(e => e.Da)
                    .HasColumnType("money")
                    .HasColumnName("DA");

                entity.Property(e => e.Hra)
                    .HasColumnType("money")
                    .HasColumnName("HRA");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ma)
                    .HasColumnType("money")
                    .HasColumnName("MA");

                entity.Property(e => e.PayGradeId).HasColumnName("PayGradeID");

                entity.Property(e => e.Pisid).HasColumnName("PISID");

                entity.Property(e => e.Ta)
                    .HasColumnType("money")
                    .HasColumnName("TA");

                entity.HasOne(d => d.PayGrade)
                    .WithMany(p => p.HrmPiincrements)
                    .HasForeignKey(d => d.PayGradeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HRM_PIIncrement_SET_PayGrade");

                entity.HasOne(d => d.Pis)
                    .WithMany(p => p.HrmPiincrements)
                    .HasForeignKey(d => d.Pisid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HRM_PIIncrement_HRM_PI");
            });

            modelBuilder.Entity<HrmPiincrementRawDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HRM_PIIncrementRawData");

                entity.Property(e => e.Basic).HasColumnType("money");

                entity.Property(e => e.Da)
                    .HasColumnType("money")
                    .HasColumnName("DA");

                entity.Property(e => e.Hra)
                    .HasColumnType("money")
                    .HasColumnName("HRA");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.Ma)
                    .HasColumnType("money")
                    .HasColumnName("MA");

                entity.Property(e => e.PayGradeId).HasColumnName("PayGradeID");

                entity.Property(e => e.Pisid).HasColumnName("PISID");

                entity.Property(e => e.Ta)
                    .HasColumnType("money")
                    .HasColumnName("TA");
            });

            modelBuilder.Entity<HrmPijobExperience>(entity =>
            {
                entity.ToTable("HRM_PIJobExperience");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Comments).HasMaxLength(200);

                entity.Property(e => e.Company).HasMaxLength(100);

                entity.Property(e => e.Designation).HasMaxLength(100);

                entity.Property(e => e.FromDt).HasColumnType("date");

                entity.Property(e => e.Piid).HasColumnName("PIID");

                entity.Property(e => e.Responsibility).HasMaxLength(200);

                entity.Property(e => e.ToDt).HasColumnType("date");

                entity.HasOne(d => d.Pi)
                    .WithMany(p => p.HrmPijobExperiences)
                    .HasForeignKey(d => d.Piid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HRM_PIJobExperience_HRM_PI");
            });

            modelBuilder.Entity<HrmPinominee>(entity =>
            {
                entity.ToTable("HRM_PINominee");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Address).HasMaxLength(200);

                entity.Property(e => e.MobileNo).HasMaxLength(20);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.NationalId)
                    .HasMaxLength(50)
                    .HasColumnName("NationalID");

                entity.Property(e => e.Piid).HasColumnName("PIID");

                entity.Property(e => e.Relationship).HasMaxLength(50);

                entity.HasOne(d => d.Pi)
                    .WithMany(p => p.HrmPinominees)
                    .HasForeignKey(d => d.Piid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HRM_PINominee_HRM_PI");
            });

            modelBuilder.Entity<HrmPipromotion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HRM_PIPromotion");

                entity.Property(e => e.EmployeeCategoryId).HasColumnName("EmployeeCategoryID");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.JobPositionId).HasColumnName("JobPositionID");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PayGradeId).HasColumnName("PayGradeID");

                entity.Property(e => e.Pisid).HasColumnName("PISID");

                entity.Property(e => e.PromotionId).HasColumnName("PromotionID");

                entity.HasOne(d => d.Designation)
                    .WithMany()
                    .HasForeignKey(d => d.DesignationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HRM_PIPromotion_SET_HRDesignation");

                entity.HasOne(d => d.EmployeeCategory)
                    .WithMany()
                    .HasForeignKey(d => d.EmployeeCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HRM_PIPromotion_SET_HREmployeeCategory");

                entity.HasOne(d => d.JobPosition)
                    .WithMany()
                    .HasForeignKey(d => d.JobPositionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HRM_PIPromotion_SET_JobPosition");

                entity.HasOne(d => d.PayGrade)
                    .WithMany()
                    .HasForeignKey(d => d.PayGradeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HRM_PIPromotion_SET_PayGrade");

                entity.HasOne(d => d.Pis)
                    .WithMany()
                    .HasForeignKey(d => d.Pisid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HRM_PIPromotion_HRM_PI");
            });

            modelBuilder.Entity<HrmPipromotionRawDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HRM_PIPromotionRawData");

                entity.Property(e => e.EmployeeCategoryId).HasColumnName("EmployeeCategoryID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.JobPositionId).HasColumnName("JobPositionID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.PayGradeId).HasColumnName("PayGradeID");

                entity.Property(e => e.Pisid).HasColumnName("PISID");
            });

            modelBuilder.Entity<HrmPiqualification>(entity =>
            {
                entity.ToTable("HRM_PIQualifications");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Achievement).HasMaxLength(50);

                entity.Property(e => e.DegreeTitle).HasMaxLength(100);

                entity.Property(e => e.Duration).HasMaxLength(9);

                entity.Property(e => e.GpaorClass)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GPAOrClass");

                entity.Property(e => e.Institute).HasMaxLength(100);

                entity.Property(e => e.MajorOrSpecialization).HasMaxLength(50);

                entity.Property(e => e.Piid).HasColumnName("PIID");

                entity.HasOne(d => d.Pi)
                    .WithMany(p => p.HrmPiqualifications)
                    .HasForeignKey(d => d.Piid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HRM_PIQualifications_HRM_PI");
            });

            modelBuilder.Entity<HrmPireference>(entity =>
            {
                entity.ToTable("HRM_PIReferences");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Address).HasMaxLength(200);

                entity.Property(e => e.Designation).HasMaxLength(200);

                entity.Property(e => e.Email).HasMaxLength(20);

                entity.Property(e => e.MobileNo).HasMaxLength(20);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Organization).HasMaxLength(200);

                entity.Property(e => e.Phone).HasMaxLength(20);

                entity.Property(e => e.Piid).HasColumnName("PIID");

                entity.Property(e => e.Relationship).HasMaxLength(50);
            });

            modelBuilder.Entity<HrmPitermination>(entity =>
            {
                entity.ToTable("HRM_PITermination");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ApplyById).HasColumnName("ApplyByID");

                entity.Property(e => e.ApplyDate).HasColumnType("date");

                entity.Property(e => e.EffectiveFromDate).HasColumnType("date");

                entity.Property(e => e.Piid).HasColumnName("PIID");

                entity.Property(e => e.Reason).HasMaxLength(200);

                entity.HasOne(d => d.ApplyBy)
                    .WithMany(p => p.HrmPiterminationApplyBies)
                    .HasForeignKey(d => d.ApplyById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HRM_PITermination_HRM_PI1");

                entity.HasOne(d => d.Pi)
                    .WithMany(p => p.HrmPiterminationPis)
                    .HasForeignKey(d => d.Piid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HRM_PITermination_HRM_PI");

                entity.HasOne(d => d.TerminationTypeNavigation)
                    .WithMany(p => p.HrmPiterminations)
                    .HasForeignKey(d => d.TerminationType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HRM_PITermination_FT_TerminationType");
            });

            modelBuilder.Entity<HrmPitransfer>(entity =>
            {
                entity.HasKey(e => e.TransferId);

                entity.ToTable("HRM_PITransfer");

                entity.Property(e => e.TransferId)
                    .ValueGeneratedNever()
                    .HasColumnName("TransferID");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.DepoId).HasColumnName("DepoID");

                entity.Property(e => e.DivisionId).HasColumnName("DivisionID");

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Pisid).HasColumnName("PISID");

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.TerritoryId).HasColumnName("TerritoryID");

                entity.Property(e => e.TransferDate).HasColumnType("date");

                entity.HasOne(d => d.Depo)
                    .WithMany(p => p.HrmPitransfers)
                    .HasForeignKey(d => d.DepoId)
                    .HasConstraintName("FK_HRM_PITransfer_SET_Depo");

                entity.HasOne(d => d.Factory)
                    .WithMany(p => p.HrmPitransfers)
                    .HasForeignKey(d => d.FactoryId)
                    .HasConstraintName("FK_HRM_PITransfer_SET_Factory");

                entity.HasOne(d => d.Pis)
                    .WithMany(p => p.HrmPitransfers)
                    .HasForeignKey(d => d.Pisid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HRM_PITransfer_HRM_PI");

                entity.HasOne(d => d.Territory)
                    .WithMany(p => p.HrmPitransfers)
                    .HasForeignKey(d => d.TerritoryId)
                    .HasConstraintName("FK_HRM_PITransfer_SET_Territory");
            });

            modelBuilder.Entity<HrmPitransferRawDatum>(entity =>
            {
                entity.ToTable("HRM_PITransferRawData");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.DepoId).HasColumnName("DepoID");

                entity.Property(e => e.DivisionId).HasColumnName("DivisionID");

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.Pisid).HasColumnName("PISID");

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.TerritoryId).HasColumnName("TerritoryID");

                entity.Property(e => e.TransferDate).HasColumnType("date");
            });

            modelBuilder.Entity<HrmPreviousEmployeement>(entity =>
            {
                entity.ToTable("HRM_PreviousEmployeement");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.Basic).HasColumnType("money");

                entity.Property(e => e.DepoId).HasColumnName("DepoID");

                entity.Property(e => e.DivisionId).HasColumnName("DivisionID");

                entity.Property(e => e.EmployeeCategoryId).HasColumnName("EmployeeCategoryID");

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.JobPositionId).HasColumnName("JobPositionID");

                entity.Property(e => e.JoiningDate).HasColumnType("date");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.PayGradeId).HasColumnName("PayGradeID");

                entity.Property(e => e.Piid).HasColumnName("PIID");

                entity.Property(e => e.PpendDate)
                    .HasColumnType("date")
                    .HasColumnName("PPEndDate");

                entity.Property(e => e.PpstartDate)
                    .HasColumnType("date")
                    .HasColumnName("PPStartDate");

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.Property(e => e.TerritoryId).HasColumnName("TerritoryID");
            });

            modelBuilder.Entity<HrmShiftPattern>(entity =>
            {
                entity.ToTable("HRM_ShiftPattern");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.PatternName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShiftTypeId).HasColumnName("ShiftTypeID");
            });

            modelBuilder.Entity<HrmShiftPatternDetail>(entity =>
            {
                entity.ToTable("HRM_ShiftPatternDetail");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ShiftPatternId).HasColumnName("ShiftPatternID");

                entity.Property(e => e.ShiftProfileId).HasColumnName("ShiftProfileID");

                entity.Property(e => e.WorkingDayId).HasColumnName("WorkingDayID");

                entity.HasOne(d => d.ShiftPattern)
                    .WithMany(p => p.HrmShiftPatternDetails)
                    .HasForeignKey(d => d.ShiftPatternId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HRM_ShiftPatternDetail_HRM_ShiftPattern");

                entity.HasOne(d => d.ShiftProfile)
                    .WithMany(p => p.HrmShiftPatternDetails)
                    .HasForeignKey(d => d.ShiftProfileId)
                    .HasConstraintName("FK_HRM_ShiftPatternDetail_HRM_ShiftProfile");

                entity.HasOne(d => d.WorkingDay)
                    .WithMany(p => p.HrmShiftPatternDetails)
                    .HasForeignKey(d => d.WorkingDayId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HRM_ShiftPatternDetail_FT_WorkingDays");
            });

            modelBuilder.Entity<HrmShiftProfile>(entity =>
            {
                entity.ToTable("HRM_ShiftProfile");

                entity.HasIndex(e => new { e.ShiftTypeId, e.ProfileName }, "IX_HRM_ShiftProfile")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ProfileName).HasMaxLength(50);

                entity.Property(e => e.ShiftTypeId).HasColumnName("ShiftTypeID");

                entity.HasOne(d => d.ShiftType)
                    .WithMany(p => p.HrmShiftProfiles)
                    .HasForeignKey(d => d.ShiftTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HRM_ShiftProfile_SET_HRMShiftType");
            });

            modelBuilder.Entity<HrmShiftProfileItem>(entity =>
            {
                entity.ToTable("HRM_ShiftProfileItem");

                entity.HasIndex(e => new { e.ProfileId, e.ProfileItemId }, "IX_HRM_ShiftProfileItem")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

                entity.Property(e => e.ProfileItemId).HasColumnName("ProfileItemID");

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.HrmShiftProfileItems)
                    .HasForeignKey(d => d.ProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HRM_ShiftProfileItem_HRM_ShiftProfile");

                entity.HasOne(d => d.ProfileItem)
                    .WithMany(p => p.HrmShiftProfileItems)
                    .HasForeignKey(d => d.ProfileItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HRM_ShiftProfileItem_FT_ShiftProfileItem");
            });

            modelBuilder.Entity<HrmTerminationApproval>(entity =>
            {
                entity.ToTable("HRM_TerminationApproval");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ApprovedById).HasColumnName("ApprovedByID");

                entity.Property(e => e.TerminationId).HasColumnName("TerminationID");

                entity.HasOne(d => d.ApprovedBy)
                    .WithMany(p => p.HrmTerminationApprovals)
                    .HasForeignKey(d => d.ApprovedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HRM_TerminationApproval_HRM_PI");

                entity.HasOne(d => d.Termination)
                    .WithMany(p => p.HrmTerminationApprovals)
                    .HasForeignKey(d => d.TerminationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HRM_TerminationApproval_HRM_PITermination");
            });

            modelBuilder.Entity<HrmTourAttendance>(entity =>
            {
                entity.ToTable("HRM_TourAttendance");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.TourName).HasMaxLength(200);

                entity.Property(e => e.TourTypeId).HasColumnName("TourTypeID");

                entity.HasOne(d => d.TourType)
                    .WithMany(p => p.HrmTourAttendances)
                    .HasForeignKey(d => d.TourTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HRM_TourAttendance_SET_TourType");
            });

            modelBuilder.Entity<HrmTourAttendanceDetail>(entity =>
            {
                entity.ToTable("HRM_TourAttendanceDetail");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Taid).HasColumnName("TAID");

                entity.HasOne(d => d.Ta)
                    .WithMany(p => p.HrmTourAttendanceDetails)
                    .HasForeignKey(d => d.Taid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HRM_TourAttendanceDetail_HRM_TourAttendance");
            });

            modelBuilder.Entity<HrmWorkingDay>(entity =>
            {
                entity.ToTable("HRM_WorkingDay");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DayName).HasMaxLength(50);
            });

            modelBuilder.Entity<Log>(entity =>
            {
                entity.ToTable("Log");

                entity.Property(e => e.LogId).HasColumnName("LogID");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<OocAreaVisitPlan>(entity =>
            {
                entity.HasKey(e => e.PlanId);

                entity.ToTable("OOC_AreaVisitPlan");

                entity.Property(e => e.PlanId)
                    .ValueGeneratedNever()
                    .HasColumnName("PlanID");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.EmploymentId).HasColumnName("EmploymentID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");
            });

            modelBuilder.Entity<OocDailySmokerContact>(entity =>
            {
                entity.ToTable("OOC_DailySmokerContact");

                entity.HasIndex(e => new { e.OutletId, e.EmployementId, e.ContactDate, e.Name, e.MobileNo }, "IX_OOC_DailySmokerContact")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ContactDate).HasColumnType("date");

                entity.Property(e => e.EmployementId).HasColumnName("EmployementID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.MobileNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.OutletId).HasColumnName("OutletID");

                entity.Property(e => e.PreBrand).HasMaxLength(50);

                entity.Property(e => e.Profession)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OocOutletSaleTargetPlan>(entity =>
            {
                entity.HasKey(e => e.PlanId);

                entity.ToTable("OOC_OutletSaleTargetPlan");

                entity.HasIndex(e => new { e.EmploymentId, e.OutletId, e.Date, e.Shift }, "IX_OOC_OutletSaleTargetPlan")
                    .IsUnique();

                entity.Property(e => e.PlanId)
                    .ValueGeneratedNever()
                    .HasColumnName("PlanID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.EmploymentId).HasColumnName("EmploymentID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.OutletId).HasColumnName("OutletID");
            });

            modelBuilder.Entity<OocOutletSaleTargetPlanDelDatum>(entity =>
            {
                entity.ToTable("OOC_OutletSaleTargetPlan_DelData");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.EmploymentId).HasColumnName("EmploymentID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.OutletId).HasColumnName("OutletID");

                entity.Property(e => e.PlanId).HasColumnName("PlanID");
            });

            modelBuilder.Entity<OocOutletSaleTargetPlanItem>(entity =>
            {
                entity.HasKey(e => e.TplanItemId);

                entity.ToTable("OOC_OutletSaleTargetPlanItem");

                entity.Property(e => e.TplanItemId)
                    .ValueGeneratedNever()
                    .HasColumnName("TPlanItemID");

                entity.Property(e => e.InsertUserId).HasColumnName("InsertUserID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TplanId).HasColumnName("TPlanID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OocOutletSaleTargetPlanItems)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OOC_OutletSaleTargetPlanItem_SET_Product");

                entity.HasOne(d => d.Tplan)
                    .WithMany(p => p.OocOutletSaleTargetPlanItems)
                    .HasForeignKey(d => d.TplanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TargetPlanItem_OOC_OutletSaleTargetPlan");
            });

            modelBuilder.Entity<OocOutletSaleTargetPlanItemDelDatum>(entity =>
            {
                entity.ToTable("OOC_OutletSaleTargetPlanItem_DelData");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.InsertUserId).HasColumnName("InsertUserID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TplanId).HasColumnName("TPlanID");

                entity.Property(e => e.TplanItemId).HasColumnName("TPlanItemID");
            });

            modelBuilder.Entity<OocOutletVisit>(entity =>
            {
                entity.ToTable("OOC_OutletVisit");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.EmployementId).HasColumnName("EmployementID");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OutletId).HasColumnName("OutletID");

                entity.Property(e => e.SalesRefuseTypeId).HasColumnName("SalesRefuseTypeID");

                entity.Property(e => e.VisitDate).HasColumnType("date");

                entity.HasOne(d => d.SalesRefuseType)
                    .WithMany(p => p.OocOutletVisits)
                    .HasForeignKey(d => d.SalesRefuseTypeId)
                    .HasConstraintName("FK_OOC_OutletVisit_OOC_SalesRefuseType");

                entity.HasOne(d => d.VisibiltyInfo)
                    .WithMany(p => p.OocOutletVisits)
                    .HasForeignKey(d => d.VisibiltyInfoId)
                    .HasConstraintName("FK_OOC_OutletVisit_OOC_VisibilityInfo");
            });

            modelBuilder.Entity<OocOutletVisitPlan>(entity =>
            {
                entity.HasKey(e => e.PlanId);

                entity.ToTable("OOC_OutletVisitPlan");

                entity.Property(e => e.PlanId)
                    .ValueGeneratedNever()
                    .HasColumnName("PlanID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.EmploymentId).HasColumnName("EmploymentID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.OutletId).HasColumnName("OutletID");
            });

            modelBuilder.Entity<OocSalesRefuseType>(entity =>
            {
                entity.ToTable("OOC_SalesRefuseType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.SalesRefuseType).HasMaxLength(50);

                entity.Property(e => e.SalesRefuseTypeCode).HasMaxLength(50);
            });

            modelBuilder.Entity<OocSmokerContact>(entity =>
            {
                entity.ToTable("OOC_SmokerContact");

                entity.HasIndex(e => new { e.OutletId, e.EmployementId, e.ContactDate, e.Name, e.MobileNo }, "IX_OOC_SmokerContact")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ContactDate).HasColumnType("date");

                entity.Property(e => e.EmployementId).HasColumnName("EmployementID");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MobileNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.OutletId).HasColumnName("OutletID");

                entity.Property(e => e.PreBrand).HasMaxLength(50);

                entity.Property(e => e.Profession)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Visit)
                    .WithMany(p => p.OocSmokerContacts)
                    .HasForeignKey(d => d.VisitId)
                    .HasConstraintName("FK_OOC_SmokerContact_OOC_OutletVisit");
            });

            modelBuilder.Entity<OocSmokerContactBak>(entity =>
            {
                entity.ToTable("OOC_SmokerContactBak");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ContactDate).HasColumnType("date");

                entity.Property(e => e.EmployementId).HasColumnName("EmployementID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.MobileNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.OutletId).HasColumnName("OutletID");

                entity.Property(e => e.PreBrand).HasMaxLength(50);

                entity.Property(e => e.Profession)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OocSmokerContactDetail>(entity =>
            {
                entity.ToTable("OOC_SmokerContactDetail");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CompanyBrand).HasMaxLength(50);

                entity.Property(e => e.ContactDate).HasColumnType("date");

                entity.Property(e => e.CurrentBrand).HasMaxLength(50);

                entity.Property(e => e.EmployementId).HasColumnName("EmployementID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.MarketName).HasMaxLength(50);

                entity.Property(e => e.OutletId).HasColumnName("OutletID");

                entity.Property(e => e.Remarks).HasMaxLength(200);

                entity.Property(e => e.SmokerId).HasColumnName("SmokerID");

                entity.Property(e => e.UnionId).HasColumnName("UnionID");

                entity.Property(e => e.VillageRouteName).HasMaxLength(50);

                entity.Property(e => e.VisitId).HasColumnName("VisitID");
            });

            modelBuilder.Entity<OocVisibilityInfo>(entity =>
            {
                entity.ToTable("OOC_VisibilityInfo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ImageUrl).HasMaxLength(200);

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.VisibilityInfoCode).HasMaxLength(50);

                entity.Property(e => e.VisibilityInfoName)
                    .HasMaxLength(40)
                    .IsFixedLength();
            });

            modelBuilder.Entity<OverSalesOrderDetailDel>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OverSales_OrderDetail_Del");

                entity.Property(e => e.BpacketMax).HasColumnName("BPacketMax");

                entity.Property(e => e.Fqty).HasColumnName("FQty");

                entity.Property(e => e.GrossTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IncentiveQty).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.OrderDetailId).HasColumnName("OrderDetailID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Tp)
                    .HasColumnType("decimal(7, 2)")
                    .HasColumnName("TP");
            });

            modelBuilder.Entity<OverSalesOrderDetailDelForPoint>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OverSales_OrderDetail_DelForPoint");

                entity.Property(e => e.BpacketMax).HasColumnName("BPacketMax");

                entity.Property(e => e.Fqty).HasColumnName("FQty");

                entity.Property(e => e.GrossTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IncentiveQty).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.OrderDetailId).HasColumnName("OrderDetailID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Tp)
                    .HasColumnType("decimal(7, 2)")
                    .HasColumnName("TP");
            });

            modelBuilder.Entity<PageReference>(entity =>
            {
                entity.ToTable("PageReference");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.GenerateId).HasColumnName("generateId");

                entity.Property(e => e.PostFix).HasMaxLength(50);

                entity.Property(e => e.Prefix).HasMaxLength(50);

                entity.Property(e => e.Separator).HasMaxLength(50);

                entity.Property(e => e.TableName).HasMaxLength(100);
            });

            modelBuilder.Entity<ReturnType>(entity =>
            {
                entity.ToTable("ReturnType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.TypeName).HasMaxLength(50);
            });

            modelBuilder.Entity<RptSoldDepotStockReport>(entity =>
            {
                entity.ToTable("RPT_SoldDepotStockReport");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CarNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ChallanNo)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ChallanNoEnd)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ChallanNoStart)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Sdid).HasColumnName("SDID");
            });

            modelBuilder.Entity<SecuredUser>(entity =>
            {
                entity.ToTable("SecuredUser");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SecureWord).HasMaxLength(256);
            });

            modelBuilder.Entity<SetArea>(entity =>
            {
                entity.HasKey(e => e.AreaId)
                    .HasName("PK_Area_1");

                entity.ToTable("SET_Area");

                entity.HasIndex(e => new { e.AreaName, e.RegionId }, "IX_SET_Area")
                    .IsUnique();

                entity.Property(e => e.AreaId)
                    .ValueGeneratedNever()
                    .HasColumnName("AreaID");

                entity.Property(e => e.AccountCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AreaAddress).HasMaxLength(200);

                entity.Property(e => e.AreaCode).HasMaxLength(50);

                entity.Property(e => e.AreaName).HasMaxLength(100);

                entity.Property(e => e.AreaTypeId)
                    .HasColumnName("AreaTypeID")
                    .HasComment("DSC Point = 1, Dealer = 2, Sub Dealer = 3");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.SetAreas)
                    .HasForeignKey(d => d.RegionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SET_Area_SET_Region");
            });

            modelBuilder.Entity<SetAreaWiseUnit>(entity =>
            {
                entity.ToTable("SET_AreaWiseUnit");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SetAttendance>(entity =>
            {
                entity.ToTable("SET_Attendance");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DeviceId)
                    .HasMaxLength(40)
                    .HasColumnName("DeviceID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.InsertUserId).HasColumnName("InsertUserID");

                entity.Property(e => e.SignInAddress)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SignInLatitude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SignInLongitude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SignInTime).HasMaxLength(50);

                entity.Property(e => e.SignOutAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SignOutLatitude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SignOutLongitude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SignOutTime).HasMaxLength(50);
            });

            modelBuilder.Entity<SetAttendanceByMobile>(entity =>
            {
                entity.ToTable("SET_AttendanceByMobile");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DeviceId)
                    .HasMaxLength(40)
                    .HasColumnName("DeviceID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.InsertUserId).HasColumnName("InsertUserID");

                entity.Property(e => e.SignInAddress).IsUnicode(false);

                entity.Property(e => e.SignInLatitude)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SignInLongitude)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SignInTime).HasMaxLength(50);

                entity.Property(e => e.SignOutAddress).IsUnicode(false);

                entity.Property(e => e.SignOutLatitude)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SignOutLongitude)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SignOutTime).HasMaxLength(50);
            });

            modelBuilder.Entity<SetBiriCigaretteStatus>(entity =>
            {
                entity.ToTable("SET_BiriCigaretteStatus");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Color)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasColumnName("lastUpdate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SetChallanPurpose>(entity =>
            {
                entity.ToTable("SET_ChallanPurpose");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.PurposeName).HasMaxLength(50);
            });

            modelBuilder.Entity<SetCluster>(entity =>
            {
                entity.HasKey(e => e.ClusterId);

                entity.ToTable("SET_Cluster");

                entity.Property(e => e.ClusterId).HasColumnName("ClusterID");

                entity.Property(e => e.ClusterCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClusterName).HasMaxLength(500);

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RouteId).HasColumnName("RouteID");

                entity.HasOne(d => d.Route)
                    .WithMany(p => p.SetClusters)
                    .HasForeignKey(d => d.RouteId)
                    .HasConstraintName("FK_SET_Cluster_SET_Route");
            });

            modelBuilder.Entity<SetClusterDeatail>(entity =>
            {
                entity.ToTable("SET_ClusterDeatail");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ClusterCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClusterId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ClusterID");

                entity.Property(e => e.ClusterName).HasMaxLength(500);

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.RouteId).HasColumnName("RouteID");
            });

            modelBuilder.Entity<SetDailySmoker>(entity =>
            {
                entity.ToTable("SET_DailySmoker");

                entity.HasIndex(e => e.MobileNo, "IX_SET_DailySmoker")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Age)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyBrand).HasMaxLength(50);

                entity.Property(e => e.ContactDate).HasColumnType("date");

                entity.Property(e => e.CurrentBrand).HasMaxLength(50);

                entity.Property(e => e.EmployementId).HasColumnName("EmployementID");

                entity.Property(e => e.HabitDay)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.HabitMonth)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.HabitYear)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ImageName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.MarketName).HasMaxLength(50);

                entity.Property(e => e.MobileNo)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.OutletId).HasColumnName("OutletID");

                entity.Property(e => e.Profession)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks).HasMaxLength(200);

                entity.Property(e => e.UnionId).HasColumnName("UnionID");

                entity.Property(e => e.VillageRouteName).HasMaxLength(50);
            });

            modelBuilder.Entity<SetDealerSubDealerInfo>(entity =>
            {
                entity.ToTable("SET_DealerSubDealerInfo");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Ab12comission)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("AB12Comission");

                entity.Property(e => e.Ab12sales)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("AB12Sales");

                entity.Property(e => e.Ab25comission)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("AB25Comission");

                entity.Property(e => e.Ab25sales)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("AB25Sales");

                entity.Property(e => e.Abrcomission)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ABRComission");

                entity.Property(e => e.Abrsales)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ABRSales");

                entity.Property(e => e.Ak10comission)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("AK10Comission");

                entity.Property(e => e.Ak10sales)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("AK10Sales");

                entity.Property(e => e.Ak20comission)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("AK20Comission");

                entity.Property(e => e.Ak20sales)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("AK20Sales");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.ComissionId).HasColumnName("ComissionID");

                entity.Property(e => e.DateofBirth).HasColumnType("datetime");

                entity.Property(e => e.DealerTypeId).HasColumnName("DealerTypeID");

                entity.Property(e => e.DepoId).HasColumnName("DepoID");

                entity.Property(e => e.DistributionStartDate).HasColumnType("date");

                entity.Property(e => e.DivisionId).HasColumnName("DivisionID");

                entity.Property(e => e.Dobday).HasColumnName("DOBDay");

                entity.Property(e => e.Dobmonth).HasColumnName("DOBMonth");

                entity.Property(e => e.Dobyear).HasColumnName("DOBYear");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeCsr).HasColumnName("EmployeeCSR");

                entity.Property(e => e.EmployeeSr).HasColumnName("EmployeeSR");

                entity.Property(e => e.EmployeeVp).HasColumnName("EmployeeVP");

                entity.Property(e => e.FathersName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Gbcomission)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("GBComission");

                entity.Property(e => e.Gbsales)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("GBSales");

                entity.Property(e => e.Gender)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.MaritalStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MothersName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NationalIdNumber)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Nationality)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pbcomission)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PBComission");

                entity.Property(e => e.Pbsales)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PBSales");

                entity.Property(e => e.PerAddCareOf)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PerAddDistrictId).HasColumnName("PerAddDistrictID");

                entity.Property(e => e.PerAddPostCode)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PerAddPostOffice)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PerAddThanaId).HasColumnName("PerAddThanaID");

                entity.Property(e => e.PerAddUnion)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PerAddVillage)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PermanentAddress)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PhotoPath).IsUnicode(false);

                entity.Property(e => e.PreAddDistrictId).HasColumnName("PreAddDistrictID");

                entity.Property(e => e.PreAddPostCode)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PreAddPostOffice)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PreAddThanaId).HasColumnName("PreAddThanaID");

                entity.Property(e => e.PreAddUnion)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PreAddVillage)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ProPrietorName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.Property(e => e.Religion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SetDeliveryMan>(entity =>
            {
                entity.ToTable("SET_DeliveryMan");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Depo)
                    .WithMany(p => p.SetDeliveryMen)
                    .HasForeignKey(d => d.DepoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DeliveryMan_Depo");
            });

            modelBuilder.Entity<SetDellar>(entity =>
            {
                entity.HasKey(e => e.DellarId);

                entity.ToTable("SET_Dellar");

                entity.HasIndex(e => e.DellarCode, "IX_SET_Dellar")
                    .IsUnique();

                entity.Property(e => e.DellarId)
                    .ValueGeneratedNever()
                    .HasColumnName("DellarID");

                entity.Property(e => e.Address).HasMaxLength(200);

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.ContactNo).HasMaxLength(50);

                entity.Property(e => e.DellarCode).HasMaxLength(50);

                entity.Property(e => e.DellarName).HasMaxLength(100);

                entity.Property(e => e.DepoId).HasColumnName("DepoID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.HasOne(d => d.Depo)
                    .WithMany(p => p.SetDellars)
                    .HasForeignKey(d => d.DepoId)
                    .HasConstraintName("FK_SET_Dellar_SET_Depo");
            });

            modelBuilder.Entity<SetDepartment>(entity =>
            {
                entity.HasKey(e => e.DepartmentId)
                    .HasName("PK_Department");

                entity.ToTable("SET_Department");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<SetDepartmentWiseSection>(entity =>
            {
                entity.ToTable("SET_DepartmentWiseSection");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.DivisionDeparmentId).HasColumnName("DivisionDeparmentID");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.DivisionDeparment)
                    .WithMany(p => p.SetDepartmentWiseSections)
                    .HasForeignKey(d => d.DivisionDeparmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SET_DepartmentWiseSection_SET_DivsionWiseDepartment");

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.SetDepartmentWiseSections)
                    .HasForeignKey(d => d.SectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SET_DepartmentWiseSection_SET_Section");
            });

            modelBuilder.Entity<SetDepo>(entity =>
            {
                entity.HasKey(e => e.DepoId)
                    .HasName("PK_Region");

                entity.ToTable("SET_Depo");

                entity.Property(e => e.DepoId).ValueGeneratedNever();

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<SetDistrict>(entity =>
            {
                entity.ToTable("SET_District");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DistrictName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DivisionId).HasColumnName("DivisionID");
            });

            modelBuilder.Entity<SetDivision>(entity =>
            {
                entity.HasKey(e => e.DivisionId);

                entity.ToTable("SET_Division");

                entity.HasIndex(e => e.Name, "IX_SET_Division")
                    .IsUnique();

                entity.Property(e => e.DivisionId).HasColumnName("DivisionID");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<SetDivisionDistrictUpazillaRawDatum>(entity =>
            {
                entity.HasKey(e => e.Sln);

                entity.ToTable("Set_DivisionDistrictUpazillaRawData");

                entity.Property(e => e.Sln).ValueGeneratedNever();
            });

            modelBuilder.Entity<SetDivisionWiseRegion>(entity =>
            {
                entity.HasKey(e => e.Drid);

                entity.ToTable("Set_DivisionWiseRegion");

                entity.Property(e => e.Drid)
                    .ValueGeneratedNever()
                    .HasColumnName("DRID");

                entity.Property(e => e.CreateDate).HasColumnType("date");

                entity.Property(e => e.DivisionId).HasColumnName("DivisionID");

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.HasOne(d => d.Division)
                    .WithMany(p => p.SetDivisionWiseRegions)
                    .HasForeignKey(d => d.DivisionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Set_DivisionWiseRegion_SET_Division");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.SetDivisionWiseRegions)
                    .HasForeignKey(d => d.RegionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Set_DivisionWiseRegion_SET_Region");
            });

            modelBuilder.Entity<SetDivsionWiseDepartment>(entity =>
            {
                entity.ToTable("SET_DivsionWiseDepartment");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.DivisionId).HasColumnName("DivisionID");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.SetDivsionWiseDepartments)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SET_DivsionWiseDepartment_SET_Department");

                entity.HasOne(d => d.Division)
                    .WithMany(p => p.SetDivsionWiseDepartments)
                    .HasForeignKey(d => d.DivisionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SET_DivsionWiseDepartment_SET_Division");
            });

            modelBuilder.Entity<SetEmployeeDevice>(entity =>
            {
                entity.ToTable("Set_EmployeeDevice");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.DeviceId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DeviceID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.GivenDate).HasColumnType("datetime");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.MobileNo).HasMaxLength(50);

                entity.Property(e => e.ReturnDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SetEmployeeInfo>(entity =>
            {
                entity.HasKey(e => new { e.EmploymentId, e.EmployeeId });

                entity.ToTable("SET_EmployeeInfo");

                entity.HasIndex(e => new { e.DepoId, e.AreaId, e.RegionId, e.TerritoryId }, "IX_SET_EmployeeInfo");

                entity.Property(e => e.EmploymentId).HasColumnName("EmploymentID");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.AreaName).HasMaxLength(100);

                entity.Property(e => e.ContactNo1).HasMaxLength(20);

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.DepoId).HasColumnName("DepoID");

                entity.Property(e => e.DepoName).HasMaxLength(100);

                entity.Property(e => e.DesignationName).HasMaxLength(100);

                entity.Property(e => e.DivisionId).HasColumnName("DivisionID");

                entity.Property(e => e.DivisionName).HasMaxLength(100);

                entity.Property(e => e.EmployeeName).HasMaxLength(50);

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.FactoryName).HasMaxLength(100);

                entity.Property(e => e.JoiningDate).HasColumnType("date");

                entity.Property(e => e.Pfid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PFID");

                entity.Property(e => e.ProximityId).HasColumnName("ProximityID");

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.Property(e => e.RegionName).HasMaxLength(50);

                entity.Property(e => e.TerritoryId).HasColumnName("TerritoryID");

                entity.Property(e => e.TerritoryName).HasMaxLength(100);

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<SetFactory>(entity =>
            {
                entity.HasKey(e => e.FactoryId)
                    .HasName("PK_Factory");

                entity.ToTable("SET_Factory");

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.Address).HasMaxLength(300);

                entity.Property(e => e.FactoryCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FactoryName).HasMaxLength(100);

                entity.Property(e => e.Fdid).HasColumnName("FDID");

                entity.Property(e => e.IsProductWwslno).HasColumnName("IsProductWWSLNo");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SetFactoryDivision>(entity =>
            {
                entity.ToTable("SET_FactoryDivision");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.FactoryDivisionCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FactoryDivisionName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SetFactoryWiseProductionProduct>(entity =>
            {
                entity.ToTable("SET_FactoryWiseProductionProduct");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");
            });

            modelBuilder.Entity<SetFactoryWorkerType>(entity =>
            {
                entity.ToTable("SET_FactoryWorkerType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkerType)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SetHrdesignation>(entity =>
            {
                entity.ToTable("SET_HRDesignation");

                entity.HasIndex(e => e.Name, "IX_SET_HRDesignation")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.PositionId).HasColumnName("PositionID");

                entity.HasOne(d => d.Position)
                    .WithMany(p => p.SetHrdesignations)
                    .HasForeignKey(d => d.PositionId)
                    .HasConstraintName("FK_SET_HRDesignation_SET_JobPosition");
            });

            modelBuilder.Entity<SetHremployeeCategory>(entity =>
            {
                entity.ToTable("SET_HREmployeeCategory");

                entity.HasIndex(e => e.Name, "IX_SET_HREmployeeCategory")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<SetHrleaveProfile>(entity =>
            {
                entity.ToTable("SET_HRLeaveProfile");

                entity.HasIndex(e => new { e.AgreementTypeId, e.EmployeeCategoryId, e.LeaveTypeId }, "IX_SET_HRLeaveProfile")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccrualFactor).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.AgreementTypeId).HasColumnName("AgreementTypeID");

                entity.Property(e => e.EmployeeCategoryId).HasColumnName("EmployeeCategoryID");

                entity.Property(e => e.GenderId).HasColumnName("GenderID");

                entity.Property(e => e.LeaveTypeId).HasColumnName("LeaveTypeID");

                entity.HasOne(d => d.AgreementType)
                    .WithMany(p => p.SetHrleaveProfiles)
                    .HasForeignKey(d => d.AgreementTypeId)
                    .HasConstraintName("FK_SET_HRLeaveProfile_FT_AggreementType");

                entity.HasOne(d => d.AgreementTypeNavigation)
                    .WithMany(p => p.SetHrleaveProfiles)
                    .HasForeignKey(d => d.AgreementTypeId)
                    .HasConstraintName("FK_SET_HRLeaveProfile_SET_JobPosition");

                entity.HasOne(d => d.Gender)
                    .WithMany(p => p.SetHrleaveProfiles)
                    .HasForeignKey(d => d.GenderId)
                    .HasConstraintName("FK_SET_HRLeaveProfile_FT_Gender");

                entity.HasOne(d => d.LeaveType)
                    .WithMany(p => p.SetHrleaveProfiles)
                    .HasForeignKey(d => d.LeaveTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SET_HRLeaveProfile_FT_HRLeaveType");
            });

            modelBuilder.Entity<SetHrleaveYear>(entity =>
            {
                entity.ToTable("SET_HRLeaveYear");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
            });

            modelBuilder.Entity<SetHrmshiftCategory>(entity =>
            {
                entity.ToTable("SET_HRMShiftCategory");

                entity.HasIndex(e => e.CategoryName, "IX_SET_HRMShiftCategory")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CategoryName).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(100);
            });

            modelBuilder.Entity<SetHrmshiftType>(entity =>
            {
                entity.ToTable("SET_HRMShiftType");

                entity.HasIndex(e => new { e.TypeName, e.CategoryId }, "IX_SET_HRMShiftType")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.TypeName).HasMaxLength(50);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.SetHrmshiftTypes)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SET_HRMShiftType_SET_HRMShiftCategory");
            });

            modelBuilder.Entity<SetIncentivePoint>(entity =>
            {
                entity.ToTable("SET_IncentivePoint");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Ammpoint).HasColumnName("AMMPoint");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Grade)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MasterId).HasColumnName("MasterID");

                entity.Property(e => e.Mmpoint).HasColumnName("MMPoint");

                entity.Property(e => e.Parameter)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PointPurpose)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Srpoint).HasColumnName("SRPoint");

                entity.Property(e => e.Toampoint).HasColumnName("TOAMPoint");
            });

            modelBuilder.Entity<SetIncentivePointMaster>(entity =>
            {
                entity.ToTable("SET_IncentivePointMaster");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MasterParameter)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PointSlno)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PointSLNo");
            });

            modelBuilder.Entity<SetJobPosition>(entity =>
            {
                entity.ToTable("SET_JobPosition");

                entity.HasIndex(e => e.Name, "IX_SET_JobPosition")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<SetLeaveType>(entity =>
            {
                entity.ToTable("SET_LeaveType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.SetLeaveTypes)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SET_LeaveType_FT_HRLeaveType");
            });

            modelBuilder.Entity<SetLoanType>(entity =>
            {
                entity.ToTable("SET_LoanType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SetLog>(entity =>
            {
                entity.ToTable("SET_Log");

                entity.Property(e => e.Date).HasColumnType("datetime");
            });

            modelBuilder.Entity<SetLogInLog>(entity =>
            {
                entity.ToTable("SET_LogInLog");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.DeviceType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.LoginDateTime).HasColumnType("datetime");

                entity.Property(e => e.SessionId)
                    .HasMaxLength(100)
                    .HasColumnName("SessionID");

                entity.Property(e => e.UserHostAddress).HasMaxLength(100);
            });

            modelBuilder.Entity<SetLogInMacAddress>(entity =>
            {
                entity.ToTable("SET_LogInMacAddress");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.DeviceType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.LoginDateTime).HasColumnType("datetime");

                entity.Property(e => e.SessionId)
                    .HasMaxLength(100)
                    .HasColumnName("SessionID");

                entity.Property(e => e.UserHostAddress).HasMaxLength(100);

                entity.Property(e => e.UserMacAddress).HasMaxLength(100);
            });

            modelBuilder.Entity<SetLogonsUser>(entity =>
            {
                entity.HasKey(e => e.EventId)
                    .HasName("PK_Security_FailedLogons");

                entity.ToTable("SET_LogonsUsers");

                entity.Property(e => e.EventId).HasColumnName("EventID");

                entity.Property(e => e.HostName).HasMaxLength(200);

                entity.Property(e => e.Password).HasMaxLength(256);

                entity.Property(e => e.TimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TryDate).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<SetMenuGroup>(entity =>
            {
                entity.HasKey(e => e.MenuGroupId);

                entity.ToTable("SET_MenuGroup");

                entity.Property(e => e.MenuGroupId).HasColumnName("MenuGroupID");

                entity.Property(e => e.MenuGroupName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SetModule>(entity =>
            {
                entity.HasKey(e => e.ModuleId);

                entity.ToTable("SET_Module");

                entity.Property(e => e.ModuleId)
                    .ValueGeneratedNever()
                    .HasColumnName("ModuleID");

                entity.Property(e => e.ModuleName)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SetModuleWiseSubmodule>(entity =>
            {
                entity.ToTable("SET_ModuleWiseSubmodule");

                entity.HasIndex(e => new { e.ModuleId, e.SubmoduleId }, "IX_SET_ModuleWiseSubmodule")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ModuleId).HasColumnName("ModuleID");

                entity.Property(e => e.SubmoduleId).HasColumnName("SubmoduleID");

                entity.HasOne(d => d.Module)
                    .WithMany(p => p.SetModuleWiseSubmodules)
                    .HasForeignKey(d => d.ModuleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SET_ModuleWiseSubmodule_SET_Module");

                entity.HasOne(d => d.Submodule)
                    .WithMany(p => p.SetModuleWiseSubmodules)
                    .HasForeignKey(d => d.SubmoduleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SET_ModuleWiseSubmodule_SET_SubModule");
            });

            modelBuilder.Entity<SetMonthlyActiveWorkingDay>(entity =>
            {
                entity.ToTable("SET_MonthlyActiveWorkingDays");

                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<SetMporecruitment>(entity =>
            {
                entity.ToTable("SET_MPORecruitment");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Address)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmployementId).HasColumnName("EmployementID");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Mponame)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MPOName");
            });

            modelBuilder.Entity<SetNapkinFactory>(entity =>
            {
                entity.HasKey(e => e.FactoryId)
                    .HasName("PK_NapkinFactory");

                entity.ToTable("SET_NapkinFactory");

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.Address).HasMaxLength(300);

                entity.Property(e => e.FactoryCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FactoryName).HasMaxLength(100);

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SetNapkinOutlet>(entity =>
            {
                entity.HasKey(e => e.OutletId);

                entity.ToTable("SET_NapkinOutlet");

                entity.Property(e => e.OutletId)
                    .ValueGeneratedNever()
                    .HasColumnName("OutletID");

                entity.Property(e => e.Address).HasMaxLength(200);

                entity.Property(e => e.ClusterId).HasColumnName("ClusterID");

                entity.Property(e => e.ContactNo).HasMaxLength(50);

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.OutletCode).HasMaxLength(50);

                entity.Property(e => e.OutletName).HasMaxLength(100);

                entity.Property(e => e.OutletTypeId).HasColumnName("OutletTypeID");

                entity.Property(e => e.Owner).HasMaxLength(100);

                entity.Property(e => e.RouteId).HasColumnName("RouteID");

                entity.HasOne(d => d.OutletType)
                    .WithMany(p => p.SetNapkinOutlets)
                    .HasForeignKey(d => d.OutletTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SET_NapkinOutlet_SET_NapkinOutletType");
            });

            modelBuilder.Entity<SetNapkinOutletType>(entity =>
            {
                entity.ToTable("SET_NapkinOutletType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TypeName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SetNapkinProduct>(entity =>
            {
                entity.HasKey(e => e.ProductId);

                entity.ToTable("SET_NapkinProduct");

                entity.Property(e => e.ProductId).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.ProductName).HasMaxLength(100);

                entity.Property(e => e.ShortName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SetNapkinProductPrice>(entity =>
            {
                entity.HasKey(e => e.Ppid);

                entity.ToTable("SET_NapkinProductPrice");

                entity.Property(e => e.Ppid)
                    .ValueGeneratedNever()
                    .HasColumnName("PPID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.Mrp)
                    .HasColumnType("decimal(6, 3)")
                    .HasColumnName("MRP");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Tp)
                    .HasColumnType("decimal(5, 3)")
                    .HasColumnName("TP");

                entity.Property(e => e.Vat).HasColumnType("decimal(5, 3)");
            });

            modelBuilder.Entity<SetNapkinPromotionType>(entity =>
            {
                entity.ToTable("SET_NapkinPromotionType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SetNoteAndCoinInfo>(entity =>
            {
                entity.ToTable("SET_NoteAndCoinInfo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.MoneyNoteOrCoin).HasMaxLength(50);
            });

            modelBuilder.Entity<SetOutetRawDatum>(entity =>
            {
                entity.ToTable("SET_OutetRawData");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ContactNo).HasMaxLength(50);

                entity.Property(e => e.ErrorMessage).HasMaxLength(500);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsProcess)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Mpocode)
                    .HasMaxLength(50)
                    .HasColumnName("MPOCode");

                entity.Property(e => e.OutletAddress).HasMaxLength(500);

                entity.Property(e => e.OutletName).HasMaxLength(500);
            });

            modelBuilder.Entity<SetOutlet>(entity =>
            {
                entity.HasKey(e => e.OutletId)
                    .HasName("PK_Chemist");

                entity.ToTable("SET_Outlet");

                entity.HasIndex(e => e.OutletCode, "IX_Chemist")
                    .IsUnique();

                entity.Property(e => e.OutletId)
                    .ValueGeneratedNever()
                    .HasColumnName("OutletID");

                entity.Property(e => e.Address).HasMaxLength(200);

                entity.Property(e => e.ClusterId).HasColumnName("ClusterID");

                entity.Property(e => e.ContactNo).HasMaxLength(50);

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.MarketName).HasMaxLength(50);

                entity.Property(e => e.OutletCode).HasMaxLength(50);

                entity.Property(e => e.OutletName).HasMaxLength(100);

                entity.Property(e => e.Owner).HasMaxLength(100);

                entity.Property(e => e.RouteId).HasColumnName("RouteID");

                entity.Property(e => e.UnionId).HasColumnName("UnionID");

                entity.Property(e => e.VillageName).HasMaxLength(50);

                entity.HasOne(d => d.Cluster)
                    .WithMany(p => p.SetOutlets)
                    .HasForeignKey(d => d.ClusterId)
                    .HasConstraintName("FK_SET_Outlet_SET_Cluster");

                entity.HasOne(d => d.Route)
                    .WithMany(p => p.SetOutlets)
                    .HasForeignKey(d => d.RouteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SET_Outlet_SET_Route");
            });

            modelBuilder.Entity<SetOutletDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SET_OutletDetail");

                entity.Property(e => e.Address).HasMaxLength(200);

                entity.Property(e => e.ClusterId).HasColumnName("ClusterID");

                entity.Property(e => e.ContactNo).HasMaxLength(50);

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.OutletCode).HasMaxLength(50);

                entity.Property(e => e.OutletId).HasColumnName("OutletID");

                entity.Property(e => e.OutletName).HasMaxLength(100);

                entity.Property(e => e.Owner).HasMaxLength(100);

                entity.Property(e => e.RouteId).HasColumnName("RouteID");
            });

            modelBuilder.Entity<SetOutletDivision>(entity =>
            {
                entity.HasKey(e => e.DivisionId);

                entity.ToTable("SET_OutletDivision");

                entity.Property(e => e.DivisionId).HasColumnName("DivisionID");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<SetOutletNumber>(entity =>
            {
                entity.ToTable("SET_OutletNumber");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.SetOutletNumbers)
                    .HasForeignKey(d => d.AreaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SET_OutletNumber_SET_Area");
            });

            modelBuilder.Entity<SetPage>(entity =>
            {
                entity.HasKey(e => e.PageId)
                    .HasName("PK_Pages");

                entity.ToTable("SET_Pages");

                entity.HasIndex(e => e.PageName, "IX_Pages")
                    .IsUnique();

                entity.Property(e => e.PageId)
                    .ValueGeneratedNever()
                    .HasColumnName("PageID");

                entity.Property(e => e.PageName).HasMaxLength(50);
            });

            modelBuilder.Entity<SetPayGrade>(entity =>
            {
                entity.ToTable("SET_PayGrade");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BasicFrom).HasColumnType("money");

                entity.Property(e => e.BasicTo).HasColumnType("money");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.FoodAllowance).HasColumnType("money");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.TransportAllowance).HasColumnType("money");
            });

            modelBuilder.Entity<SetPostOffice>(entity =>
            {
                entity.ToTable("SET_PostOffice");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.DistrictId).HasColumnName("DistrictID");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name).HasMaxLength(500);

                entity.Property(e => e.PostCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.District)
                    .WithMany(p => p.SetPostOffices)
                    .HasForeignKey(d => d.DistrictId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SET_PostOffice_SET_District");
            });

            modelBuilder.Entity<SetPostWisePage>(entity =>
            {
                entity.ToTable("SET_PostWisePage");

                entity.HasIndex(e => new { e.PageId, e.PostId }, "IX_PostWisePage")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.PageId).HasColumnName("PageID");

                entity.Property(e => e.PostId).HasColumnName("PostID");

                entity.HasOne(d => d.Page)
                    .WithMany(p => p.SetPostWisePages)
                    .HasForeignKey(d => d.PageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SET_PostWisePage_SET_Pages");
            });

            modelBuilder.Entity<SetProduct>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("PK_Product");

                entity.ToTable("SET_Product");

                entity.HasIndex(e => e.ProductName, "IX_SET_Product_ProductName")
                    .IsUnique();

                entity.Property(e => e.ProductId).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.ProductName).HasMaxLength(100);

                entity.Property(e => e.ProductTypeId).HasColumnName("ProductTypeID");

                entity.Property(e => e.ShortName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.ProductCategoryNavigation)
                    .WithMany(p => p.SetProducts)
                    .HasForeignKey(d => d.ProductCategory)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SET_Product_ProductCategory");
            });

            modelBuilder.Entity<SetProductCategory>(entity =>
            {
                entity.HasKey(e => e.ProductCategoryId)
                    .HasName("PK_ProductCategory");

                entity.ToTable("SET_ProductCategory");

                entity.Property(e => e.ProductCategoryId).HasColumnName("ProductCategoryID");

                entity.Property(e => e.CategoryName).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(100);
            });

            modelBuilder.Entity<SetProductPrice>(entity =>
            {
                entity.HasKey(e => e.Ppid)
                    .HasName("PK_ProductPrice");

                entity.ToTable("SET_ProductPrice");

                entity.Property(e => e.Ppid)
                    .ValueGeneratedNever()
                    .HasColumnName("PPID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.Mrp)
                    .HasColumnType("decimal(6, 3)")
                    .HasColumnName("MRP");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Tp)
                    .HasColumnType("decimal(5, 3)")
                    .HasColumnName("TP");

                entity.Property(e => e.Vat).HasColumnType("decimal(5, 3)");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.SetProductPrices)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SET_ProductPrice_SET_Product");
            });

            modelBuilder.Entity<SetProductPricePre>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SET_ProductPrice_Pre");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.Mrp)
                    .HasColumnType("decimal(6, 3)")
                    .HasColumnName("MRP");

                entity.Property(e => e.Ppid).HasColumnName("PPID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Tp)
                    .HasColumnType("decimal(5, 3)")
                    .HasColumnName("TP");

                entity.Property(e => e.Vat).HasColumnType("decimal(5, 3)");
            });

            modelBuilder.Entity<SetProductPricePreviouse>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SET_ProductPrice_Previouse");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.Mrp)
                    .HasColumnType("decimal(6, 3)")
                    .HasColumnName("MRP");

                entity.Property(e => e.Ppid).HasColumnName("PPID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Tp)
                    .HasColumnType("decimal(5, 3)")
                    .HasColumnName("TP");

                entity.Property(e => e.Vat).HasColumnType("decimal(5, 3)");
            });

            modelBuilder.Entity<SetProductType>(entity =>
            {
                entity.HasKey(e => e.ProductTypeId);

                entity.ToTable("SET_ProductType");

                entity.Property(e => e.ProductTypeId)
                    .ValueGeneratedNever()
                    .HasColumnName("ProductTypeID");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Lastupdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProductTypeDes)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ProductTypeName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SetProductWiseIncentive>(entity =>
            {
                entity.HasKey(e => e.Piid);

                entity.ToTable("SET_ProductWiseIncentive");

                entity.Property(e => e.Piid)
                    .ValueGeneratedNever()
                    .HasColumnName("PIID");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.IncentivePercentage).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.SetProductWiseIncentives)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SET_ProductWiseIncentive_SET_ProductWiseIncentive");
            });

            modelBuilder.Entity<SetReUpdateOutletBcstatus>(entity =>
            {
                entity.ToTable("SET_ReUpdateOutletBCStatus");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.OutletId).HasColumnName("OutletID");
            });

            modelBuilder.Entity<SetRegion>(entity =>
            {
                entity.HasKey(e => e.RegionId)
                    .HasName("PK_Area");

                entity.ToTable("SET_Region");

                entity.HasIndex(e => e.Name, "Duplicate_Region")
                    .IsUnique();

                entity.Property(e => e.RegionId)
                    .ValueGeneratedNever()
                    .HasColumnName("RegionID");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.Depo)
                    .WithMany(p => p.SetRegions)
                    .HasForeignKey(d => d.DepoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SET_Region_SET_Depo");
            });

            modelBuilder.Entity<SetReportView>(entity =>
            {
                entity.ToTable("SET_ReportView");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.EndTime)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StartTime)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Time)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SetRole>(entity =>
            {
                entity.HasKey(e => e.RoleId);

                entity.ToTable("SET_Role");

                entity.HasIndex(e => e.RoleName, "IX_SET_Role")
                    .IsUnique();

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RoleName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SetRoleWisePage>(entity =>
            {
                entity.ToTable("SET_RoleWisePage");

                entity.HasIndex(e => new { e.RoleId, e.ModuleSubModuleId }, "IX_SET_RoleWisePage")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ModuleSubModuleId).HasColumnName("ModuleSubModuleID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.HasOne(d => d.ModuleSubModule)
                    .WithMany(p => p.SetRoleWisePages)
                    .HasForeignKey(d => d.ModuleSubModuleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SET_RoleWisePage_SET_ModuleWiseSubmodule");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.SetRoleWisePages)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SET_RoleWisePage_SET_Role");
            });

            modelBuilder.Entity<SetRoute>(entity =>
            {
                entity.HasKey(e => e.RouteId);

                entity.ToTable("SET_Route");

                entity.HasIndex(e => new { e.TerritoryId, e.RouteName, e.IsActive }, "IX_SET_Route")
                    .IsUnique();

                entity.HasIndex(e => e.RouteCode, "IX_SET_Route_1")
                    .IsUnique();

                entity.Property(e => e.RouteId)
                    .ValueGeneratedNever()
                    .HasColumnName("RouteID");

                entity.Property(e => e.DistanceFromArea).HasMaxLength(50);

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.MarketShare).HasMaxLength(50);

                entity.Property(e => e.RouteCode).HasMaxLength(50);

                entity.Property(e => e.RouteName).HasMaxLength(200);

                entity.Property(e => e.TerritoryId).HasColumnName("TerritoryID");

                entity.HasOne(d => d.Territory)
                    .WithMany(p => p.SetRoutes)
                    .HasForeignKey(d => d.TerritoryId)
                    .HasConstraintName("FK_SET_Route_SET_Territory");
            });

            modelBuilder.Entity<SetRouteBackUp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Set_routeBackUP");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.RouteCode).HasMaxLength(50);

                entity.Property(e => e.RouteId).HasColumnName("RouteID");

                entity.Property(e => e.RouteName).HasMaxLength(200);

                entity.Property(e => e.TerritoryId).HasColumnName("TerritoryID");
            });

            modelBuilder.Entity<SetSalah>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Set_Salah");

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.TerritoryCode).HasMaxLength(50);
            });

            modelBuilder.Entity<SetSection>(entity =>
            {
                entity.HasKey(e => e.SectionId)
                    .HasName("PK_Section");

                entity.ToTable("SET_Section");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<SetSecuredUser>(entity =>
            {
                entity.ToTable("SET_SecuredUser");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.SecureWord).HasMaxLength(256);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                //entity.HasOne(d => d.User)
                //    .WithMany(p => p.SetSecuredUsers)
                //    .HasForeignKey(d => d.UserId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_SET_SecuredUser_SET_Users");
            });

            modelBuilder.Entity<SetSmoker>(entity =>
            {
                entity.ToTable("SET_Smoker");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Age)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyBrand).HasMaxLength(50);

                entity.Property(e => e.ContactDate).HasColumnType("date");

                entity.Property(e => e.CurrentBrand).HasMaxLength(50);

                entity.Property(e => e.EmployementId).HasColumnName("EmployementID");

                entity.Property(e => e.HabitDay)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.HabitMonth)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.HabitYear)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ImageName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.MarketName).HasMaxLength(50);

                entity.Property(e => e.MobileNo)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.OutletId).HasColumnName("OutletID");

                entity.Property(e => e.Profession)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks).HasMaxLength(200);

                entity.Property(e => e.UnionId).HasColumnName("UnionID");

                entity.Property(e => e.VillageRouteName).HasMaxLength(50);
            });

            modelBuilder.Entity<SetSmokerBak>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SET_SmokerBak");

                entity.Property(e => e.Age)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyBrand).HasMaxLength(50);

                entity.Property(e => e.ContactDate).HasColumnType("date");

                entity.Property(e => e.CurrentBrand).HasMaxLength(50);

                entity.Property(e => e.EmployementId).HasColumnName("EmployementID");

                entity.Property(e => e.HabitDay)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.HabitMonth)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.HabitYear)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ImageName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.MarketName).HasMaxLength(50);

                entity.Property(e => e.MobileNo)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.OutletId).HasColumnName("OutletID");

                entity.Property(e => e.Profession)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks).HasMaxLength(200);

                entity.Property(e => e.Rn).HasColumnName("rn");

                entity.Property(e => e.UnionId).HasColumnName("UnionID");

                entity.Property(e => e.VillageRouteName).HasMaxLength(50);
            });

            modelBuilder.Entity<SetSmokerCategory>(entity =>
            {
                entity.ToTable("SET_SmokerCategory");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SetSrofficer>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SET_SROfficer");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.TerritoryId).HasColumnName("TerritoryID");
            });

            modelBuilder.Entity<SetSrwiseRoute>(entity =>
            {
                entity.ToTable("SET_SRWiseRoute");

                entity.HasIndex(e => new { e.RouteId, e.PharmaSrcode, e.AkijSrcode }, "IX_SRWiseRoute_1")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AkijSrcode)
                    .HasMaxLength(200)
                    .HasColumnName("AkijSRCode");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.PharmaSrcode)
                    .HasMaxLength(200)
                    .HasColumnName("PharmaSRCode");

                entity.Property(e => e.RouteCode).HasMaxLength(50);

                entity.Property(e => e.RouteId).HasColumnName("RouteID");

                entity.Property(e => e.Srid).HasColumnName("SRID");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.TerritoryId).HasColumnName("TerritoryID");
            });

            modelBuilder.Entity<SetSubModule>(entity =>
            {
                entity.HasKey(e => e.SmoduleId);

                entity.ToTable("SET_SubModule");

                entity.Property(e => e.SmoduleId)
                    .ValueGeneratedNever()
                    .HasColumnName("SModuleID");

                entity.Property(e => e.Name).HasMaxLength(500);

                entity.Property(e => e.PageTitle).HasMaxLength(500);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Url).HasMaxLength(500);

                entity.HasOne(d => d.MenuGroupNavigation)
                    .WithMany(p => p.SetSubModules)
                    .HasForeignKey(d => d.MenuGroup)
                    .HasConstraintName("FK_SET_SubModule_SET_MenuGroup");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_SET_SubModule_SET_SubModule");
            });

            modelBuilder.Entity<SetSurveyItem>(entity =>
            {
                entity.ToTable("SET_SurveyItem");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Lastupdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SurveyItem).HasMaxLength(500);

                entity.Property(e => e.SurveyTypeId).HasColumnName("SurveyTypeID");
            });

            modelBuilder.Entity<SetSurveyType>(entity =>
            {
                entity.ToTable("SET_SurveyType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Lastupdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SurveyType)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SetTerritory>(entity =>
            {
                entity.HasKey(e => e.TerritoryId)
                    .HasName("PK_Territory");

                entity.ToTable("SET_Territory");

                entity.HasIndex(e => new { e.AreaId, e.Name }, "IX_SET_Territory")
                    .IsUnique();

                entity.Property(e => e.TerritoryId).ValueGeneratedNever();

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.TerritoryCode).HasMaxLength(50);

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.SetTerritories)
                    .HasForeignKey(d => d.AreaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Territory_Area");
            });

            modelBuilder.Entity<SetThana>(entity =>
            {
                entity.ToTable("SET_Thana");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DistrictId).HasColumnName("DistrictID");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.District)
                    .WithMany(p => p.SetThanas)
                    .HasForeignKey(d => d.DistrictId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Thana_District");
            });

            modelBuilder.Entity<SetTourType>(entity =>
            {
                entity.ToTable("SET_TourType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SetUnion>(entity =>
            {
                entity.ToTable("SET_Union");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ThanaId).HasColumnName("ThanaID");
            });

            modelBuilder.Entity<SetUser>(entity =>
            {
                entity.ToTable("SET_Users");

                entity.HasIndex(e => e.UserId, "IX_Users")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");
                entity.Property(e => e.LoginTime).HasColumnType("datetime");

                entity.Property(e => e.Password).HasMaxLength(256);

                entity.Property(e => e.UserId).HasMaxLength(50);
                entity.Property(e => e.Token).HasMaxLength(50);


                //entity.HasOne(d => d.Employee)
                //    .WithMany(p => p.SetUsers)
                //    .HasForeignKey(d => d.EmployeeId)
                //    .HasConstraintName("FK_SET_Users_HRM_PI");
            });

            modelBuilder.Entity<SetUserMessage>(entity =>
            {
                entity.HasKey(e => e.MessageId)
                    .HasName("PK_UserMessage");

                entity.ToTable("SET_UserMessage");

                entity.Property(e => e.MessageId)
                    .ValueGeneratedNever()
                    .HasColumnName("MessageID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.MessageBody).HasColumnType("text");

                entity.Property(e => e.SenderId).HasColumnName("SenderID");

                entity.Property(e => e.Subject).HasMaxLength(200);
            });

            modelBuilder.Entity<SetUserMessageReceiver>(entity =>
            {
                entity.HasKey(e => e.MessageReceiverId)
                    .HasName("PK_UserMessageReceiver");

                entity.ToTable("SET_UserMessageReceiver");

                entity.Property(e => e.MessageReceiverId)
                    .ValueGeneratedNever()
                    .HasColumnName("MessageReceiverID");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MessageId).HasColumnName("MessageID");

                entity.Property(e => e.ReadTime).HasColumnType("datetime");

                entity.Property(e => e.ReceiverId).HasColumnName("ReceiverID");
            });

            modelBuilder.Entity<SetUserWisePage>(entity =>
            {
                entity.ToTable("SET_UserWisePage");

                entity.HasIndex(e => new { e.UserId, e.ModuleSubMuduleId }, "IX_SET_UserWisePage")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ModuleSubMuduleId).HasColumnName("ModuleSubMuduleID");

                entity.HasOne(d => d.ModuleSubMudule)
                    .WithMany(p => p.SetUserWisePages)
                    .HasForeignKey(d => d.ModuleSubMuduleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SET_UserWisePage_SET_ModuleWiseSubmodule");

                //entity.HasOne(d => d.User)
                //    .WithMany(p => p.SetUserWisePages)
                //    .HasForeignKey(d => d.UserId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_SET_UserWisePage_SET_Users");
            });

            modelBuilder.Entity<SetUserWiseRole>(entity =>
            {
                entity.ToTable("SET_UserWiseRole");

                entity.HasIndex(e => new { e.UserId, e.RoleId }, "IX_SET_UserWiseRole")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.SetUserWiseRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SET_UserWiseRole_SET_Role");

                //entity.HasOne(d => d.User)
                //    .WithMany(p => p.SetUserWiseRoles)
                //    .HasForeignKey(d => d.UserId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_SET_UserWiseRole_SET_Users");
            });

            modelBuilder.Entity<SetVisitStatus>(entity =>
            {
                entity.ToTable("SET_VisitStatus");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SrcsrNotification>(entity =>
            {
                entity.ToTable("SRCSR_Notification");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.AreaName).HasMaxLength(100);

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.DepoId).HasColumnName("DepoID");

                entity.Property(e => e.DepoName).HasMaxLength(100);

                entity.Property(e => e.Designation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DesignationId).HasColumnName("DesignationID");

                entity.Property(e => e.DivisionId).HasColumnName("DivisionID");

                entity.Property(e => e.DivisionName).HasMaxLength(100);

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.Property(e => e.RegionName).HasMaxLength(100);

                entity.Property(e => e.Srid).HasColumnName("SRID");

                entity.Property(e => e.Srname)
                    .HasMaxLength(500)
                    .HasColumnName("SRName");

                entity.Property(e => e.TerritoryId).HasColumnName("TerritoryID");

                entity.Property(e => e.TerritoryName).HasMaxLength(100);
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Student");

                entity.Property(e => e.Dob)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DOB");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SystemDmsDmreceivedItemFromFactory>(entity =>
            {
                entity.HasKey(e => e.HistoryId);

                entity.ToTable("System_DMS_DMReceivedItemFromFactory");

                entity.Property(e => e.HistoryId).HasColumnName("HistoryID");

                entity.Property(e => e.ChallanDetailId).HasColumnName("ChallanDetailID");

                entity.Property(e => e.Dmrffid).HasColumnName("DMRFFID");

                entity.Property(e => e.DmritemFfid).HasColumnName("DMRItemFFID");

                entity.Property(e => e.Dsid).HasColumnName("DSID");

                entity.Property(e => e.EventTime).HasColumnType("datetime");

                entity.Property(e => e.EventType).HasMaxLength(50);

                entity.Property(e => e.Host).HasMaxLength(50);

                entity.Property(e => e.InsertUserId).HasColumnName("InsertUserID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");
            });

            modelBuilder.Entity<SystemDmsDmrecevedFromFactory>(entity =>
            {
                entity.HasKey(e => e.HistoryId);

                entity.ToTable("System_DMS_DMRecevedFromFactory");

                entity.Property(e => e.HistoryId).HasColumnName("HistoryID");

                entity.Property(e => e.DepoId).HasColumnName("DepoID");

                entity.Property(e => e.Dmrffid).HasColumnName("DMRFFID");

                entity.Property(e => e.EventTime).HasColumnType("datetime");

                entity.Property(e => e.EventType).HasMaxLength(50);

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.Host).HasMaxLength(50);

                entity.Property(e => e.LastUpdate).HasColumnType("date");

                entity.Property(e => e.ReceivedById).HasColumnName("ReceivedByID");

                entity.Property(e => e.ReceivedDate).HasColumnType("date");

                entity.Property(e => e.ReceivedNo).HasMaxLength(50);

                entity.Property(e => e.Remarks).HasMaxLength(300);
            });

            modelBuilder.Entity<SystemDmsFactoryChallan>(entity =>
            {
                entity.HasKey(e => e.HistoryId);

                entity.ToTable("System_DMS_FactoryChallan");

                entity.Property(e => e.HistoryId).HasColumnName("HistoryID");

                entity.Property(e => e.ChalanById).HasColumnName("ChalanByID");

                entity.Property(e => e.ChallanDate).HasColumnType("date");

                entity.Property(e => e.ChallanId).HasColumnName("ChallanID");

                entity.Property(e => e.ChallanNo).HasMaxLength(50);

                entity.Property(e => e.DepoId).HasColumnName("DepoID");

                entity.Property(e => e.EventTime).HasColumnType("datetime");

                entity.Property(e => e.EventType).HasMaxLength(50);

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.Host).HasMaxLength(50);

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.Remarks).HasMaxLength(300);
            });

            modelBuilder.Entity<SystemDmsFactoryChallanDetail>(entity =>
            {
                entity.HasKey(e => e.HistoryId);

                entity.ToTable("System_DMS_FactoryChallanDetail");

                entity.Property(e => e.HistoryId).HasColumnName("HistoryID");

                entity.Property(e => e.Asid).HasColumnName("ASID");

                entity.Property(e => e.ChallanDetailId).HasColumnName("ChallanDetailID");

                entity.Property(e => e.ChallanId).HasColumnName("ChallanID");

                entity.Property(e => e.EventTime).HasColumnType("datetime");

                entity.Property(e => e.EventType).HasMaxLength(50);

                entity.Property(e => e.Host).HasMaxLength(50);

                entity.Property(e => e.InsertUserId).HasColumnName("InsertUserID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");
            });

            modelBuilder.Entity<SystemDmsFactoryReceive>(entity =>
            {
                entity.HasKey(e => e.HistoryId);

                entity.ToTable("System_DMS_FactoryReceive");

                entity.Property(e => e.HistoryId).HasColumnName("HistoryID");

                entity.Property(e => e.EventTime).HasColumnType("datetime");

                entity.Property(e => e.EventType).HasMaxLength(50);

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.Fsid).HasColumnName("FSID");

                entity.Property(e => e.Fsrid).HasColumnName("FSRID");

                entity.Property(e => e.Host).HasMaxLength(50);

                entity.Property(e => e.ReceiveById).HasColumnName("ReceiveByID");

                entity.Property(e => e.ReceiveDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TablePkid>(entity =>
            {
                entity.ToTable("TablePKID");

                entity.HasIndex(e => e.TableName, "IX_TablePKID")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MaxId)
                    .HasMaxLength(50)
                    .HasColumnName("MaxID");

                entity.Property(e => e.TableName).HasMaxLength(100);
            });

            modelBuilder.Entity<TbEventLog>(entity =>
            {
                entity.HasKey(e => new { e.NDateTime, e.NEventIdn, e.NReaderIdn, e.NUserId });

                entity.ToTable("TB_EVENT_LOG");

                entity.Property(e => e.NDateTime).HasColumnName("nDateTime");

                entity.Property(e => e.NEventIdn).HasColumnName("nEventIdn");

                entity.Property(e => e.NReaderIdn).HasColumnName("nReaderIdn");

                entity.Property(e => e.NUserId).HasColumnName("nUserID");

                entity.Property(e => e.NEventLogIdn)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("nEventLogIdn");

                entity.Property(e => e.NIsLog).HasColumnName("nIsLog");

                entity.Property(e => e.NIsUseTa).HasColumnName("nIsUseTA");

                entity.Property(e => e.NTnaevent).HasColumnName("nTNAEvent");

                entity.Property(e => e.NType).HasColumnName("nType");
            });

            modelBuilder.Entity<TbReport>(entity =>
            {
                entity.HasKey(e => e.NIndex);

                entity.ToTable("tb_report");

                entity.Property(e => e.NIndex).HasColumnName("nIndex");

                entity.Property(e => e.SDateTime)
                    .HasMaxLength(255)
                    .HasColumnName("sDateTime");

                entity.Property(e => e.SField1)
                    .HasMaxLength(255)
                    .HasColumnName("sField1");

                entity.Property(e => e.SField10)
                    .HasMaxLength(255)
                    .HasColumnName("sField10");

                entity.Property(e => e.SField11)
                    .HasMaxLength(255)
                    .HasColumnName("sField11");

                entity.Property(e => e.SField12)
                    .HasMaxLength(255)
                    .HasColumnName("sField12");

                entity.Property(e => e.SField13)
                    .HasMaxLength(255)
                    .HasColumnName("sField13");

                entity.Property(e => e.SField14)
                    .HasMaxLength(255)
                    .HasColumnName("sField14");

                entity.Property(e => e.SField2)
                    .HasMaxLength(255)
                    .HasColumnName("sField2");

                entity.Property(e => e.SField3)
                    .HasMaxLength(255)
                    .HasColumnName("sField3");

                entity.Property(e => e.SField4)
                    .HasMaxLength(255)
                    .HasColumnName("sField4");

                entity.Property(e => e.SField5)
                    .HasMaxLength(255)
                    .HasColumnName("sField5");

                entity.Property(e => e.SField6)
                    .HasMaxLength(255)
                    .HasColumnName("sField6");

                entity.Property(e => e.SField7)
                    .HasMaxLength(255)
                    .HasColumnName("sField7");

                entity.Property(e => e.SField8)
                    .HasMaxLength(255)
                    .HasColumnName("sField8");

                entity.Property(e => e.SField9)
                    .HasMaxLength(255)
                    .HasColumnName("sField9");

                entity.Property(e => e.SName)
                    .HasMaxLength(255)
                    .HasColumnName("sName");

                entity.Property(e => e.SUserId).HasColumnName("sUserID");
            });

            modelBuilder.Entity<TblWeight>(entity =>
            {
                entity.ToTable("TBL_Weight");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ScaleId).HasColumnName("ScaleID");

                entity.Property(e => e.Weight)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TempOrder>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tempOrder");

                entity.Property(e => e.ChallanId).HasColumnName("ChallanID");

                entity.Property(e => e.EmployeementId).HasColumnName("EmployeementID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.OrderDate).HasColumnType("date");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.OrderTime)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.OutletId).HasColumnName("OutletID");
            });

            modelBuilder.Entity<TempUnionListUpdate>(entity =>
            {
                entity.ToTable("TempUnionListUpdate");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.District)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Divison)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Thana)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UnionName)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DMSSDWCDZeroBalanceReportStockSide>(entity =>
            {
                entity.ToTable("DMSSDWCDZeroBalanceReportStockSide");

                entity.Property(e => e.ID)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Date).HasColumnName("Date");

                entity.Property(e => e.SoleDepotID).HasColumnName("SoleDepotID");
                entity.Property(e => e.ProductID).HasColumnType("ProductID");
                entity.Property(e => e.ProductName).HasColumnType("ProductName");
                entity.Property(e => e.Sticks).HasColumnType("Sticks");
                entity.Property(e => e.TP).HasColumnType("TP");
                entity.Property(e => e.ZBRIID).HasColumnName("ZBRIID");
                entity.Property(e => e.TranType).HasColumnType("TranType");
                entity.Property(e => e.SubTranType).HasColumnType("SubTranType");
                entity.Property(e => e.Total).HasColumnType("Total");
                entity.Property(e => e.TotalAmount).HasColumnType("TotalAmount");
                entity.Property(e => e.Remarks).HasColumnType("Remarks");
                entity.Property(e => e.IsActive).HasColumnType("IsAcive");
                entity.Property(e => e.LastUpdate).HasColumnType("datetime");
            });

            modelBuilder.Entity<DMSSDWCDZeroBalanceReportExpenseSide>(entity =>
            {
                entity.ToTable("DMSSDWCDZeroBalanceReportExpenseSide");

                entity.Property(e => e.ID)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Date).HasColumnName("Date");
                entity.Property(e => e.SoleDepotID).HasColumnName("SoleDepotID");
                entity.Property(e => e.ProductID).HasColumnType("ProductID");
                entity.Property(e => e.ProductName).HasColumnType("ProductName");
                entity.Property(e => e.Sticks).HasColumnType("Sticks");
                entity.Property(e => e.TP).HasColumnType("TP");
                entity.Property(e => e.ZBRIID).HasColumnName("ZBRIID");
                entity.Property(e => e.TranType).HasColumnType("TranType");
                entity.Property(e => e.SubTranType).HasColumnType("SubTranType");
                entity.Property(e => e.Total).HasColumnType("Total");
                entity.Property(e => e.Remarks).HasColumnType("Remarks");
                entity.Property(e => e.IsActive).HasColumnType("IsAcive");
                entity.Property(e => e.LastUpdate).HasColumnType("datetime");
            });


            modelBuilder.Entity<DMSSDWZeroBalanceReportStockSide>(entity =>
            {
                entity.ToTable("DMSSDWZeroBalanceReportStockSide");

                entity.Property(e => e.ID)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Date).HasColumnName("Date");

                entity.Property(e => e.SoleDepotID).HasColumnName("SoleDepotID");
                entity.Property(e => e.ProductID).HasColumnType("ProductID");
                entity.Property(e => e.ProductName).HasColumnType("ProductName");
                entity.Property(e => e.Sticks).HasColumnType("Sticks");
                entity.Property(e => e.TP).HasColumnType("TP");
                entity.Property(e => e.ZBRIID).HasColumnName("ZBRIID");
                entity.Property(e => e.TranType).HasColumnType("TranType");
                entity.Property(e => e.SubTranType).HasColumnType("SubTranType");
                entity.Property(e => e.Total).HasColumnType("Total");
                entity.Property(e => e.TotalAmount).HasColumnType("TotalAmount");
                entity.Property(e => e.Remarks).HasColumnType("Remarks");
                entity.Property(e => e.IsActive).HasColumnType("IsAcive");
                entity.Property(e => e.LastUpdate).HasColumnType("datetime");
            });

            modelBuilder.Entity<DMSSDWZeroBalanceReportExpenseSide>(entity =>
            {
                entity.ToTable("DMSSDWZeroBalanceReportExpenseSide");

                entity.Property(e => e.ID)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Date).HasColumnName("Date");
                entity.Property(e => e.SoleDepotID).HasColumnName("SoleDepotID");
                entity.Property(e => e.ProductID).HasColumnType("ProductID");
                entity.Property(e => e.ProductName).HasColumnType("ProductName");
                entity.Property(e => e.Sticks).HasColumnType("Sticks");
                entity.Property(e => e.TP).HasColumnType("TP");
                entity.Property(e => e.ZBRIID).HasColumnName("ZBRIID");
                entity.Property(e => e.TranType).HasColumnType("TranType");
                entity.Property(e => e.SubTranType).HasColumnType("SubTranType");
                entity.Property(e => e.Total).HasColumnType("Total");
                entity.Property(e => e.Remarks).HasColumnType("Remarks");
                entity.Property(e => e.IsActive).HasColumnType("IsAcive");
                entity.Property(e => e.LastUpdate).HasColumnType("datetime");
            });

            modelBuilder.Entity<DMSADWZeroBalanceReportStockSide>(entity =>
            {
                entity.ToTable("DMSADWZeroBalanceReportStockSide");

                entity.Property(e => e.ID)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Date).HasColumnName("Date");

                entity.Property(e => e.AreaID).HasColumnName("AreaID");
                entity.Property(e => e.ProductID).HasColumnType("ProductID");
                entity.Property(e => e.ProductName).HasColumnType("ProductName");
                entity.Property(e => e.Sticks).HasColumnType("Sticks");
                entity.Property(e => e.TP).HasColumnType("TP");
                entity.Property(e => e.ZBRIID).HasColumnName("ZBRIID");
                entity.Property(e => e.TranType).HasColumnType("TranType");
                entity.Property(e => e.SubTranType).HasColumnType("SubTranType");
                entity.Property(e => e.Total).HasColumnType("Total");
                entity.Property(e => e.TotalAmount).HasColumnType("TotalAmount");
                entity.Property(e => e.Remarks).HasColumnType("Remarks");
                entity.Property(e => e.IsActive).HasColumnType("IsAcive");
                entity.Property(e => e.LastUpdate).HasColumnType("datetime");
            });

            modelBuilder.Entity<DMSADWZeroBalanceReportExpenseSide>(entity =>
            {
                entity.ToTable("DMSADWZeroBalanceReportExpenseSide");

                entity.Property(e => e.ID)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Date).HasColumnName("Date");
                entity.Property(e => e.AreaID).HasColumnName("AreaID");
                entity.Property(e => e.ProductID).HasColumnType("ProductID");
                entity.Property(e => e.ProductName).HasColumnType("ProductName");
                entity.Property(e => e.Sticks).HasColumnType("Sticks");
                entity.Property(e => e.TP).HasColumnType("TP");
                entity.Property(e => e.ZBRIID).HasColumnName("ZBRIID");
                entity.Property(e => e.TranType).HasColumnType("TranType");
                entity.Property(e => e.SubTranType).HasColumnType("SubTranType");
                entity.Property(e => e.Total).HasColumnType("Total");
                entity.Property(e => e.Remarks).HasColumnType("Remarks");
                entity.Property(e => e.IsActive).HasColumnType("IsAcive");
                entity.Property(e => e.LastUpdate).HasColumnType("datetime");
            });

            modelBuilder.Entity<VwcurrentDateDistinctGpstrackingPresentEmployee>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VWCurrentDateDistinct_GPSTrackingPresentEmployee");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            });

            modelBuilder.Entity<VwdellarSummaryReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VWDellar_SummaryReport");

                entity.Property(e => e.ChallanId).HasColumnName("ChallanID");

                entity.Property(e => e.DellarId).HasColumnName("DellarID");

                entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.LastUpdate).HasColumnType("date");

                entity.Property(e => e.OrderDate).HasColumnType("date");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.PayableAmount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Price).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.TotalPrice).HasColumnType("decimal(19, 3)");
            });

            modelBuilder.Entity<VwfacFactoryItemCurrentStock>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VWFAC_FactoryItemCurrentStock");

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.Fisid).HasColumnName("FISID");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.Qty).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Rn).HasColumnName("rn");

                entity.Property(e => e.StockDate).HasColumnType("date");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<VworderSummaryReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VWORDER_SummaryReport");

                entity.Property(e => e.ChallanId).HasColumnName("ChallanID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.EmployeementId).HasColumnName("EmployeementID");

                entity.Property(e => e.Fmax).HasColumnName("FMax");

                entity.Property(e => e.Fqty).HasColumnName("FQty");

                entity.Property(e => e.LastUpdate).HasColumnType("date");

                entity.Property(e => e.OrderDate).HasColumnType("date");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.OutletId).HasColumnName("OutletID");

                entity.Property(e => e.Price).HasColumnType("decimal(7, 3)");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.RouteId).HasColumnName("RouteID");

                entity.Property(e => e.Time)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TotalPrice).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Vwoutlet>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VWOutlets");

                entity.Property(e => e.Address).HasMaxLength(200);

                entity.Property(e => e.ClusterId).HasColumnName("ClusterID");

                entity.Property(e => e.ContactNo).HasMaxLength(50);

                entity.Property(e => e.DistrictName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.MarketName).HasMaxLength(50);

                entity.Property(e => e.OutletCode).HasMaxLength(50);

                entity.Property(e => e.OutletId).HasColumnName("OutletID");

                entity.Property(e => e.OutletName).HasMaxLength(100);

                entity.Property(e => e.Owner).HasMaxLength(100);

                entity.Property(e => e.RouteId).HasColumnName("RouteID");

                entity.Property(e => e.RouteName).HasMaxLength(200);

                entity.Property(e => e.TerrioryName).HasMaxLength(100);

                entity.Property(e => e.ThanaName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UnionId).HasColumnName("UnionID");

                entity.Property(e => e.UnionName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VillageName).HasMaxLength(50);
            });

            modelBuilder.Entity<VwsaleTargetSummaryReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VWSale_Target_SummaryReport");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.EmploymentId).HasColumnName("EmploymentID");

                entity.Property(e => e.OutletAddress).HasMaxLength(200);

                entity.Property(e => e.OutletId).HasColumnName("OutletID");

                entity.Property(e => e.OutletName).HasMaxLength(302);

                entity.Property(e => e.Pcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PCode");

                entity.Property(e => e.PlanDate).HasColumnType("date");

                entity.Property(e => e.PlanId).HasColumnName("PlanID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ProductName).HasMaxLength(100);

                entity.Property(e => e.TplanItemId).HasColumnName("TPlanItemID");
            });

            modelBuilder.Entity<VwscmAreaCurrentStock>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VWSCM_AreaCurrentStock");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.Asid).HasColumnName("ASID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Rn).HasColumnName("rn");

                entity.Property(e => e.StockDate).HasColumnType("datetime");

                entity.Property(e => e.Tp)
                    .HasColumnType("decimal(2, 2)")
                    .HasColumnName("TP");
            });

            modelBuilder.Entity<VwscmAreaCurrentStockForSale>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VWSCM_AreaCurrentStockForSale");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.Asid).HasColumnName("ASID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Rn).HasColumnName("rn");

                entity.Property(e => e.StockDate).HasColumnType("datetime");

                entity.Property(e => e.Tp)
                    .HasColumnType("decimal(5, 3)")
                    .HasColumnName("TP");

                entity.Property(e => e.TransactionDate).HasColumnType("date");
            });

            modelBuilder.Entity<VwscmDepoCurrentStock>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VWSCM_DepoCurrentStock");

                entity.Property(e => e.DepoId).HasColumnName("DepoID");

                entity.Property(e => e.Dsid).HasColumnName("DSID");

                entity.Property(e => e.Rn).HasColumnName("rn");

                entity.Property(e => e.StockDate).HasColumnType("datetime");

                entity.Property(e => e.Tp)
                    .HasColumnType("decimal(2, 2)")
                    .HasColumnName("TP");
            });

            modelBuilder.Entity<VwscmFacToFacCurrentStock>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VWSCM_FacToFacCurrentStock");

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.Fisid).HasColumnName("FISID");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.Qty).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Rn).HasColumnName("rn");

                entity.Property(e => e.StockDate).HasColumnType("date");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<VwscmFactoryCurrentStock>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VWSCM_FactoryCurrentStock");

                entity.Property(e => e.FactoryId).HasColumnName("FactoryID");

                entity.Property(e => e.Fsid).HasColumnName("FSID");

                entity.Property(e => e.Rn).HasColumnName("rn");

                entity.Property(e => e.StockDate).HasColumnType("datetime");

                entity.Property(e => e.Tp)
                    .HasColumnType("decimal(4, 2)")
                    .HasColumnName("TP");
            });

            modelBuilder.Entity<VwscmNapkinAreaCurrentStock>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VWSCM_NapkinAreaCurrentStock");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.Asid).HasColumnName("ASID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Rn).HasColumnName("rn");

                entity.Property(e => e.StockDate).HasColumnType("datetime");

                entity.Property(e => e.Tp)
                    .HasColumnType("decimal(5, 3)")
                    .HasColumnName("TP");

                entity.Property(e => e.TransactionDate).HasColumnType("date");
            });

            modelBuilder.Entity<VwscmNapkinDepoCurrentStock>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VWSCM_NapkinDepoCurrentStock");

                entity.Property(e => e.DepoId).HasColumnName("DepoID");

                entity.Property(e => e.Dsid).HasColumnName("DSID");

                entity.Property(e => e.Rn).HasColumnName("rn");

                entity.Property(e => e.StockDate).HasColumnType("datetime");

                entity.Property(e => e.Tp)
                    .HasColumnType("decimal(5, 3)")
                    .HasColumnName("TP");
            });

            modelBuilder.HasSequence("BanKPK").StartsAt(104);

            modelBuilder.HasSequence("OrderDetailPK").StartsAt(9032582);

            modelBuilder.HasSequence("OrderDetailPointPK").StartsAt(3333671);

            modelBuilder.HasSequence("OrderPK").StartsAt(8114188);

            modelBuilder.HasSequence("OrderPointPK").StartsAt(646600);

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
