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

            //var emp = new Employee { 
            //    FirstName = "aaa",
            //    LastName = "bbb"
            //};
            //context.Employees.Add(emp);
            //context.SaveChanges();
            //=======================================

            //var employee = new Employee
            //{
            //    EmployeeId = 10,
            //    FirstName = "aaa...",
            //    LastName = "bbb..."
            //};

            //context.Employees.Update(employee);
            //context.SaveChanges();
            //=======================================

            var employee = context.Employees.Find(10);
            employee.FirstName = "ccc";

            context.SaveChanges();

            foreach (var item in context.Employees)
            {
                Console.WriteLine((item.EmployeeId, item.FirstName, item.LastName));
            }
        }
    }
}
