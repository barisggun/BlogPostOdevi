using EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Connection string oluşturmak için bu yapıya ihtiyaç vardır.
            optionsBuilder.UseSqlServer("server=LAPTOP-TKFJC4RO\\SQLEXPRESS;database=BlogPostOdevDB;integrated security=true; TrustServerCertificate = true ");
        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
