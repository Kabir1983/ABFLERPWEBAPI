using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ABFLERPWEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ACCSDZeroBalanceReport : ControllerBase
    {

        private readonly AkijSCMSDBContext _dbContext;
        public ACCSDZeroBalanceReport(AkijSCMSDBContext dbContext)
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

        //[HttpGet("GetSoleDepotWithChildDepotZeroBalance")]
        //public async Task<ActionResult<List<ACCSPGETTopSheetProductStockForDepotWithChildDepot>>> GetSoleDepotWithChildDepotZeroBalanceReport(int depotID, string date)
        //{
        //    var zeroBalanceReportData = await _dbContext.ACCSPGETTopSheetProductStockForDepotWithChildDepots.FromSqlRaw($"ACCSPGETTopSheetProductStockForDepotWithChildDepot @DepoID= {depotID}, @DateFrom='{date}', @DateTo='{date}'").ToListAsync();
        //    return Ok(zeroBalanceReportData);
        //}


        [HttpGet("GetSDZeroBalanceExpense")]
        public async Task<ActionResult<List<ACCGETDateWiseOnlySoleDepotZeroBalanceReportExpensePart>>> GetSDZeroBalanceReportExpense(int soleDepotID, string date)
        {
            var zeroBalanceReportData = await _dbContext.ACCSPGETOnlySoleDepotWiseZeroBlanceExpenseParts.FromSqlRaw($"ACCGETDateWiseOnlySoleDepotZeroBalanceReportExpensePart @SoleDepotID='{soleDepotID}', @Date='{date}'").ToListAsync();
            return Ok(zeroBalanceReportData);
        }


        [HttpGet("GetSDZeroBalanceStock")]
        public async Task<ActionResult<List<ACCGETDateWiseOnlySoleDepotZeroBalanceReportStockPart>>> GetSDZeroBalanceReportStock(int soleDepotID, string date)
        {
            var zeroBalanceReportData = await _dbContext.ACCGETDateWiseOnlySoleDepotZeroBalanceReportStockParts.FromSqlRaw($"ACCGETDateWiseOnlySoleDepotZeroBalanceReportStockPart @SoleDepotID='{soleDepotID}', @Date='{date}'").ToListAsync();
            return Ok(zeroBalanceReportData);
        }


        //[HttpGet("GetSoleDepotWithChildDepotZeroBalanceExpense")]
        //public async Task<ActionResult<List<ACCSPGETTopSheetProductExpenseForDepotWithChildDepot>>> GetSoleDepotWithChildDepotZeroBalanceReportExpense(int depotID, string date)
        //{

        //    var zeroBalanceReportData = await _dbContext.ACCSPGETTopSheetProductExpenseForDepotWithChildDepots.FromSqlRaw($"ACCSPGETTopSheetProductExpenseForDepotWithChildDepot @DepoParam= {depotID}, @DateFrom='{date}', @DateTo='{date}'").ToListAsync();
        //    return Ok(zeroBalanceReportData);
        //}

        [HttpGet("CheckSDZeroBalanceReportSaveDataExist")]
        public bool CheckZeroBalanceReportSaveDataExist(int depotID, string date)
        {
            bool isExist = false;
            DateTime Date = Convert.ToDateTime(date);
            var totalRecordCount = _dbContext.DMSSDWZeroBalanceReportStockSides.Where(m => m.SoleDepotID == depotID && m.Date == Date).ToList().Count();
            if (totalRecordCount > 0)
            {
                isExist = true;
            }
            return isExist;
        }


        //[HttpGet("GetZeroBalanceReportItem")]
        //public async Task<ActionResult<List<AccZeroBalanceReportItem>>> GetZeroBalanceReportItem(short tranType, short subTranType, short reportType, string itemName)
        //{
        //    var zeroBalanceReportData = await _dbContext.AccZeroBalanceReportItems.Where(m => m.TranType == tranType && m.SubTranType == subTranType && m.ReportType == reportType && m.ItemName.Contains(itemName)).ToListAsync();
        //    return Ok(zeroBalanceReportData);
        //}

        [HttpPost]
        [Route("InsertSDWZeroBalanceReport")]
        public Response PostSDWZeroBalanceReport(ArrayList arrayList)
        {

            List<Models.DMSSDWZeroBalanceReportStockSide> objDMSSDWZeroBalanceReportStockSideList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Models.DMSSDWZeroBalanceReportStockSide>>(arrayList[0].ToString());
            List<Models.DMSSDWZeroBalanceReportExpenseSide> objDMSSDWZeroBalanceReportExpenseSideList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Models.DMSSDWZeroBalanceReportExpenseSide>>(arrayList[1].ToString());

            Response response = new Response();
            long maxID = _dbContext.DMSSDWZeroBalanceReportStockSides.Max(m => (long?)m.ID) ?? 0;

            long maxExpID = _dbContext.DMSSDWZeroBalanceReportExpenseSides.Max(m => (long?)m.ID) ?? 0;

            if (objDMSSDWZeroBalanceReportStockSideList != null)
            {
                foreach (var objDMSSDWZeroBalanceReportStockSide in objDMSSDWZeroBalanceReportStockSideList)
                {
                    objDMSSDWZeroBalanceReportStockSide.ID = ++maxID;
                    objDMSSDWZeroBalanceReportStockSide.LastUpdate = DateTime.Now;
                    _dbContext.DMSSDWZeroBalanceReportStockSides.Add(objDMSSDWZeroBalanceReportStockSide);
                }
            }

            if (objDMSSDWZeroBalanceReportExpenseSideList != null)
            {
                foreach (var objDMSSDWZeroBalanceReportExpenseSide in objDMSSDWZeroBalanceReportExpenseSideList)
                {
                    objDMSSDWZeroBalanceReportExpenseSide.ID = ++maxExpID;
                    objDMSSDWZeroBalanceReportExpenseSide.LastUpdate = DateTime.Now;
                    objDMSSDWZeroBalanceReportExpenseSide.SubTranType = 0;
                    _dbContext.DMSSDWZeroBalanceReportExpenseSides.Add(objDMSSDWZeroBalanceReportExpenseSide);
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

        //[HttpPost]
        //[Route("InsertSDWCDZeroBalanceExpenseSide")]
        //public Response PostSDWCDZeroBalanceExpenseSide(List<Models.DMSSDWZeroBalanceReportExpenseSide> objDMSSDWZeroBalanceReportExpenseSideList)
        //{

        //    Response response = new Response();
        //    long maxID = _dbContext.DMS_SDWCDZeroBalanceReportExpenseSides.Max(m => (long?)m.ID) ?? 0;

        //    if (objDMSSDWZeroBalanceReportExpenseSideList != null)
        //    {
        //        foreach (var objDMSSDWZeroBalanceReportExpenseSide in objDMSSDWZeroBalanceReportExpenseSideList)
        //        {
        //            objDMSSDWZeroBalanceReportExpenseSide.ID = ++maxID;
        //            objDMSSDWZeroBalanceReportExpenseSide.LastUpdate = DateTime.Now;
        //            objDMSSDWZeroBalanceReportExpenseSide.Remarks = "";
        //            _dbContext.DMS_SDWCDZeroBalanceReportExpenseSides.Add(objDMSSDWZeroBalanceReportExpenseSide);
        //        }
        //    }
        //    if (_dbContext.SaveChanges() > 0)
        //    {
        //        response.StatusCode = 200;
        //        response.StatusMessage = "Save Success";
        //    }
        //    else
        //    {
        //        response.StatusCode = 100;
        //        response.StatusMessage = "Failed";
        //    }
        //    return response;
        //}

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
