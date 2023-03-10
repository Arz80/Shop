using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace Shop.Models
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        {

        }
        public DbSet<Products> Products { get; set;}
        public DbSet<Categorys> Categorys { get; set;}
        public DbSet<Brands> Brands { get; set;}
    }
}
