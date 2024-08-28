using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ABFLERPWEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly AkijSCMSDBContext _dbContext;
        public ProductController(AkijSCMSDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            return Ok(await _dbContext.SetProducts.ToListAsync());
        }


        [HttpGet("GetProductsByID")]
        public async Task<IActionResult> GetProductsByID(int productID, string productName)
        {
            var productData = _dbContext.SetProducts.FromSqlRaw($"GetProductByID @ProductID={productID}, @productName='{productName}' ").ToListAsync();
            return Ok(await productData);
        }
    }
}
