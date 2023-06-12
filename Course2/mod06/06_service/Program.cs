using StarterM;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

//builder.Services.AddTransient<IMyService, MySevice>();
//builder.Services.AddScoped<IMyService, MySevice>();
//builder.Services.AddSingleton<IMyService, MySevice>();

using MySevice myService=new MySevice();
builder.Services.AddSingleton<IMyService>(myService);

//=================================
var app = builder.Build();
app.UseStaticFiles();
app.MapDefaultControllerRoute();

app.Run();
