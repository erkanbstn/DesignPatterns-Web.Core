using Microsoft.EntityFrameworkCore;
using Repository.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> options) :base(options)
        {
            
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
