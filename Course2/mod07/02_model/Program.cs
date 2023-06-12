using StarterM.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
//builder.Services.AddControllers()
//    .AddJsonOptions(o=>o.JsonSerializerOptions.PropertyNamingPolicy=null);

List<Customer> customers = new()
{
      new Customer {
        CustomerID ="ALFKI",
        CompanyName = "Alfreds Futterkiste",
        Country ="Germany"
      } ,
      new Customer {
        CustomerID ="ANATR",
        CompanyName = "Ana Trujillo Emparedados y helados",
        Country ="Mexico"
      } ,
      new Customer {
        CustomerID = "ANTON",
        CompanyName = "Antonio Moreno Taqueria",
        Country = "Mexico"
      }
 };

builder.Services.AddSingleton(customers);

//=================================
var app = builder.Build();
app.UseStaticFiles();
app.MapControllers();

app.Run();
