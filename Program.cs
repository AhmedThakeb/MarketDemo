using MarketDemo.Context;
using MarketDemo.Repository;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
var MyConectionString = builder.Configuration.GetConnectionString("DefaultConection");
builder.Services.AddDbContext<dbcontainer>(options => options.UseSqlServer(MyConectionString));
builder.Services.AddScoped<CustomerRep>();
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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();