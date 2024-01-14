using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DotNetSecureProductAPI.Api.Models
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions prDbContextOptions) : base(prDbContextOptions)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}