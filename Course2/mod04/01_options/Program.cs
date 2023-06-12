using StarterM.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.Configure<WebsiteProfile>(p =>
{
    p.Email = "config@uuu.com.tw";
    p.ThemeColor = "lightblue";
});

//=================================
var app = builder.Build();
app.UseStaticFiles();
app.MapDefaultControllerRoute();

app.Run();
