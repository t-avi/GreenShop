using GreenShop;
using GreenShop.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddSingleton<IProductRepository, InMemoryProductRepository>();
builder.Services.AddSingleton<ICartRepository, InMemoryCartRepository>();


builder.Services.AddTransient<IProduct, Product>(_ => new Product("name", 0, "desc", "1.PNG"));
builder.Services.AddTransient<ICartPosition, CartPosition>();
builder.Services.AddTransient<ICart, Cart>(_ => new Cart(Constants.UserId));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
