using Microsoft.AspNetCore.Mvc;
using StarterM.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddControllersWithViews();
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

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseStaticFiles();
//app.MapDefaultControllerRoute();

app.MapGet("/", () => "Hello World");
app.MapGet("/Customer", () => new Customer { CustomerID = "aaa", CompanyName = "bbb", Country = "ccc" });
app.MapGet("/400", () => Results.BadRequest());

app.MapGet("/Customers", (List<Customer> list) => list);
app.MapGet("/Customers/{id}", (List<Customer> list, string id) =>
{
    var item = list.Find(x => x.CustomerID == id);
    if (item == null) return Results.NotFound();
    return Results.Ok(item);
});

app.Run();
