using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ABFLERPWEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ACCAreaZeroBalanceReport : ControllerBase
    {

        private readonly AkijSCMSDBContext _dbContext;
        public ACCAreaZeroBalanceReport(AkijSCMSDBContext dbContext)
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


        [HttpGet("GetAreaZeroBalanceExpense")]
        public async Task<ActionResult<List<ACCGETDateWiseAreaZeroBalanceReportExpensePart>>> GetAreaZeroBalanceReportExpense(int areaID, string date)
        {
            var zeroBalanceReportData = await _dbContext.ACCSPGETAreaWiseZeroBlanceExpenseParts.FromSqlRaw($"ACCGETDateWiseAreaZeroBalanceReportExpensePart @AreaID='{areaID}', @Date='{date}'").ToListAsync();
            return Ok(zeroBalanceReportData);
        }


        [HttpGet("GetAreaZeroBalanceStock")]
        public async Task<ActionResult<List<ACCGETDateWiseAreaZeroBalanceReportStockPart>>> GetAreaZeroBalanceReportStock(int areaID, string date)
        {
            var zeroBalanceReportData = await _dbContext.ACCGETDateWiseAreaZeroBalanceReportStockParts.FromSqlRaw($"ACCGETDateWiseAreaZeroBalanceReportStockPart @AreaID='{areaID}', @Date='{date}'").ToListAsync();
            return Ok(zeroBalanceReportData);
        }


        //[HttpGet("GetSoleDepotWithChildDepotZeroBalanceExpense")]
        //public async Task<ActionResult<List<ACCSPGETTopSheetProductExpenseForDepotWithChildDepot>>> GetSoleDepotWithChildDepotZeroBalanceReportExpense(int depotID, string date)
        //{

        //    var zeroBalanceReportData = await _dbContext.ACCSPGETTopSheetProductExpenseForDepotWithChildDepots.FromSqlRaw($"ACCSPGETTopSheetProductExpenseForDepotWithChildDepot @DepoParam= {depotID}, @DateFrom='{date}', @DateTo='{date}'").ToListAsync();
        //    return Ok(zeroBalanceReportData);
        //}

        [HttpGet("CheckAreaZeroBalanceReportSaveDataExist")]
        public bool CheckZeroBalanceReportSaveDataExist(int areaID, string date)
        {
            bool isExist = false;
            DateTime Date = Convert.ToDateTime(date);
            var totalRecordCount = _dbContext.DMSADWZeroBalanceReportStockSides.Where(m => m.AreaID == areaID && m.Date == Date).ToList().Count();
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
        [Route("InsertADWZeroBalanceReport")]
        public Response PostADWZeroBalanceReport(ArrayList arrayList)
        {

            List<Models.DMSADWZeroBalanceReportStockSide> objDMSADWZeroBalanceReportStockSideList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Models.DMSADWZeroBalanceReportStockSide>>(arrayList[0].ToString());
            List<Models.DMSADWZeroBalanceReportExpenseSide> objDMSADWZeroBalanceReportExpenseSideList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Models.DMSADWZeroBalanceReportExpenseSide>>(arrayList[1].ToString());

            Response response = new Response();
            long maxID = _dbContext.DMSADWZeroBalanceReportStockSides.Max(m => (long?)m.ID) ?? 0;

            long maxExpID = _dbContext.DMS_ADWZeroBalanceReportExpenseSides.Max(m => (long?)m.ID) ?? 0;

            if (objDMSADWZeroBalanceReportStockSideList != null)
            {
                foreach (var objDMSADWZeroBalanceReportStockSide in objDMSADWZeroBalanceReportStockSideList)
                {
                    objDMSADWZeroBalanceReportStockSide.ID = ++maxID;
                    objDMSADWZeroBalanceReportStockSide.LastUpdate = DateTime.Now;
                    _dbContext.DMSADWZeroBalanceReportStockSides.Add(objDMSADWZeroBalanceReportStockSide);
                }
            }

            if (objDMSADWZeroBalanceReportExpenseSideList != null)
            {
                foreach (var objDMSADWZeroBalanceReportExpenseSide in objDMSADWZeroBalanceReportExpenseSideList)
                {
                    objDMSADWZeroBalanceReportExpenseSide.ID = ++maxExpID;
                    objDMSADWZeroBalanceReportExpenseSide.LastUpdate = DateTime.Now;
                    objDMSADWZeroBalanceReportExpenseSide.SubTranType = 0;
                    _dbContext.DMS_ADWZeroBalanceReportExpenseSides.Add(objDMSADWZeroBalanceReportExpenseSide);
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
        //public Response PostSDWCDZeroBalanceExpenseSide(List<Models.DMSADWZeroBalanceReportExpenseSide> objDMSADWZeroBalanceReportExpenseSideList)
        //{

        //    Response response = new Response();
        //    long maxID = _dbContext.DMS_SDWCDZeroBalanceReportExpenseSides.Max(m => (long?)m.ID) ?? 0;

        //    if (objDMSADWZeroBalanceReportExpenseSideList != null)
        //    {
        //        foreach (var objDMSADWZeroBalanceReportExpenseSide in objDMSADWZeroBalanceReportExpenseSideList)
        //        {
        //            objDMSADWZeroBalanceReportExpenseSide.ID = ++maxID;
        //            objDMSADWZeroBalanceReportExpenseSide.LastUpdate = DateTime.Now;
        //            objDMSADWZeroBalanceReportExpenseSide.Remarks = "";
        //            _dbContext.DMS_SDWCDZeroBalanceReportExpenseSides.Add(objDMSADWZeroBalanceReportExpenseSide);
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
