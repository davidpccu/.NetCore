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

            var query = context.EmployeeViews
                    .FromSqlRaw("Select firstname, lastname from Employees where employeeid={0}", 1);

            foreach (var item in query)
            {
                Console.WriteLine($"{item.FirstName }");
            }
        }
    }
}
