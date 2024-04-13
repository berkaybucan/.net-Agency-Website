using KBBucan.Web.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<KbbWebContext>(option => option.UseSqlServer(
    builder.Configuration.GetConnectionString("DefaultConnection")));
var app = builder.Build();
app.MapAreaControllerRoute(name: "area",
    areaName: "Admin",
    pattern: "admin/{controller=IletisimForm}/{action=Index}");
app.MapControllerRoute("main", "{controller=Anasayfa}/{action=Index}/{id?}");
app.MapDefaultControllerRoute();    
app.UseStaticFiles();


app.Run();
