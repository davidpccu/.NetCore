var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

//=================================
var app = builder.Build();

app.Environment.EnvironmentName = Environments.Production;

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();
app.MapDefaultControllerRoute();

app.Run();
