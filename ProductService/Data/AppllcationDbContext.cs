using Microsoft.EntityFrameworkCore;
using ProductService.Model;

namespace ProductService.Data
{
    public class AppllcationDbContext : DbContext
    {
        public AppllcationDbContext(DbContextOptions
            <AppllcationDbContext> options) : base(options)
        {

        }
        
        public DbSet<Product> Products { get; set; }
    }
}
