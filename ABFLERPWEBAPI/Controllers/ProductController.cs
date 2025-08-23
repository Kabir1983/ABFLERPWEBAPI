using Google.Api.Gax.ResourceNames;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
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

        [HttpGet("GetProductsInfo")]
        public async Task<IActionResult> GetProductsInfo()
        {
            var productData = _dbContext.AndroidAppsGetProductInos.FromSqlRaw($"AndroidAppsGetProductIno").ToListAsync();
            return Ok(await productData);
        }

        [HttpGet("GetProductPromotionInfo")]
        public async Task<IActionResult> GetProductPromotionInfo(int EmployementID, int RouteID, string Date)
        {
            var productPromotionData = _dbContext.AndroidSPGetProductPromotionByEmployementIDs.FromSqlRaw($"AndroidSPGetProductPromotionByEmployementID @EmployementID={EmployementID}, @RouteID={RouteID}, @Date='{Date}'").ToListAsync();
            return Ok(await productPromotionData);
        }

        [HttpGet("GetFreeSamplePolicyInfo")]
        public async Task<IActionResult> GetFreeSamplePolicyInfo(int EmployementID, int RouteID, string Date)
        {
            var productPromotionData = _dbContext.AndroidSPGetFreeSamplePromotionByEmployementIDs.FromSqlRaw($"AndroidSPGetFreeSamplePromotionByEmployementID @EmployementID={EmployementID}, @RouteID={RouteID}, @Date='{Date}'").ToListAsync();
            return Ok(await productPromotionData);
        }
    }
}
