using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebApplication14.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<WebApplication14Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("WebApplication14Context") ?? throw new InvalidOperationException("Connection string 'WebApplication14Context' not found.")));


builder.Services.AddControllersWithViews();




var app = builder.Build();


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Bear}/{action=Home}/{id?}");

app.Run();
