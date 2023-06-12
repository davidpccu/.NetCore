var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
//builder.Services.AddControllers(o=>o.RespectBrowserAcceptHeader=true)
//    .AddXmlSerializerFormatters();
//=================================
var app = builder.Build();
app.UseStaticFiles();
app.MapControllers();

app.Run();
