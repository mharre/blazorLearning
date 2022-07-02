using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace blazorApp.Server.Controllers
{
    [Route("api/[controller]")]
    //brackets indicate name of the controller before
    //the word controller in our class - Product
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }

        [HttpGet]
		public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProducts()
        {
            var result = await this.productService.GetProductsAsync();
			return Ok(result);
        }
    }
}
