using DotNetSecureProductAPI.Api.Interfaces;
using DotNetSecureProductAPI.Api.Models;

namespace DotNetSecureProductAPI.Api.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext prApplicationDbContext)
        {
            _context = prApplicationDbContext;
        }

        public ICollection<Product> GetAll()
        {
            return _context.Products.ToList();
        }
        Product IProductRepository.GetById(int prId)
        {
            return _context.Products.Where(x => x.ProductId == prId).FirstOrDefault();
        }

        public ICollection<Product> GetByColour(string prColour)
        {
            return _context.Products.Where(x => x.Colour.ToUpper() == prColour.ToUpper()).ToList();
        }

    }
}