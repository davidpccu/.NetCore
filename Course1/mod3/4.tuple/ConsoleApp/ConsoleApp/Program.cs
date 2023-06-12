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
            var query = from emp in context.Employees //.AsEnumerable()
                        //select (emp.EmployeeId, emp.FirstName);
                        select new { emp.EmployeeId, emp.FirstName };

            foreach (var item in query)
            {
                Console.WriteLine((item.EmployeeId, item.FirstName));
            }
        }
    }
}
