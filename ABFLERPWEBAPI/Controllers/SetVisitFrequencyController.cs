using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ABFLERPWEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SetVisitFrequencyController : ControllerBase
    {
        private readonly AkijSCMSDBContext _dbContext;
        public SetVisitFrequencyController(AkijSCMSDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("GetSetVisitFrequencys")]
        public async Task<IActionResult> GetSetVisitFrequencys()
        {
            return Ok(await _dbContext.SetVisitFrequencys.ToListAsync());
        }

        [HttpGet("GetSetVisitFrequencysByID")]
        public async Task<IActionResult> GetSetVisitFrequencysByID(int SetVisitFrequencyID, string SetVisitFrequencyName)
        {
            var SetVisitFrequencyData = _dbContext.SetVisitFrequencys.FromSqlRaw($"GetSetVisitFrequencyByID @SetVisitFrequencyID={SetVisitFrequencyID}, @SetVisitFrequencyName='{SetVisitFrequencyName}' ").ToListAsync();
            return Ok(await SetVisitFrequencyData);
        }
    }
}
