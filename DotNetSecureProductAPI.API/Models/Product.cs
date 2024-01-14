using Microsoft.EntityFrameworkCore;

namespace DotNetSecureProductAPI.Api.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Colour { get; set; }
        [Precision(18, 2)]
        public decimal Price { get; set; }
    }
}