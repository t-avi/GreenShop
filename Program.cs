var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//app.UseHttpsRedirection();

app.UseStaticFiles(); //using wwwroot

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{a?}/{b?}/{op?}"); //routing map

app.Run();

//https://localhost:5001/start/hello 1st lesson
//https://localhost:5001/calculator/index/1/3 2nd lesson
//https://localhost:5001/calculator/index/1/3/* 3rd lesson
//https://localhost:5001/calculator/index?a=1&b=3&op=+ 4th lesson
