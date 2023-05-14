using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ChainOfResponsibility.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=GEOPC\\SQLEXPRESS;Initial Catalog=DesignPatternDb;Integrated Security=True");
        }
        public DbSet<Process> Processes { get; set; }
    }
}
