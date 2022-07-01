using System.ComponentModel.DataAnnotations.Schema;

namespace blazorApp.Shared
{
    public class Product
    {
        public int id { get; set; }
        public string title { get; set; } = string.Empty;
        public string description { get; set; } = string.Empty;
        public string imageUrl { get; set; } = string.Empty;
        [Column(TypeName = "decimal(18,2)")]
        public decimal price { get; set; }
    }
}
