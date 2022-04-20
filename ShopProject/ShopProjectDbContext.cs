using Microsoft.EntityFrameworkCore;
using ShopProject.Models;

namespace ShopProject
{
    public class ShopProjectDbContext:DbContext
    {
        public ShopProjectDbContext(DbContextOptions options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
