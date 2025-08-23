using ABFLERPWEBAPI.BO;
using Google.Api.Gax.ResourceNames;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using System.Drawing;

namespace ABFLERPWEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarketingSetupDataController : ControllerBase
    {
        private readonly AkijSCMSDBContext _dbContext;
        public MarketingSetupDataController(AkijSCMSDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("GetMarketingStructureData")]
        public async Task<IActionResult> GetMarketingStructureData(int DivisionID, int DepoID, int RegionID, int AreaID, int TerritoryID)
        {
            var productData = await _dbContext.AndroidAppsGetMarketingStructureDatas.FromSqlRaw($"AndroidAppsGetMarketingStructureData @DivisionID={DivisionID}, @DepoID={DepoID}, @RegionID={RegionID}, @AreaID={AreaID}, @TerritoryID={TerritoryID}").ToListAsync();
            return Ok(productData);
        }

        [HttpGet("GetMarketingStructureDataForSR")]
        public async Task<IActionResult> GetMarketingStructureDataForSR(int DivisionID, int DepoID, int RegionID, int AreaID, int TerritoryID, int RouteID)
        {
            var productData = await _dbContext.AndroidAppsGetMarketingStructureDataForSRs.FromSqlRaw($"AndroidAppsGetMarketingStructureDataForSR @DivisionID={DivisionID}, @DepoID={DepoID}, @RegionID={RegionID}, @AreaID={AreaID}, @TerritoryID={TerritoryID}, @RouteID={RouteID}").ToListAsync();
            return Ok(productData);
        }

        [HttpGet("GetDivision")]
        public async Task<IActionResult> GetDivision(string UserID)
        {
            BO.SetDivision objSetDivision = new BO.SetDivision();

            var user = await _dbContext.SetUsers.FirstOrDefaultAsync(m => m.UserId == UserID);
            if (user != null && user.EmployeeId.HasValue)
            {
                int employeeID = user.EmployeeId.Value;
                var hrmPIEmployeement = await _dbContext.HrmPiemployements.FirstOrDefaultAsync(m => m.Piid == employeeID);
                if (hrmPIEmployeement != null)
                {
                    var setDivision = await _dbContext.SetDivisions.FirstOrDefaultAsync(m => m.DivisionId == hrmPIEmployeement.DivisionId);
                    if (setDivision != null)
                    {
                        objSetDivision.DivisionId = setDivision.DivisionId;
                        objSetDivision.Name = setDivision.Name;
                        objSetDivision.Description = setDivision.Description;
                        objSetDivision.LastUpdate = setDivision.LastUpdate;
                    }
                }
            }

            return Ok(objSetDivision);
        }

        [HttpGet("GetDepoList")]
        public async Task<IActionResult> GetDepoList(string UserID)
        {
            BO.SetDepo objSetDepo = new BO.SetDepo();
            List<BO.SetDepo> objSetDepoList = new List<BO.SetDepo>();

            var user = await _dbContext.SetUsers.FirstOrDefaultAsync(m => m.UserId == UserID);
            if (user != null && user.EmployeeId.HasValue)
            {
                int employeeID = user.EmployeeId.Value;
                var hrmPIEmployeement = await _dbContext.HrmPiemployements.FirstOrDefaultAsync(m => m.Piid == employeeID);
                if (hrmPIEmployeement != null && hrmPIEmployeement.DesignationId == 63)
                {
                    var regionByWing = _dbContext.SetDivisionWiseRegions.Where(m => m.DivisionId == hrmPIEmployeement.DivisionId).ToList();
                    foreach (var objRBW in regionByWing)
                    {
                        var setRegion = await _dbContext.SetRegions.FirstOrDefaultAsync(m => m.RegionId == objRBW.RegionId);
                        if (setRegion != null)
                        {
                            var setDepo = await _dbContext.SetDepos.FirstOrDefaultAsync(m => m.DepoId == setRegion.DepoId);
                            if (setDepo != null)
                            {
                                objSetDepo = new BO.SetDepo();
                                objSetDepo.DepoId = setDepo.DepoId;
                                objSetDepo.Name = setDepo.Name;
                                objSetDepo.Sln = setDepo.Sln;
                                objSetDepo.Code = setDepo.Code;
                                objSetDepo.Address = setDepo.Address;
                                objSetDepo.IsActive = setDepo.IsActive;
                                objSetDepo.LastUpdate = setDepo.LastUpdate;
                                objSetDepoList.Add(objSetDepo);
                            }
                        }
                    }
                }
                else
                {
                    var setDepo = await _dbContext.SetDepos.FirstOrDefaultAsync(m => m.DepoId == hrmPIEmployeement.DepoId);
                    if (setDepo != null)
                    {
                        objSetDepo = new BO.SetDepo();
                        objSetDepo.DepoId = setDepo.DepoId;
                        objSetDepo.Name = setDepo.Name;
                        objSetDepo.Sln = setDepo.Sln;
                        objSetDepo.Code = setDepo.Code;
                        objSetDepo.Address = setDepo.Address;
                        objSetDepo.IsActive = setDepo.IsActive;
                        objSetDepo.LastUpdate = setDepo.LastUpdate;
                        objSetDepoList.Add(objSetDepo);
                    }
                }
            }
            if (objSetDepoList.Count > 0)
            {
                objSetDepoList = objSetDepoList.DistinctBy(x => x.DepoId).ToList();
            }
            return Ok(objSetDepoList);
        }

        [HttpGet("GetRegionList")]
        public async Task<IActionResult> GetRegionList(string UserID)
        {
            BO.SetRegion objSetRegion = new BO.SetRegion();
            List<BO.SetRegion> objSetRegionList = new List<BO.SetRegion>();

            var user = await _dbContext.SetUsers.FirstOrDefaultAsync(m => m.UserId == UserID);
            if (user != null && user.EmployeeId.HasValue)
            {
                int employeeID = user.EmployeeId.Value;
                var hrmPIEmployeement = await _dbContext.HrmPiemployements.FirstOrDefaultAsync(m => m.Piid == employeeID);
                if (hrmPIEmployeement != null && hrmPIEmployeement.DesignationId == 63)
                {
                    var regionByWing = _dbContext.SetDivisionWiseRegions.Where(m => m.DivisionId == hrmPIEmployeement.DivisionId).ToList();
                    foreach (var objRBW in regionByWing)
                    {
                        var setRegion = await _dbContext.SetRegions.FirstOrDefaultAsync(m => m.RegionId == objRBW.RegionId);
                        if (setRegion != null)
                        {

                            objSetRegion = new BO.SetRegion();
                            objSetRegion.RegionId = setRegion.RegionId;
                            objSetRegion.Name = setRegion.Name;
                            objSetRegion.Sln = setRegion.Sln;
                            objSetRegion.Code = setRegion.Code;
                            objSetRegion.Description = setRegion.Description;
                            objSetRegion.IsActive = setRegion.IsActive;
                            objSetRegion.LastUpdate = setRegion.LastUpdate;
                            objSetRegion.DepoId = setRegion.DepoId;
                            objSetRegion.DivisionId = hrmPIEmployeement.DivisionId;
                            objSetRegionList.Add(objSetRegion);
                        }
                    }
                }
                else
                {
                    var setRegion = await _dbContext.SetRegions.FirstOrDefaultAsync(m => m.RegionId == hrmPIEmployeement.RegionId);
                    if (setRegion != null)
                    {
                        objSetRegion = new BO.SetRegion();
                        objSetRegion.RegionId = setRegion.RegionId;
                        objSetRegion.Name = setRegion.Name;
                        objSetRegion.Sln = setRegion.Sln;
                        objSetRegion.Code = setRegion.Code;
                        objSetRegion.Description = setRegion.Description;
                        objSetRegion.IsActive = setRegion.IsActive;
                        objSetRegion.LastUpdate = setRegion.LastUpdate;
                        objSetRegion.DepoId = setRegion.DepoId;
                        objSetRegion.DivisionId = hrmPIEmployeement.DivisionId;
                        objSetRegionList.Add(objSetRegion);
                    }
                }
            }
            if (objSetRegionList.Count > 0)
            {
                objSetRegionList = objSetRegionList.DistinctBy(x => x.RegionId).ToList();
            }
            return Ok(objSetRegionList);
        }

        [HttpGet("GetAreaList")]
        public async Task<IActionResult> GetAreaList(string UserID)
        {
            BO.SetArea objSetArea = new BO.SetArea();
            List<BO.SetArea> objSetAreaList = new List<BO.SetArea>();

            var user = await _dbContext.SetUsers.FirstOrDefaultAsync(m => m.UserId == UserID);
            if (user != null && user.EmployeeId.HasValue)
            {
                int employeeID = user.EmployeeId.Value;
                var hrmPIEmployeement = await _dbContext.HrmPiemployements.FirstOrDefaultAsync(m => m.Piid == employeeID);
                if (hrmPIEmployeement != null && hrmPIEmployeement.DesignationId == 63)
                {
                    var regionByWing = await _dbContext.SetDivisionWiseRegions.Where(m => m.DivisionId == hrmPIEmployeement.DivisionId).ToListAsync();
                    foreach (var objRBW in regionByWing)
                    {
                        var setAreaList = await _dbContext.SetAreas.Where(m => m.RegionId == objRBW.RegionId).ToListAsync();
                        if (setAreaList != null)
                        {
                            foreach (var setArea in setAreaList)
                            {
                                objSetArea = new BO.SetArea();
                                objSetArea.AreaId = setArea.AreaId;
                                objSetArea.AreaName = setArea.AreaName;
                                objSetArea.AreaCode = setArea.AreaCode;
                                objSetArea.IsActive = setArea.IsActive;
                                objSetArea.LastUpdate = setArea.LastUpdate;
                                objSetArea.AreaAddress = setArea.AreaAddress;
                                objSetArea.AreaTypeId = setArea.AreaTypeId;
                                objSetArea.RegionId = setArea.RegionId;
                                objSetAreaList.Add(objSetArea);
                            }
                        }
                    }
                }
                else if (hrmPIEmployeement != null && hrmPIEmployeement.DesignationId == 10)
                {
                    var setRegion = await _dbContext.SetRegions.FirstOrDefaultAsync(m => m.RegionId == hrmPIEmployeement.RegionId);

                    var setAreaList = await _dbContext.SetAreas.Where(m => m.RegionId == setRegion.RegionId).ToListAsync();
                    if (setAreaList != null)
                    {
                        foreach (var setArea in setAreaList)
                        {
                            objSetArea = new BO.SetArea();
                            objSetArea.AreaId = setArea.AreaId;
                            objSetArea.AreaName = setArea.AreaName;
                            objSetArea.AreaCode = setArea.AreaCode;
                            objSetArea.IsActive = setArea.IsActive;
                            objSetArea.LastUpdate = setArea.LastUpdate;
                            objSetArea.AreaAddress = setArea.AreaAddress;
                            objSetArea.AreaTypeId = setArea.AreaTypeId;
                            objSetArea.RegionId = setArea.RegionId;
                            objSetAreaList.Add(objSetArea);
                        }
                    }
                }
                else
                {
                    var setArea = await _dbContext.SetAreas.FirstOrDefaultAsync(m => m.AreaId == hrmPIEmployeement.AreaId);
                    if (setArea != null)
                    {
                        objSetArea = new BO.SetArea();
                        objSetArea.AreaId = setArea.AreaId;
                        objSetArea.AreaName = setArea.AreaName;
                        objSetArea.AreaCode = setArea.AreaCode;
                        objSetArea.IsActive = setArea.IsActive;
                        objSetArea.LastUpdate = setArea.LastUpdate;
                        objSetArea.AreaAddress = setArea.AreaAddress;
                        objSetArea.AreaTypeId = setArea.AreaTypeId;
                        objSetArea.RegionId = setArea.RegionId;
                        objSetAreaList.Add(objSetArea);
                    }
                }
            }
            if (objSetAreaList.Count > 0)
            {
                objSetAreaList = objSetAreaList.DistinctBy(x => x.AreaId).ToList();
            }
            return Ok(objSetAreaList);
        }

        [HttpGet("GetTerritoryList")]
        public async Task<IActionResult> GetTerritoryList(string UserID)
        {
            BO.SetTerritory objSetTerritory = new BO.SetTerritory();
            List<BO.SetTerritory> objSetTerritoryList = new List<BO.SetTerritory>();

            var user = await _dbContext.SetUsers.FirstOrDefaultAsync(m => m.UserId == UserID);
            if (user != null && user.EmployeeId.HasValue)
            {
                int employeeID = user.EmployeeId.Value;
                var hrmPIEmployeement = await _dbContext.HrmPiemployements.FirstOrDefaultAsync(m => m.Piid == employeeID && m.IsActive == true);
                var SetTerritory = await _dbContext.SetTerritories.FirstOrDefaultAsync(m => m.TerritoryId == hrmPIEmployeement.TerritoryId);
                if (SetTerritory != null)
                {
                    objSetTerritory = new BO.SetTerritory();
                    objSetTerritory.AreaId = SetTerritory.AreaId;
                    objSetTerritory.TerritoryId = SetTerritory.TerritoryId;
                    objSetTerritory.TerritoryTypeId = SetTerritory.TerritoryTypeId;
                    objSetTerritory.IsActive = SetTerritory.IsActive;
                    objSetTerritory.LastUpdate = SetTerritory.LastUpdate;
                    objSetTerritory.TerritoryCode = SetTerritory.TerritoryCode;
                    objSetTerritory.Name = SetTerritory.Name;
                    objSetTerritory.Address = SetTerritory.Address;
                    objSetTerritoryList.Add(objSetTerritory);
                }
            }
            if (objSetTerritoryList.Count > 0)
            {
                objSetTerritoryList = objSetTerritoryList.DistinctBy(x => x.TerritoryId).ToList();
            }
            return Ok(objSetTerritoryList);
        }

        [HttpGet("GetSRWiseRoute")]
        public async Task<IActionResult> GetSRWiseRouteInfo(string userId)
        {
            if (string.IsNullOrWhiteSpace(userId))
            {
                return BadRequest("User ID is required.");
            }

            var objUser = await _dbContext.SetUsers.FirstOrDefaultAsync(m => m.UserId == userId);
            if (objUser == null)
            {
                return NotFound("User not found.");
            }

            var hrmPIEmployement = await _dbContext.HrmPiemployements
                .FirstOrDefaultAsync(m => m.Piid == objUser.EmployeeId && m.IsActive == true);

            if (hrmPIEmployement == null)
            {
                return NotFound("Active employment not found for this user.");
            }

            var productData = await _dbContext.AndroidSPGetSRWiseRoutes
                .FromSqlRaw($"EXEC AndroidSPGetSRWiseRoute @SRID={hrmPIEmployement.Id}")
                .ToListAsync();

            return Ok(productData);
        }
    }
}
