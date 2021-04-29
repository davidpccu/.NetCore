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

            var query = context.Employees
                    .FromSqlRaw("Select * from Employees ");

            foreach (var item in query)
            {
                Console.WriteLine($"{item.FirstName }");
            }
        }
    }
}
