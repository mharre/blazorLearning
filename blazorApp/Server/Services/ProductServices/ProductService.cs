namespace blazorApp.Server.Services.ProductServices
{
    public class ProductService : IProductService
    {
        private readonly DataContext context;

        public ProductService(DataContext context)
        {
            this.context = context;
        }

		public async Task<ServiceResponse<Product>> GetProductAsync(int productId)
		{
            var response = new ServiceResponse<Product>();
            var product = await this.context.Products.FindAsync(productId);
            if (product == null)
			{
                response.success = false;
                response.message = "Product doesn't exist";
			} else
			{
                response.data = product;
			}

            return response;
		}

		public async Task<ServiceResponse<List<Product>>> GetProductsAsync()
        {
            var response = new ServiceResponse<List<Product>>
            {
                data = await this.context.Products.ToListAsync()
            };

            return response;
        }
    }
}
