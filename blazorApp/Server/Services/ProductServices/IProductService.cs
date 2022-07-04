namespace blazorApp.Server.Services.ProductServices
{
    public interface IProductService
    {
        Task<ServiceResponse<List<Product>>> GetProductsAsync();
        //it returns a task, with a service response which is a list of products

        Task<ServiceResponse<Product>> GetProductAsync(int productId);
    }
}
