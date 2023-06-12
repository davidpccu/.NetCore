using System.Net.Mime;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

//=================================
var app = builder.Build();

app.Environment.EnvironmentName = Environments.Production;

if (app.Environment.IsDevelopment())
{
    app.UseStatusCodePages();
}
else
{
    app.UseExceptionHandler("/Error");
    //app.UseStatusCodePages(MediaTypeNames.Text.Html, "<h1 style='color:red;'>StatusCode: {0}</h1>");
    //app.UseStatusCodePagesWithRedirects("/StatusCode?code={0}");
    app.UseStatusCodePagesWithReExecute("/StatusCode","?code={0}");
}


app.UseStaticFiles();
app.MapDefaultControllerRoute();

app.Run();
