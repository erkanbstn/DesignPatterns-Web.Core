using Microsoft.EntityFrameworkCore;

namespace Mediator.DAL
{
    public class Context : DbContext
    {
        public Context(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
            
        }
        public DbSet<Product> Products { get; set; }
    }
}
