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

            Console.Write("Employee ID:");
            int id = int.Parse(Console.ReadLine());

            var query = context.Employees.FromSqlInterpolated($"select * from employees where employeeid={id}").Include(e=>e.Orders);

            foreach (var item in query)
            {
                Console.WriteLine((item.EmployeeId, item.FirstName, item.Orders.Count()));
            }
        }
    }
}
