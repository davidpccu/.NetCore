using StarterM.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

builder.Services.Configure<WebsiteProfile>(builder.Configuration);
builder.Configuration.AddJsonFile("profile.json",true,true);
builder.Configuration.AddInMemoryCollection(new Dictionary<string, string> {
    ["email"]="memory@uuu.com.tw",
    ["themeColor"]="pink"
});

Console.WriteLine("====================================");
foreach (var item in (builder.Configuration as IConfigurationRoot).Providers)
{
    Console.WriteLine(  item);
}
Console.WriteLine("====================================");
//=================================
var app = builder.Build();
app.UseStaticFiles();
app.MapDefaultControllerRoute();

app.Run();
