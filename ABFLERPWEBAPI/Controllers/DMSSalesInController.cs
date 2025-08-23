using ABFLERPWEBAPI.BO;
using ABFLERPWEBAPI.Models;
using ABFLERPWEBAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Linq.Expressions;
using System.Net;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ABFLERPWEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DMSSalesInController : ControllerBase
    {

        private readonly AkijSCMSDBContext _dbContext;
        private readonly TranslationService _translationService;
        public DMSSalesInController(AkijSCMSDBContext dbContext)
        {
            _dbContext = dbContext;
            string apiKey = "AIzaSyC6yMsRNjdgF4tZFiLhBgkc35mINsImZ_M";
            _translationService = new TranslationService(apiKey);
        }

        [HttpPost]
        [Route("InsertSalesInInfo")]
        public async Task<Response> PostSalesInInfo(ArrayList arrayList)
        {
            try
            {
                BO.DMS_SaleOutData objSaleData = Newtonsoft.Json.JsonConvert.DeserializeObject<BO.DMS_SaleOutData>(arrayList[0].ToString());
                List<BO.SET_SalesTargetTypeInc> objSTTIList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<BO.SET_SalesTargetTypeInc>>(arrayList[1].ToString());
                Response response = new Response();

                bool flag = true;
                long num1 = 0;
                long valueOrDefault1 = _dbContext.DmsSamples.Max(m => (long?)m.SampleId) ?? 0;
                long valueOrDefault2 = _dbContext.DmsSampleItems.Max(m => (long?)m.SampleItemId) ?? 0;
                //long valueOrDefault3 = _dbContext.AccIncomeExpenseMasters.Max(m => (long?)m.Id) ?? 0;
                //long valueOrDefault4 = _dbContext.AccIncomeExpenseDetails.Max(m => (long?)m.Id) ?? 0;
                long valueOrDefault3 = await GetIncomeExpenseMasterPK();
                long valueOrDefault4 = await GetIncomeExpenseDetailsPK();
                long valueOrDefault5 = _dbContext.DmsAreaStocks.Max(m => (long?)m.Asid) ?? 0;
                long valueOrDefault6 = _dbContext.DmsDamageMasters.Max(m => (long?)m.Id) ?? 0;
                long valueOrDefault7 = _dbContext.DmsDamageDetails.Max(m => (long?)m.Id) ?? 0;
                long valueOrDefault8 = _dbContext.DmsBpacketMasters.Max(m => (long?)m.Id) ?? 0;
                long valueOrDefault9 = _dbContext.DmsBpacketDetails.Max(m => (long?)m.Id) ?? 0;
                long valueOrDefault10 = _dbContext.DmsBpacketStocks.Max(m => (long?)m.Bpsid) ?? 0;
                long valueOrDefault11 = _dbContext.DmsIncentiveMasters.Max(m => (long?)m.IncentiveId) ?? 0;
                long valueOrDefault12 = _dbContext.DmsIncentiveDetails.Max(m => (long?)m.Id) ?? 0;
                long maxSTTTotalMemoID = _dbContext.DMSSalesTargetWiseTotalMemos.Max(m => (long?)m.ID) ?? 0;
                //long maxOrderId = _dbContext.DmsOrders.Max(m => (long?)m.OrderId) ?? 0;
                //long maxOrderDetailsId = _dbContext.DmsOrderDetails.Max(m => (long?)m.OrderDetailId) ?? 0;


                long orderId = 0;
                long challanId = 0;

                if (objSaleData.OrderSale.OrderDetail.Count > 0)
                {
                    BO.DMS_Orders objOrder = objSaleData.OrderSale;
                    if (this._dbContext.DmsOrders.FirstOrDefault(m => m.ChallanId == objOrder.ChallanID) == null)
                    {
                        Models.DmsOrder modelObject1 = new DmsOrder();
                        modelObject1.LastUpdate = DateTime.Now;
                        modelObject1.OrderId = await GetOrderPrimaryKey();
                        orderId = modelObject1.OrderId;
                        modelObject1.ChallanId = objSaleData.ChallanID;
                        challanId = modelObject1.ChallanId;
                        modelObject1.EmployeementId = objOrder.EmployementID;
                        modelObject1.MemoStart = objOrder.MemoStart;
                        modelObject1.MemoEnd = objOrder.MemoEnd;
                        modelObject1.RouteID = _dbContext.DmsAreaDeliveryChallans.FirstOrDefault(m => m.ChallanId == modelObject1.ChallanId).RouteId;
                        modelObject1.DivisionID = objOrder.DivisionID;
                        modelObject1.DepoID = objOrder.DepoID;
                        modelObject1.RegionID = objOrder.RegionID;
                        modelObject1.AreaID = objOrder.AreaID;
                        modelObject1.TerritoryID = objOrder.TerritoryID;
                        modelObject1.IsPointOrder = objOrder.IsPointOrder;
                        modelObject1.Day = (byte)objOrder.OrderDate.Day;
                        modelObject1.Month = (byte)objOrder.OrderDate.Month;
                        modelObject1.Year = (short)objOrder.OrderDate.Year;
                        modelObject1.LastUpdate = DateTime.Now;
                        modelObject1.OrderDate = objOrder.OrderDate;
                        this._dbContext.DmsOrders.Add(modelObject1);
                        flag = true;
                        foreach (BO.DMS_OrderDetail dmsOrderDetail in objOrder.OrderDetail)
                        {
                            if (dmsOrderDetail.Qty > 0)
                            {

                                Models.DmsOrderDetail modelObject2 = new Models.DmsOrderDetail();
                                modelObject2.OrderDetailId = await GetOrderDetailPK();
                                modelObject2.OrderId = modelObject1.OrderId;
                                modelObject2.ProductId = dmsOrderDetail.ProductID;
                                modelObject2.Quantity = dmsOrderDetail.Qty;
                                modelObject2.Tp = dmsOrderDetail.TP;
                                if (modelObject2.ProductId == 3)
                                {
                                    decimal packet = modelObject2.Quantity / 12;
                                    modelObject2.GrossTotal = Convert.ToDecimal((Decimal)packet * dmsOrderDetail.TPPerPacket);
                                }
                                else
                                {
                                    modelObject2.GrossTotal = (Decimal)modelObject2.Quantity * modelObject2.Tp;
                                }
                                modelObject2.Fqty = dmsOrderDetail.FQty;
                                modelObject2.BpacketMax = dmsOrderDetail.BlankPacket;
                                modelObject2.DamageQty = new int?(dmsOrderDetail.DamageQty);
                                modelObject2.IncentiveQty = dmsOrderDetail.IncentiveQty;
                                modelObject2.LastUpdate = DateTime.Now;
                                this._dbContext.DmsOrderDetails.Add(modelObject2);
                            }
                        }

                        foreach (var objSST in objSTTIList)
                        {
                            Models.DMSSalesTargetWiseTotalMemo objSTWTM = new Models.DMSSalesTargetWiseTotalMemo();
                            objSTWTM.ID = ++maxSTTTotalMemoID;
                            objSTWTM.CallanID = challanId;
                            objSTWTM.OrderID = orderId;
                            objSTWTM.STTID = objSST.ID;
                            objSTWTM.StartMemo = objSST.MemoStart.ToString();
                            objSTWTM.EndMemo = objSST.MemoEnd.ToString();
                            objSTWTM.TotalMemo = (short)objSST.TotalMemo;
                            objSTWTM.LastUpdate = DateTime.Now;
                            this._dbContext.DMSSalesTargetWiseTotalMemos.Add(objSTWTM);
                        }
                    }
                }
                if (objSaleData.Sample.SampleDetailList.Count > 0)
                {
                    DMS_Sample sample = objSaleData.Sample;
                    sample.SampleID = ++valueOrDefault1;
                    sample.Day = (short)(byte)sample.SampleDate.Day;
                    sample.Month = (short)(byte)sample.SampleDate.Month;
                    sample.Year = sample.SampleDate.Year;
                    sample.LastUpdate = DateTime.Now;
                    if (sample.SampleDetailList.Count > 0)
                    {
                        if (this._dbContext.DmsSamples.FirstOrDefault(m => m.ChallanId == objSaleData.ChallanID) == null)
                        {
                            this._dbContext.DmsSamples.Add(new Models.DmsSample()
                            {
                                SampleId = sample.SampleID,
                                EmployeementId = sample.EmployementId,
                                ChallanId = sample.ChallanID,
                                SampleDate = sample.SampleDate,
                                Day = (byte)sample.Day,
                                Month = (byte)sample.Month,
                                Year = (short)sample.Year,
                                LastUpdate = DateTime.Now
                            });
                            foreach (BO.DMS_SampleItem sampleDetail in sample.SampleDetailList)
                            {
                                if (sampleDetail.Qty > 0)
                                {
                                    sampleDetail.SampleItemID = ++valueOrDefault2;
                                    sampleDetail.SampleID = sample.SampleID;
                                    sampleDetail.LastUpdate = DateTime.Now;
                                    this._dbContext.DmsSampleItems.Add(new DmsSampleItem()
                                    {
                                        SampleItemId = sampleDetail.SampleItemID,
                                        SampleId = sampleDetail.SampleID,
                                        ProductId = sampleDetail.ProductID,
                                        Quantity = sampleDetail.Qty,
                                        SampleTypeID = (short)sampleDetail.SampleTypeID,
                                        LastUpdate = sampleDetail.LastUpdate
                                    });
                                }
                            }
                        }
                    }
                }
                if (objSaleData.Damage.DamageDetail.Count > 0)
                {
                    BO.DMS_DamageMaster damage = objSaleData.Damage;
                    Models.DmsDamageMaster dMS_DamageMaster = this._dbContext.DmsDamageMasters.FirstOrDefault(m => m.ChallanId == objSaleData.ChallanID);
                    if (dMS_DamageMaster == null)
                    {
                        dMS_DamageMaster.LastUpdate = DateTime.Now;
                        long num2;
                        dMS_DamageMaster.Id = num2 = valueOrDefault6 + 1L;
                        dMS_DamageMaster.ChallanId = objSaleData.ChallanID;
                        dMS_DamageMaster.EmployementId = damage.EmployementID;
                        this._dbContext.DmsDamageMasters.Add(dMS_DamageMaster);
                    }
                    foreach (BO.DMS_DamageDetail B_DMS_DamageDetail in damage.DamageDetail)
                    {
                        if (B_DMS_DamageDetail.Quantity > 0L)
                        {
                            long num2 = ++valueOrDefault5;
                            Models.DmsAreaStock B_DMS_AreaStock = new Models.DmsAreaStock();
                            B_DMS_AreaStock.AreaId = objSaleData.AreaID;
                            B_DMS_AreaStock.ProductId = B_DMS_DamageDetail.ProductID;
                            B_DMS_AreaStock.StockType = (byte)2;
                            B_DMS_AreaStock.StockDate = DateTime.Now;
                            B_DMS_AreaStock.Tp = B_DMS_DamageDetail.TP;
                            BO.DMS_AreaStock productAndAreaId = this.GetDMS_AreaStockByProductAndAreaID(B_DMS_AreaStock.ProductId, B_DMS_AreaStock.AreaId, B_DMS_AreaStock.StockType);
                            B_DMS_AreaStock.Qty = B_DMS_DamageDetail.Quantity;
                            B_DMS_AreaStock.Balance = productAndAreaId.Balance + B_DMS_AreaStock.Qty;
                            B_DMS_AreaStock.Asid = num2;
                            B_DMS_AreaStock.TransactionDate = new DateTime?(damage.Date);
                            this._dbContext.DmsAreaStocks.Add(B_DMS_AreaStock);
                            Models.DmsDamageDetail dmsDamageDetail = new Models.DmsDamageDetail();
                            dmsDamageDetail.Id = ++valueOrDefault7;
                            dmsDamageDetail.Dmid = dMS_DamageMaster.Id;
                            dmsDamageDetail.ProductId = B_DMS_DamageDetail.ProductID;
                            dmsDamageDetail.Quantity = B_DMS_DamageDetail.Quantity;
                            dmsDamageDetail.Asid = B_DMS_AreaStock.Asid;
                            this._dbContext.DmsDamageDetails.Add(dmsDamageDetail);
                        }
                    }
                }
                if (objSaleData.Incentive.IncentiveDetailList.Count > 0)
                {
                    //DMS_Sample sample = objSaleData.Sample;
                    //long num2;
                    //long num3 = num2 = valueOrDefault1 + 1L;
                    //sample.SampleID = num2;
                    //int day = (int)(byte)sample.SampleDate.Day;
                    //sample.Day = (short)day;
                    //int month = (int)(byte)sample.SampleDate.Month;
                    //sample.Month = (short)month;
                    //int year = sample.SampleDate.Year;
                    //sample.Year = year;
                    //DateTime now = DateTime.Now;
                    //sample.LastUpdate = now;
                    BO.DMS_IncentiveMaster incentive = objSaleData.Incentive;
                    Models.DmsIncentiveMaster dMS_IncentiveMaster = this._dbContext.DmsIncentiveMasters.FirstOrDefault(m => m.ChallanId == objSaleData.ChallanID);
                    if (dMS_IncentiveMaster == null)
                    {
                        dMS_IncentiveMaster = new Models.DmsIncentiveMaster();
                        long num4;
                        dMS_IncentiveMaster.IncentiveId = num4 = valueOrDefault11 + 1L;
                        dMS_IncentiveMaster.ChallanId = objSaleData.ChallanID;
                        dMS_IncentiveMaster.EmployeementId = incentive.EmployementID;
                        dMS_IncentiveMaster.IncentiveDate = incentive.Date;
                        dMS_IncentiveMaster.LastUpdate = DateTime.Now;
                        this._dbContext.DmsIncentiveMasters.Add(dMS_IncentiveMaster);
                    }
                    foreach (BO.DMS_IncentiveDetail incentiveDetail in incentive.IncentiveDetailList)
                        this._dbContext.DmsIncentiveDetails.Add(new Models.DmsIncentiveDetail()
                        {
                            Id = ++valueOrDefault12,
                            IncentiveId = dMS_IncentiveMaster.IncentiveId,
                            ProductId = incentiveDetail.ProductID,
                            Quantity = (int)incentiveDetail.Quantity,
                            LastUpdate = DateTime.Now
                        });
                }
                if (objSaleData.BPacket.BPacketDetail.Count > 0)
                {
                    BO.DMS_BPacketMaster bpacket = objSaleData.BPacket;
                    Models.DmsBpacketMaster dMS_BPacketMaster = this._dbContext.DmsBpacketMasters.FirstOrDefault(m => m.ChallanId == objSaleData.ChallanID);
                    if (dMS_BPacketMaster == null)
                    {
                        dMS_BPacketMaster = new Models.DmsBpacketMaster();
                        long num2;
                        dMS_BPacketMaster.Id = num2 = valueOrDefault8 + 1L;
                        dMS_BPacketMaster.ChallanId = objSaleData.ChallanID;
                        dMS_BPacketMaster.EmployementId = bpacket.EmployementID;
                        dMS_BPacketMaster.LastUpdate = DateTime.Now;
                        this._dbContext.DmsBpacketMasters.Add(dMS_BPacketMaster);
                    }
                    foreach (BO.DMS_BPacketDetail dmsBpacketDetail in bpacket.BPacketDetail)
                    {
                        if (dmsBpacketDetail.StickQty > 0L)
                        {
                            Models.DmsBpacketStock dMS_BPacketStock = new Models.DmsBpacketStock();
                            dMS_BPacketStock.Bpsid = ++valueOrDefault10;
                            dMS_BPacketStock.AreaId = objSaleData.AreaID;
                            dMS_BPacketStock.ProductId = (int)dmsBpacketDetail.ProductID;
                            dMS_BPacketStock.Qty = (int)dmsBpacketDetail.StickQty;
                            dMS_BPacketStock.LastUpdate = DateTime.Now;
                            BO.DMS_BPacketStock productAndAreaId = this.GetDMS_BlankPacketStockByProductAndAreaID(dMS_BPacketStock.ProductId, dMS_BPacketStock.AreaId);
                            dMS_BPacketStock.Balance = Convert.ToInt32(productAndAreaId.Balance + (long)dMS_BPacketStock.Qty);
                            this._dbContext.DmsBpacketStocks.Add(dMS_BPacketStock);
                            this._dbContext.DmsBpacketDetails.Add(new Models.DmsBpacketDetail()
                            {
                                Id = ++valueOrDefault9,
                                BpacketMasterId = dMS_BPacketMaster.Id,
                                ProductId = dmsBpacketDetail.ProductID,
                                Bpsid = dMS_BPacketStock.Bpsid,
                                PacketQty = dmsBpacketDetail.PacketQty,
                                StickQty = dmsBpacketDetail.StickQty
                            });
                        }
                    }
                }
                if (objSaleData.SaleIncome.IncomeExpense.Count > 0)
                {
                    BO.ACC_IncomeExpenseMaster saleIncome = objSaleData.SaleIncome;
                    Models.AccIncomeExpenseMaster aCC_IncomeExpenseMaster = new Models.AccIncomeExpenseMaster();
                    aCC_IncomeExpenseMaster.Id = ++valueOrDefault3;
                    aCC_IncomeExpenseMaster.VoucherNo = (string)null;
                    aCC_IncomeExpenseMaster.ResponsibleId = saleIncome.ResponsibleID;
                    aCC_IncomeExpenseMaster.AreaId = saleIncome.AreaID;
                    aCC_IncomeExpenseMaster.RegionId = new int?();
                    aCC_IncomeExpenseMaster.IeheaderId = (byte)1;
                    aCC_IncomeExpenseMaster.DepoId = new int?();
                    aCC_IncomeExpenseMaster.FactoryId = new byte?();
                    aCC_IncomeExpenseMaster.IsHeadOffice = false;
                    aCC_IncomeExpenseMaster.PayDate = saleIncome.PayDate;
                    aCC_IncomeExpenseMaster.Iedate = new DateTime?(saleIncome.IEDate);
                    aCC_IncomeExpenseMaster.Description = saleIncome.Description;
                    Decimal wiseClosingAmount = this.GetAreaWiseClosingAmount(saleIncome.AreaID);
                    aCC_IncomeExpenseMaster.Balance = wiseClosingAmount + saleIncome.Amount;
                    aCC_IncomeExpenseMaster.Amount = saleIncome.Amount;
                    this._dbContext.AccIncomeExpenseMasters.Add(aCC_IncomeExpenseMaster);
                    foreach (BO.ACC_IncomeExpense accIncomeExpense in saleIncome.IncomeExpense)
                        this._dbContext.AccIncomeExpenseDetails.Add(new AccIncomeExpenseDetail()
                        {
                            Id = ++valueOrDefault4,
                            Emid = aCC_IncomeExpenseMaster.Id,
                            PurposeId = (short)35,
                            Amount = accIncomeExpense.Amount
                        });
                }
                if (objSaleData.AreaChallan.AreaDeliveryChallanItemList.Count > 0)
                {
                    BO.DMS_AreaDeliveryChallan objChallan = objSaleData.AreaChallan;
                    foreach (BO.DMS_AreaDeliveryChallanItem deliveryChallanItem1 in (IEnumerable<BO.DMS_AreaDeliveryChallanItem>)objChallan.AreaDeliveryChallanItemList)
                    {
                        Models.DmsAreaStock objAreaStock = new Models.DmsAreaStock();
                        objAreaStock.AreaId = objChallan.AreaID;
                        objAreaStock.ProductId = deliveryChallanItem1.ProductID;
                        objAreaStock.StockType = (byte)1;
                        objAreaStock.StockDate = DateTime.Now;
                        objAreaStock.Tp = deliveryChallanItem1.TP;
                        //objAreaStock.LastUpdate = DateTime.Now;
                        BO.DMS_AreaStock productAndAreaId = this.GetDMS_AreaStockByProductAndAreaID(objAreaStock.ProductId, objAreaStock.AreaId, objAreaStock.StockType);
                        objAreaStock.Qty = Convert.ToInt64((object)deliveryChallanItem1.ReturnQty);
                        objAreaStock.Balance = productAndAreaId.Balance + Convert.ToInt64(objAreaStock.Qty);
                        objAreaStock.TransactionDate = new DateTime?(objChallan.ChallanDate);
                        objAreaStock.Asid = ++valueOrDefault5;
                        this._dbContext.DmsAreaStocks.Add(objAreaStock);
                        Models.DmsAreaDeliveryChallanItem deliveryChallanItem2 = this._dbContext.DmsAreaDeliveryChallanItems.First(m => m.ChallanId == objChallan.ChallanID && (int)m.ProductId == (int)objAreaStock.ProductId);
                        long? returnQty = deliveryChallanItem1.ReturnQty;
                        long? totalOut = deliveryChallanItem1.TotalOut;
                        long? nullable = returnQty.HasValue & totalOut.HasValue ? new long?(returnQty.GetValueOrDefault() + totalOut.GetValueOrDefault()) : new long?();
                        long challanQty = deliveryChallanItem2.ChallanQty;
                        if (nullable.GetValueOrDefault() == challanQty & nullable.HasValue)
                        {
                            deliveryChallanItem2.ReturnAsid = new long?(objAreaStock.Asid);
                            deliveryChallanItem2.ReturnQty = deliveryChallanItem1.ReturnQty;
                            deliveryChallanItem2.LastUpdate = DateTime.Now;
                            this._dbContext.DmsAreaDeliveryChallanItems.Update(deliveryChallanItem2);
                        }
                        else
                        {
                            flag = false;
                            break;
                        }
                    }
                }
                if (flag)
                {
                    Models.DmsAreaDeliveryChallan areaDeliveryChallan = this._dbContext.DmsAreaDeliveryChallans.First(m => m.ChallanId == objSaleData.AreaChallan.ChallanID);
                    if (objSaleData.SaleIncome.IncomeExpense.Count > 0)
                        areaDeliveryChallan.Ieid = new long?(valueOrDefault3);
                    areaDeliveryChallan.IsApprovedByAccounts = true;
                    areaDeliveryChallan.IsApprovedByAm = true;
                    areaDeliveryChallan.LastUpdate = new DateTime?(DateTime.Now);
                    this._dbContext.DmsAreaDeliveryChallans.Update(areaDeliveryChallan);
                    Models.DmsReportAreaChallan reportAreaChallan = this._dbContext.DmsReportAreaChallans.First(m => m.ChallanId == objSaleData.AreaChallan.ChallanID);
                    if (objSaleData.SaleIncome.IncomeExpense.Count > 0)
                        reportAreaChallan.Ieid = new long?(valueOrDefault3);
                    reportAreaChallan.IsApprovedByAccounts = true;
                    reportAreaChallan.IsApprovedByAm = true;
                    areaDeliveryChallan.LastUpdate = new DateTime?(DateTime.Now);
                    this._dbContext.DmsReportAreaChallans.Update(reportAreaChallan);

                }
                if (_dbContext.SaveChanges() > 0)
                {
                    response.StatusCode = 200;
                    response.StatusMessage = "Save Success";
                }
                else
                {
                    response.StatusCode = 100;
                    response.StatusMessage = "Failed";
                }
                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Decimal GetAreaWiseClosingAmount(int? areaId)
        {
            Decimal num = new Decimal();
            var incomeExpenseMaster = this._dbContext.AccIncomeExpenseMasters.OrderByDescending(rec => rec.Id).FirstOrDefault(m => m.AreaId == areaId);
            if (incomeExpenseMaster != null)
                num = incomeExpenseMaster.Balance;
            return num;
        }
        private async Task<long> GetOrderDetailPK()
        {
            long nextValue;

            using (var command = _dbContext.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = "SELECT NEXT VALUE FOR OrderDetailPK";
                await _dbContext.Database.OpenConnectionAsync();

                var result = await command.ExecuteScalarAsync();
                nextValue = Convert.ToInt64(result);
            }

            return nextValue;
        }

        private async Task<long> GetOrderPrimaryKey()
        {
            long nextValue;

            using (var command = _dbContext.Database.GetDbConnection().CreateCommand())
            { 
                command.CommandText = "SELECT NEXT VALUE FOR OrderPK";
                await _dbContext.Database.OpenConnectionAsync();

                var result = await command.ExecuteScalarAsync();
                nextValue = Convert.ToInt64(result);
            }

            return nextValue;
        }



        private async Task<long> GetIncomeExpenseMasterPK()
        {
            long nextValue;

            using (var command = _dbContext.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = "SELECT NEXT VALUE FOR IncomeExpenseMaster";
                await _dbContext.Database.OpenConnectionAsync();

                var result = await command.ExecuteScalarAsync();
                nextValue = Convert.ToInt64(result);
            }

            return nextValue;
        }

        private async Task<long> GetIncomeExpenseDetailsPK()
        {
            long nextValue;

            using (var command = _dbContext.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = "SELECT NEXT VALUE FOR IncomeExpenseDetails";
                await _dbContext.Database.OpenConnectionAsync();

                var result = await command.ExecuteScalarAsync();
                nextValue = Convert.ToInt64(result);
            }

            return nextValue;
        }

        private BO.DMS_AreaStock GetDMS_AreaStockByProductAndAreaID(short ProductID, int AreaID, byte stockType)
        {
            BO.DMS_AreaStock dmsAreaStock1 = new BO.DMS_AreaStock();
            Models.DmsAreaStock dmsAreaStock2 = this._dbContext.DmsAreaStocks.OrderByDescending(m => m.Asid).FirstOrDefault(m => m.AreaId == AreaID && (int)m.ProductId == (int)ProductID && (int)m.StockType == stockType);
            if (dmsAreaStock2 != null)
            {
                dmsAreaStock1.ProductID = dmsAreaStock2.ProductId;
                dmsAreaStock1.Qty = dmsAreaStock2.Qty;
                dmsAreaStock1.Balance = dmsAreaStock2.Balance;
                dmsAreaStock1.ASID = dmsAreaStock2.Asid;
            }
            return dmsAreaStock1;
        }

        private BO.DMS_BPacketStock GetDMS_BlankPacketStockByProductAndAreaID(int productId, int areaId)
        {
            BO.DMS_BPacketStock dmsBpacketStock1 = new BO.DMS_BPacketStock();
            var dmsBpacketStock2 = _dbContext.DmsBpacketStocks.OrderByDescending(m => m.Bpsid).FirstOrDefault(m => m.AreaId == areaId && m.ProductId == productId);
            if (dmsBpacketStock2 != null)
            {
                dmsBpacketStock1.ProductID = (short)dmsBpacketStock2.ProductId;
                dmsBpacketStock1.Qty = (long)dmsBpacketStock2.Qty;
                dmsBpacketStock1.Balance = (long)dmsBpacketStock2.Balance;
                dmsBpacketStock1.BPSID = dmsBpacketStock2.Bpsid;
            }
            return dmsBpacketStock1;
        }

        //[HttpGet("GetOutletListByRouteID")]
        //public async Task<ActionResult<List<SetOutlet>>> GetOutletListByRouteID(int routeID)
        //{
        //    var routeWiseOutletList = await _dbContext.SetOutlets.Where(m => m.RouteId == routeID).ToListAsync();
        //    List<string> outletNameList = new List<string>();
        //    foreach (var objOutlet in routeWiseOutletList)
        //    {
        //        string banglaOutlet = _translationService.TranslateToBangla(objOutlet.OutletName);
        //        outletNameList.Add(banglaOutlet);
        //    }
        //    return Ok(routeWiseOutletList);
        //}

        //[HttpGet("GetOutletDetailsData")]
        //public async Task<IActionResult> GetOutletDetailsData(int DivisionID, int DepoID, int RegionID, int AreaID, int TerritoryID, int RouteID)
        //{
        //    var outletData = await _dbContext.AndroidAppsGetOutletDetailsDatas.FromSqlRaw($"AndroidAppsGetOutletDetailsData @DivisionID={DivisionID}, @DepoID={DepoID}, @RegionID={RegionID}, @AreaID={AreaID}, @TerritoryID={TerritoryID},@RouteID={RouteID}").ToListAsync();
        //    return Ok(outletData);
        //}
    }
}
