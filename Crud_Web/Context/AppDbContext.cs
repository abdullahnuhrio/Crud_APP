using Crud_Web.Models;
using Microsoft.EntityFrameworkCore;

namespace Crud_Web.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; } 
    }
}
