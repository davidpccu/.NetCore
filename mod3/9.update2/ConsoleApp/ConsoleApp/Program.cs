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

            var employee = context.Employees.Find(10);
            var item2 = context.ChangeTracker.Entries().FirstOrDefault();

            Console.WriteLine((
                100,
                item2.State,
                item2.CurrentValues.GetValue<string>(nameof(Employee.FirstName)),
                 item2.OriginalValues.GetValue<string>(nameof(Employee.FirstName))
                ));

            employee.FirstName = "AAA";

            item2 = context.ChangeTracker.Entries().FirstOrDefault();
            Console.WriteLine((
                200,
            item2.State,
            item2.CurrentValues.GetValue<string>(nameof(Employee.FirstName)),
             item2.OriginalValues.GetValue<string>(nameof(Employee.FirstName))
            ));

            context.SaveChanges();

            Console.WriteLine((
                300,
            item2.State,
            item2.CurrentValues.GetValue<string>(nameof(Employee.FirstName)),
             item2.OriginalValues.GetValue<string>(nameof(Employee.FirstName))
            ));

            Console.WriteLine("==========================");
            foreach (var item in context.Employees)
            {
                Console.WriteLine((item.EmployeeId, item.FirstName, item.LastName));
            }
        }
    }
}
