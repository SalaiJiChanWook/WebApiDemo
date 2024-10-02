
using Microsoft.EntityFrameworkCore;
using WebApiDemo.Api.Domain.Entities;

namespace WebApiDemo.Api.Data
{
    public class DemoDbContext : DbContext
    {
        public DemoDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Product> Products { get; set; }

    }
}
