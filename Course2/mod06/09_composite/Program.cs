using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var p1 = builder.Environment.ContentRootFileProvider;
//builder.Services.AddSingleton(p1);
var p2= new EmbeddedFileProvider(typeof(Program).Assembly);
//builder.Services.AddSingleton<IFileProvider>(p2);

var p3=new CompositeFileProvider(p1,p2);
builder.Services.AddSingleton<IFileProvider>(p3);
//=================================
var app = builder.Build();
app.UseStaticFiles();
app.MapDefaultControllerRoute();

app.Run();
