using Microsoft.EntityFrameworkCore;

namespace CQRS.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=GEOPC\\SQLEXPRESS;Initial Catalog=DesignPatternDb;Integrated Security=True");
        }
        public DbSet<Product> Products { get; set; }
    }
}
