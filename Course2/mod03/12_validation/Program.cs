using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Localization.Routing;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews()
    .AddDataAnnotationsLocalization()
    .AddViewLocalization();
builder.Services.AddLocalization(o=>o.ResourcesPath="Resources");

//=================================
var app = builder.Build();

var supportedCultures = new[] {
     new CultureInfo("en-US"),
     new CultureInfo("zh-TW")
};
var options = new RequestLocalizationOptions
{
    DefaultRequestCulture = new RequestCulture("en-US"),
    SupportedCultures = supportedCultures,
    SupportedUICultures = supportedCultures
};
options.RequestCultureProviders.Insert(0, new RouteDataRequestCultureProvider());

app.UseStaticFiles();

app.UseRequestLocalization(options);

app.MapControllerRoute("culture",
      "{culture=en-us}/{controller=Home}/{action=Index}/{id?}");
app.MapDefaultControllerRoute();

app.Run();
