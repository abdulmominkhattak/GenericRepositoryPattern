using GenericRepo.Data;
using GenericRepo.GenericRepository;
using GenericRepo.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
string cs = "server=CRKRL-MOMINABD1; database=RepoDb; trusted_connection=true;";
builder.Services.AddDbContext<GenericRepoContext>(options => options.UseSqlServer(cs));
builder.Services.AddTransient<IGenericRepository<Customer>, GenericRepository<Customer>>();
builder.Services.AddTransient<IGenericRepository<Product>, GenericRepository<Product>>();
builder.Services.AddTransient<IGenericRepository<Order>, GenericRepository<Order>>();


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
