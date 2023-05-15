using Microsoft.EntityFrameworkCore;

namespace Facade.DAL
{
    public class Context : DbContext
    {
        public Context(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers{ get; set; }
    }
}
