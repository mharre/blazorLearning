namespace blazorApp.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly HttpClient http;

        //need to define not only methods but the product list itself
        // because we store the products in the service and the product list components / other components access them from this service 
        // better to do it this way so we don't need to make calls in other components
        public ProductService(HttpClient http)
        {
            this.http = http;
        }
        public List<Product> Products { get; set; } = new List<Product>();

		public async Task<ServiceResponse<Product>> GetProduct(int productId)
		{
            var result = await
                this.http.GetFromJsonAsync<ServiceResponse<Product>>($"api/product/{productId}");
            return result;
            /* why return service response here?
             * we will use this method in our productdetails instead of the find method
             * so we can check for success flag etc
             */
		}

		public async Task GetProducts()
        {
            var result = await
                this.http.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/product");
		    if(result != null && result.data != null)
		    {
		    	Products = result.data;
		    }
        }
    }

}
