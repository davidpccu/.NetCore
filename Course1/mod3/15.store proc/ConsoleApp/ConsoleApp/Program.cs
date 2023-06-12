using System;
using System.Linq;
using ConsoleApp.Data;
using ConsoleApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new NorthwindContext();
            string customerid = "ALFKI";

            var query = context.CustOrderHists.FromSqlInterpolated($"exec CustOrderHist {customerid}");

            foreach (var item in query)
            {
                Console.WriteLine((item.ProductName, item.Total));
            }
        }
    }
}
