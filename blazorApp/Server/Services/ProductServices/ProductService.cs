namespace blazorApp.Server.Services.ProductServices
{
    public class ProductService : IProductService
    {
        private readonly DataContext context;

        public ProductService(DataContext context)
        {
            this.context = context;
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
