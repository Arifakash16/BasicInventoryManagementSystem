Here is the step-by-step guide for setting up a new ASP.NET Core project with Entity Framework Core and SQL Server:

Step 1: Open a New Project
Open Visual Studio.
Go to File > New > Project.
Select ASP.NET Core Web Application.
Choose a suitable name and location for your project, then click Create.
Select the project template (e.g., Web Application), and click Create.

Step 2: Install Required Packages
You need to install the following NuGet packages for SQL Server and Entity Framework Core:
Open the Package Manager Console (Tools > NuGet Package Manager > Package Manager Console).
Run the following commands one by one:
  Install-Package Microsoft.EntityFrameworkCore.SqlServer -Version 8.0.1  
  Install-Package Microsoft.EntityFrameworkCore.Tools -Version 8.0.0  
  Install-Package Microsoft.EntityFrameworkCore.Design -Version 8.0.0  
  
Step 3: Create Connection String in appsettings.json
Open the appsettings.json file in your project.
Add a new section for your connection string under the existing configuration
  {
    "ConnectionStrings": {
       "InventoryDb": "Server=DESKTOP-4BMGUC1\\SQLEXPRESS;Database=inventoryManagement;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True;"
    }
    // Other configurations...
  }

Step 4: Create DbContext
Create a new class file (e.g., AppDbContext.cs) in your Models folder (or wherever appropriate).
Define your DbContext class as follows
using Microsoft.EntityFrameworkCore;  

public class AppDbContext : DbContext  
{  
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }  
    // Define DbSet for your entities  
    public DbSet<YourEntity> YourEntities { get; set; } // Replace with your model  
}  

Step 5: Configure Services in Program.cs
Open the Program.cs file.
Configure the services to use your DbContext by adding the following code:

using Microsoft.EntityFrameworkCore;  
var builder = WebApplication.CreateBuilder(args);  
// Add services to the container.  
builder.Services.inventoryDbContext<inventoryDbContext>(options =>  
    options.UseSqlServer(builder.Configuration.GetConnectionString("InventoryDb")));  
// Other services...  

Step 6: Create Model (Entity)
Create a new class file (e.g., YourEntity.cs) in the Models folder.

Step 7: Create DbSet for New Models
If you want to create a new model:
Open your AppDbContext class.
Add a new DbSet property for your new entity

Step 8: Run Migration for Code First
Open the Package Manager Console.
Run the following commands to add and apply the migration:
Add-Migration InitialCreate // Replace "InitialCreate" with a descriptive name for your migration  
Update-Database  



