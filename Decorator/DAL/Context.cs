using Microsoft.EntityFrameworkCore;

namespace Decorator.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=GEOPC\\SQLEXPRESS;Initial Catalog=DecoratorDb;Integrated Security=True");
        }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Notifier> Notifiers{ get; set; }
    }
}
