using Microsoft.EntityFrameworkCore;
using PizzaShop_Api.Model;

namespace PizzaShop_Api.Data
{
    public class PizzaShop_DBContext : DbContext
    {
        public PizzaShop_DBContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Cart> Cart { get; set; }
        public DbSet<login> Login { get; set; }

    }
}
