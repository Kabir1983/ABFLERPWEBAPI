using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ABFLERPWEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SetVehicleTypeController : ControllerBase
    {
        private readonly AkijSCMSDBContext _dbContext;
        public SetVehicleTypeController(AkijSCMSDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("GetSetVehicleTypes")]
        public async Task<IActionResult> GetSetVehicleTypes()
        {
            return Ok(await _dbContext.SetVehicleTypes.ToListAsync());
        }

        [HttpGet("GetSetVehicleTypesByID")]
        public async Task<IActionResult> GetSetVehicleTypesByID(int SetVehicleTypeID, string SetVehicleTypeName)
        {
            var SetVehicleTypeData = _dbContext.SetVehicleTypes.FromSqlRaw($"GetSetVehicleTypeByID @SetVehicleTypeID={SetVehicleTypeID}, @SetVehicleTypeName='{SetVehicleTypeName}' ").ToListAsync();
            return Ok(await SetVehicleTypeData);
        }
    }
}
