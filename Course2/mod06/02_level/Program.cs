var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
//Console.WriteLine("====================================");
//foreach (var item in (builder.Configuration as IConfigurationRoot).Providers)
//{
//    Console.WriteLine(item);
//}
//Console.WriteLine("====================================");

//=================================
var app = builder.Build();
app.UseStaticFiles();
app.MapDefaultControllerRoute();

app.Run();
