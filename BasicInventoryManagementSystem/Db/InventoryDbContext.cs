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
<<<<<<< HEAD
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCatagory> ProductCatagories { get; set; }
=======
>>>>>>> cd722e539699a2e9421cad6fa6332a486ddb8477



    }
}
