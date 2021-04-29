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
            var query = from emp in context.Employees
                        where emp.EmployeeId == 1
                        select emp;

            foreach (var item in query)
            {
                Console.WriteLine((item.EmployeeId, item.FirstName, item.Orders.Count()));
            }
        }
    }
}
