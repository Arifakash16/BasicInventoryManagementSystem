using BasicInventoryManagementSystem.Db;
using BasicInventoryManagementSystem.Repository.ImplRepository;
using BasicInventoryManagementSystem.Repository.IRepository;
using BasicInventoryManagementSystem.Service.ImplService;
using BasicInventoryManagementSystem.Service.IService;
using FluentAssertions.Common;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<InventoryDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("InventoryDb")));

// for Registration service and repository
builder.Services.AddScoped<IRegistrationService, RegistrationService>();
builder.Services.AddScoped<IRegistrationRepository, RegistrationRepository>();

// for HomeLogReg service and repository
builder.Services.AddScoped<ILoginService, LoginService>(); 
builder.Services.AddScoped<ILoginRepository, LoginRepository>();

<<<<<<< HEAD
// for ProductCatagory service and repository
builder.Services.AddScoped<IProductCatagoryService, ProductCatagoryService>();
builder.Services.AddScoped<IProductCatagoryRepository, ProductCatagoryRepository>();

=======
>>>>>>> cd722e539699a2e9421cad6fa6332a486ddb8477
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=HomeLogReg}/{action=Index}/{id?}");

app.Run();
