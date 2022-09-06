using Microsoft.AspNetCore.Mvc;
using SellerSolution.ApplicationService.Interfaces;
using SellerSolution.ApplicationService.Responses.Product;

namespace SellerSolution.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IConsumerService _consumerService;

        public ProductController(IConsumerService consumerService)
        {
            _consumerService = consumerService;
        }

        [HttpGet("get_product")]
        public async Task<ProductResponse> GetProductAsync() => 
            await _consumerService.GetProductAsync();
            
    }
}
