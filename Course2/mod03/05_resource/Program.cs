using Microsoft.AspNetCore.Localization;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddLocalization(o=>o.ResourcesPath="Resources");

//=================================
var app = builder.Build();

var supportedCultures = new[] {
         new CultureInfo("en-US"),
         new CultureInfo("zh-TW")
    };

app.UseRequestLocalization(new RequestLocalizationOptions
{
    DefaultRequestCulture=new RequestCulture("en-US"),
    SupportedCultures=supportedCultures,
    SupportedUICultures=supportedCultures

});

app.UseStaticFiles();
app.MapDefaultControllerRoute();

app.Run();
