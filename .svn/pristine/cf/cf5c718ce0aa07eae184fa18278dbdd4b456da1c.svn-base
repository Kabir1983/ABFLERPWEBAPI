using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ABFLERPWEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SetOutletVisitParameterController : ControllerBase
    {
        private readonly AkijSCMSDBContext _dbContext;
        public SetOutletVisitParameterController(AkijSCMSDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("GetSetOutletVisitParameters")]
        public async Task<IActionResult> GetSetOutletVisitParameters()
        {
            return Ok(await _dbContext.SetOutletVisitParameters.ToListAsync());
        }

        [HttpGet("GetSetOutletVisitParametersByID")]
        public async Task<IActionResult> GetSetOutletVisitParametersByID(int SetOutletVisitParameterID, string SetOutletVisitParameterName)
        {
            var SetOutletVisitParameterData = _dbContext.SetOutletVisitParameters.FromSqlRaw($"GetSetOutletVisitParameterByID @SetOutletVisitParameterID={SetOutletVisitParameterID}, @SetOutletVisitParameterName='{SetOutletVisitParameterName}' ").ToListAsync();
            return Ok(await SetOutletVisitParameterData);
        }
    }
}
