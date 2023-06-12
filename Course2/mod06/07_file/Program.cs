var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var p1 = builder.Environment.ContentRootFileProvider;
builder.Services.AddSingleton(p1);

//=================================
var app = builder.Build();
app.UseStaticFiles();
app.MapDefaultControllerRoute();

app.Run();
