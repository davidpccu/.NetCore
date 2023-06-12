using System;
using System.Linq;
using ConsoleApp.Data;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new NorthwindContext();
            var query = from c in context.Customers
                        join o in context.Orders on c.CustomerId equals o.CustomerId
                        where c.CustomerId == "ALFKI"
                        select new { c.CustomerId, c.CompanyName, o.OrderId, o.OrderDate };

            foreach (var item in query)
            {
                Console.WriteLine((item.CustomerId, item.CompanyName, item.OrderId, item.OrderDate.Value.ToShortDateString()));
            }
        }
    }
}
