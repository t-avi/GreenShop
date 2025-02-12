using GreenShop;
using GreenShop.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddSingleton<ProductRepository>();
builder.Services.AddSingleton<CartRepository>();

builder.Services.AddTransient<CartPosition>();
builder.Services.AddTransient<Cart>(_ => new Cart(Constants.UserId)); 
builder.Services.AddTransient<Product>(_ => new Product("name", 0, "desc", "1.PNG"));

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
