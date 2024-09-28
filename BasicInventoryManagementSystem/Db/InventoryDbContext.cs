using Microsoft.EntityFrameworkCore;

using BasicInventoryManagementSystem.Models;
using BasicInventoryManagementSystem.Mapper.LoginMapper;

namespace BasicInventoryManagementSystem.Db
{
    public class InventoryDbContext:DbContext
    {
        public InventoryDbContext(DbContextOptions<InventoryDbContext> options):base(options)
        {
            
        }

        public DbSet<Registration> Registrations { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCatagory> ProductCatagories { get; set; }




    }
}
