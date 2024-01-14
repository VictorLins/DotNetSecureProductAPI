using DotNetSecureProductAPI.Api.Models;

namespace DotNetSecureProductAPI.Api.Interfaces
{
    public interface IProductRepository
    {
        ICollection<Product> GetAll();
        Product GetById(int prId);
        ICollection<Product> GetByColour(string prColour);
    }
}