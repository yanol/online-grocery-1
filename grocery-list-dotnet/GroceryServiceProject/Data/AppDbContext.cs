using Microsoft.EntityFrameworkCore;
using GroceryServiceProject.Models;

namespace MyConsoleApp.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<ProductCategory> CategorySet { get; set; }

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
