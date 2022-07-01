namespace blazorApp.Shared
{
    public class Products
    {
        public int id { get; set; }
        public string title { get; set; } = string.Empty;
        public string description { get; set; } = string.Empty;
        public string imageUrl { get; set; } = string.Empty;
        public decimal price { get; set; }
    }
}
