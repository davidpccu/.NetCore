var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
//builder.Logging.AddFilter((category,level)=>category=="MyLog");
//builder.Logging.AddFilter((category, level) => category == "MyLog"&&level>=LogLevel.Error);
//=================================
var app = builder.Build();
app.UseStaticFiles();
app.MapDefaultControllerRoute();

app.Run();
