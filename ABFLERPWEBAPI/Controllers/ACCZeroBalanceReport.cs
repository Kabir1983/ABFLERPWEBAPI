using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ABFLERPWEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ACCZeroBalanceReport : ControllerBase
    {

        private readonly AkijSCMSDBContext _dbContext;
        public ACCZeroBalanceReport(AkijSCMSDBContext dbContext)
        {
            _dbContext = dbContext;
        }


        // GET: api/<DMSFactoryProductionBarcodeController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };

        }

        // GET api/<DMSFactoryProductionBarcodeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpGet("GetSoleDepotWithChildDepotZeroBalance")]
        public async Task<ActionResult<List<ACCSPGETTopSheetProductStockForDepotWithChildDepot>>> GetSoleDepotWithChildDepotZeroBalanceReport(int depotID, string date)
        {
            var zeroBalanceReportData = await _dbContext.ACCSPGETTopSheetProductStockForDepotWithChildDepots.FromSqlRaw($"ACCSPGETTopSheetProductStockForDepotWithChildDepot @DepoID= {depotID}, @DateFrom='{date}', @DateTo='{date}'").ToListAsync();
            return Ok(zeroBalanceReportData);
        }

        //[HttpGet("GetSoleDepotWithChildDepotZeroBalance")]
        //public async Task<ActionResult<List<ACCSPGETTopSheetProductStockForDepotWithChildDepot>>> GetSoleDepotWithChildDepotZeroBalanceReport(int depotID, string date)
        //{
        //    var zeroBalanceReportData = await _dbContext.ACCSPGETTopSheetProductStockForDepotWithChildDepots.FromSqlRaw($"
        //        @DepoID= {depotID}, @DateFrom='{date}', @DateTo='{date}'").ToListAsync();
        //    return Ok(zeroBalanceReportData);
        //}

        [HttpGet("GetDateWiseSDWithCDepotZeroBalanceStockPart")]
        public async Task<ActionResult<List<ACCSPGETTopSheetProductStockForDepotWithChildDepot>>> GetDateWiseSDWithCDepotZeroBalanceStockPart(int depotID, string dateFrom, string dateTo)
        {
            var zeroBalanceReportData = await _dbContext.ACCSPGETTopSheetProductStockForDepotWithChildDepots.FromSqlRaw($"ACCGETDateWiseSDWithCDZeroBalanceReportStockParts @DepoID= {depotID}, @DateFrom='{dateFrom}', @DateTo='{dateTo}'").ToListAsync();
            return Ok(zeroBalanceReportData);
        }

        [HttpGet("GetDateWiseSDWithCDepotZeroBalanceCashPart")]
        public async Task<ActionResult<List<ACCSPGETTopSheetProductExpenseForDepotWithChildDepot>>> GetDateWiseSDWithCDepotZeroBalanceCashPart(int depotID, string dateFrom, string dateTo)
        {
            var zeroBalanceReportData = await _dbContext.ACCSPGETTopSheetProductExpenseForDepotWithChildDepots.FromSqlRaw($"ACCGETDateWiseSDWithCDZeroBalanceReportExpenseParts @DepoID= {depotID}, @DateFrom='{dateFrom}', @DateTo='{dateTo}'").ToListAsync();
            return Ok(zeroBalanceReportData);
        }

        [HttpGet("GetDateWiseNationalZeroBalanceStockPart")]
        public async Task<ActionResult<List<ACCSPGETTopSheetProductStockForDepotWithChildDepot>>> GetDateWiseNationalZeroBalanceStockPart(int depotID, string dateFrom, string dateTo)
        {
            var zeroBalanceReportData = await _dbContext.ACCSPGETTopSheetProductStockForDepotWithChildDepots.FromSqlRaw($"ACCGETDateWiseNationalZeroBalanceReportStockParts @DateFrom='{dateFrom}', @DateTo='{dateTo}'").ToListAsync();
            return Ok(zeroBalanceReportData);
        }

        [HttpGet("GetDateWiseNationalZeroBalanceCashPart")]
        public async Task<ActionResult<List<ACCSPGETTopSheetProductExpenseForDepotWithChildDepot>>> GetDateWiseNationalZeroBalanceCashPart(int depotID, string dateFrom, string dateTo)
        {
            var zeroBalanceReportData = await _dbContext.ACCSPGETTopSheetProductExpenseForDepotWithChildDepots.FromSqlRaw($"ACCGETDateWiseNationalZeroBalanceReportExpenseParts @DateFrom='{dateFrom}', @DateTo='{dateTo}'").ToListAsync();
            return Ok(zeroBalanceReportData);
        }


        [HttpGet("GetNationalZeroBalanceExpense")]
        public async Task<ActionResult<List<ACCSPGETTopSheetProductExpenseForDepotWithChildDepot>>> GetNationalZeroBalanceReportExpense(string date)
        {
            var zeroBalanceReportData = await _dbContext.ACCSPGETTopSheetProductExpenseForDepotWithChildDepots.FromSqlRaw($"ACCGETDateWiseNationalZeroBalanceReportExpensePart @Date='{date}'").ToListAsync();
            return Ok(zeroBalanceReportData);
        }


        [HttpGet("GetNationalZeroBalanceStock")]
        public async Task<ActionResult<List<ACCSPGETTopSheetProductStockForDepotWithChildDepot>>> GetNationalZeroBalanceReportStock(string date)
        {
            var zeroBalanceReportData = await _dbContext.ACCSPGETTopSheetProductStockForDepotWithChildDepots.FromSqlRaw($"ACCGETDateWiseNationalZeroBalanceReportStockPart @Date='{date}'").ToListAsync();
            return Ok(zeroBalanceReportData);
        }


        [HttpGet("GetSoleDepotWithChildDepotZeroBalanceExpense")]
        public async Task<ActionResult<List<ACCSPGETTopSheetProductExpenseForDepotWithChildDepot>>> GetSoleDepotWithChildDepotZeroBalanceReportExpense(int depotID, string date)
        {

            var zeroBalanceReportData = await _dbContext.ACCSPGETTopSheetProductExpenseForDepotWithChildDepots.FromSqlRaw($"ACCSPGETTopSheetProductExpenseForDepotWithChildDepot @DepoParam= {depotID}, @DateFrom='{date}', @DateTo='{date}'").ToListAsync();
            return Ok(zeroBalanceReportData);
        }


        [HttpGet("GetDMSSPGetSDWCDZeroBalanceSalesReportByDepoAndDate")]
        public async Task<ActionResult<List<DMSSPGetSDWCDZeroBalanceSalesReportByDepoAndDate>>> GetDMSSPGetSDWCDZeroBalanceSalesReportByDepoAndDate(int depotID, string date)
        {

            var zeroBalanceReportData = await _dbContext.DMSSPGetSDWCDZeroBalanceSalesReportByDepoAndDates.FromSqlRaw($"DMSSPGetSDWCDZeroBalanceSalesReportByDepoAndDate @DepoID= {depotID}, @Date='{date}'").ToListAsync();
            return Ok(zeroBalanceReportData);
        }


        [HttpGet("CheckZeroBalanceReportSaveDataExist")]
        public bool CheckZeroBalanceReportSaveDataExist(int depotID, string date)
        {
            bool isExist = false;
            DateTime Date = Convert.ToDateTime(date);
            var totalRecordCound = _dbContext.DMSSDWCDZeroBalanceReportStockSides.Where(m => m.SoleDepotID == depotID && m.Date == Date).ToList().Count();
            if (totalRecordCound > 0)
            {
                isExist = true;
            }
            return isExist;
        }


        [HttpGet("CheckHOApprovalDataExist")]
        public bool CheckHOApprovalDataExist(int hoID, int depotID, string date)
        {
            bool isExist = false;
            DateTime Date = Convert.ToDateTime(date);
            var productIds = new List<int> { 1, 2, 3, 5, 7, 8, 17, 19 };
            var totalRecordCound = _dbContext.DMSSDWCDZeroBalanceReportStockSides.Where(m => m.SoleDepotID == depotID && m.Date == Date && m.TranType == 3 && m.ApprovedByHO == hoID && productIds.Contains(m.ProductID)).ToList().Count();
            if (totalRecordCound > 0)
            {
                isExist = true;
            }
            return isExist;
        }

        [HttpGet("CheckDOApprovalDataExist")]
        public bool CheckDOApprovalDataExist(int doID, int depotID, string date)
        {
            bool isExist = false;
            DateTime Date = Convert.ToDateTime(date);
            var productIds = new List<int> { 1, 2, 3, 5, 7, 8, 17, 19 };
            var totalRecordCound = _dbContext.DMSSDWCDZeroBalanceReportStockSides.Where(m => m.SoleDepotID == depotID && m.Date == Date && m.TranType == 3 && m.ApprovedByDO == doID && productIds.Contains(m.ProductID)).ToList().Count();
            if (totalRecordCound > 0)
            {
                isExist = true;
            }
            return isExist;
        }

        [HttpGet("CheckHOApprovalATCLDataExist")]
        public bool CheckHOApprovalATCLDataExist(int hoID, int depotID, string date)
        {
            bool isExist = false;
            DateTime Date = Convert.ToDateTime(date);
            var productIds = new List<int> { 14, 15, 16, 18, 20, 21 };
            var totalRecordCound = _dbContext.DMSSDWCDZeroBalanceReportStockSides.Where(m => m.SoleDepotID == depotID && m.Date == Date && m.TranType == 3 && m.ApprovedByHO == hoID && productIds.Contains(m.ProductID)).ToList().Count();
            if (totalRecordCound > 0)
            {
                isExist = true;
            }
            return isExist;
        }

        [HttpGet("CheckDOApprovalATCLDataExist")]
        public bool CheckDOApprovalATCLDataExist(int doID, int depotID, string date)
        {
            bool isExist = false;
            DateTime Date = Convert.ToDateTime(date);
            var productIds = new List<int> { 14, 15, 16, 18, 20, 21 };
            var totalRecordCound = _dbContext.DMSSDWCDZeroBalanceReportStockSides.Where(m => m.SoleDepotID == depotID && m.Date == Date && m.TranType == 3 && m.ApprovedByDO == doID && productIds.Contains(m.ProductID)).ToList().Count();
            if (totalRecordCound > 0)
            {
                isExist = true;
            }
            return isExist;
        }


        [HttpGet("GetZeroBalanceReportItem")]
        public async Task<ActionResult<List<AccZeroBalanceReportItem>>> GetZeroBalanceReportItem(short tranType, short subTranType, short reportType, string itemName)
        {
            var zeroBalanceReportData = await _dbContext.AccZeroBalanceReportItems.Where(m => m.TranType == tranType && m.SubTranType == subTranType && m.ReportType == reportType && m.ItemName.Contains(itemName)).ToListAsync();
            return Ok(zeroBalanceReportData);
        }

        [HttpPost]
        [Route("InsertSDWCDZeroBalanceReport")]
        public Response PostSDWCDZeroReport(ArrayList arrayList)
        {

            List<Models.DMSSDWCDZeroBalanceReportStockSide> objDMSSDWCDZeroBalanceReportStockSideList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Models.DMSSDWCDZeroBalanceReportStockSide>>(arrayList[0].ToString());
            List<Models.DMSSDWCDZeroBalanceReportExpenseSide> objDMSSDWCDZeroBalanceReportExpenseSideList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Models.DMSSDWCDZeroBalanceReportExpenseSide>>(arrayList[1].ToString());

            Response response = new Response();
            long maxID = _dbContext.DMSSDWCDZeroBalanceReportStockSides.Max(m => (long?)m.ID) ?? 0;

            long maxExpID = _dbContext.DMS_SDWCDZeroBalanceReportExpenseSides.Max(m => (long?)m.ID) ?? 0;

            if (objDMSSDWCDZeroBalanceReportStockSideList != null)
            {
                foreach (var objDMSSDWCDZeroBalanceReportStockSide in objDMSSDWCDZeroBalanceReportStockSideList)
                {
                    objDMSSDWCDZeroBalanceReportStockSide.ID = ++maxID;
                    objDMSSDWCDZeroBalanceReportStockSide.LastUpdate = DateTime.Now;
                    objDMSSDWCDZeroBalanceReportStockSide.Remarks = "";
                    _dbContext.DMSSDWCDZeroBalanceReportStockSides.Add(objDMSSDWCDZeroBalanceReportStockSide);
                }
            }

            if (objDMSSDWCDZeroBalanceReportExpenseSideList != null)
            {
                foreach (var objDMSSDWCDZeroBalanceReportExpenseSide in objDMSSDWCDZeroBalanceReportExpenseSideList)
                {
                    objDMSSDWCDZeroBalanceReportExpenseSide.ID = ++maxExpID;
                    objDMSSDWCDZeroBalanceReportExpenseSide.LastUpdate = DateTime.Now;
                    objDMSSDWCDZeroBalanceReportExpenseSide.Remarks = "";
                    objDMSSDWCDZeroBalanceReportExpenseSide.SubTranType = 0;
                    _dbContext.DMS_SDWCDZeroBalanceReportExpenseSides.Add(objDMSSDWCDZeroBalanceReportExpenseSide);
                }
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

        [HttpPost]
        [Route("UpdateSDWCDZeroBalanceSalesDOApproval")]
        public Response UpdateSDWCDZeroBalanceSalesDOApproval(ArrayList arrayList)
        {
            Response response = new Response();

            List<BO.SearchParameter> objSPList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<BO.SearchParameter>>(arrayList[0].ToString());

            BO.SearchParameter objSP = objSPList[0];

            var productIds = new List<int> { 1, 2, 3, 5, 7, 8, 17, 19 };

            var sdWCDSalesDataList = _dbContext.DMSSDWCDZeroBalanceReportStockSides.Where(m => m.Date == Convert.ToDateTime(objSP.Date) && m.SoleDepotID == objSP.DepoID && m.TranType == 3 && productIds.Contains(m.ProductID)).ToList();

            if (sdWCDSalesDataList != null)
            {
                foreach (var objDMSSDWCDZeroBalanceReportExpenseSide in sdWCDSalesDataList)
                {
                    objDMSSDWCDZeroBalanceReportExpenseSide.ApprovedByDO = objSP.DOID;
                    _dbContext.DMSSDWCDZeroBalanceReportStockSides.Update(objDMSSDWCDZeroBalanceReportExpenseSide);
                }
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


        [HttpPost]
        [Route("UpdateSDWCDZeroBalanceSalesHOApproval")]
        public Response UpdateSDWCDZeroBalanceSalesHOApproval(ArrayList arrayList)
        {
            Response response = new Response();

            List<BO.SearchParameter> objSPList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<BO.SearchParameter>>(arrayList[0].ToString());

            BO.SearchParameter objSP = objSPList[0];

            var productIds = new List<int> { 1, 2, 3, 5, 7, 8, 17, 19 };

            var sdWCDSalesDataList = _dbContext.DMSSDWCDZeroBalanceReportStockSides.Where(m => m.Date == Convert.ToDateTime(objSP.Date) && m.SoleDepotID == objSP.DepoID && m.TranType == 3 && productIds.Contains(m.ProductID)).ToList();

            if (sdWCDSalesDataList != null)
            {
                foreach (var objDMSSDWCDZeroBalanceReportExpenseSide in sdWCDSalesDataList)
                {
                    objDMSSDWCDZeroBalanceReportExpenseSide.ApprovedByHO = objSP.HOID;
                    _dbContext.DMSSDWCDZeroBalanceReportStockSides.Update(objDMSSDWCDZeroBalanceReportExpenseSide);
                }
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


        [HttpPost]
        [Route("UpdateSDWCDZeroBalanceATCLSalesDOApproval")]
        public Response UpdateSDWCDZeroBalanceATCLSalesDOApproval(ArrayList arrayList)
        {
            Response response = new Response();

            List<BO.SearchParameter> objSPList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<BO.SearchParameter>>(arrayList[0].ToString());

            BO.SearchParameter objSP = objSPList[0];
            var productIds = new List<int> { 14, 15, 16, 18, 20, 21 };

            var sdWCDSalesDataList = _dbContext.DMSSDWCDZeroBalanceReportStockSides.Where(m => m.Date == Convert.ToDateTime(objSP.Date) && m.SoleDepotID == objSP.DepoID && m.TranType == 3 && productIds.Contains(m.ProductID)).ToList();

            if (sdWCDSalesDataList != null)
            {
                foreach (var objDMSSDWCDZeroBalanceReportExpenseSide in sdWCDSalesDataList)
                {
                    objDMSSDWCDZeroBalanceReportExpenseSide.ApprovedByDO = objSP.DOID;
                    _dbContext.DMSSDWCDZeroBalanceReportStockSides.Update(objDMSSDWCDZeroBalanceReportExpenseSide);
                }
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


        [HttpPost]
        [Route("UpdateSDWCDZeroBalanceATCLSalesHOApproval")]
        public Response UpdateSDWCDZeroBalanceATCLSalesHOApproval(ArrayList arrayList)
        {
            Response response = new Response();

            List<BO.SearchParameter> objSPList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<BO.SearchParameter>>(arrayList[0].ToString());

            BO.SearchParameter objSP = objSPList[0];
            var productIds = new List<int> { 14, 15, 16, 18, 20, 21 };
            var sdWCDSalesDataList = _dbContext.DMSSDWCDZeroBalanceReportStockSides.Where(m => m.Date == Convert.ToDateTime(objSP.Date) && m.SoleDepotID == objSP.DepoID && m.TranType == 3 && productIds.Contains(m.ProductID)).ToList();

            if (sdWCDSalesDataList != null)
            {
                foreach (var objDMSSDWCDZeroBalanceReportExpenseSide in sdWCDSalesDataList)
                {
                    objDMSSDWCDZeroBalanceReportExpenseSide.ApprovedByHO = objSP.HOID;
                    _dbContext.DMSSDWCDZeroBalanceReportStockSides.Update(objDMSSDWCDZeroBalanceReportExpenseSide);
                }
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

        // PUT api/<DMSFactoryProductionBarcodeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DMSFactoryProductionBarcodeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
