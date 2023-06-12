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

            foreach (var item in context.Regions.AsNoTracking())
            {
                Console.WriteLine((item.RegionId, item.RegionDescription.Trim()));
            }

            Console.WriteLine(context.ChangeTracker.Entries().Count());
            foreach (var item in context.ChangeTracker.Entries())
            {
                Console.WriteLine(item.State);
            }

            var r = new Region
            {
                RegionId = 5,
                RegionDescription = "demo..."
            };

            context.Regions.Update(r);
            context.SaveChanges();

            foreach (var item in context.Regions)
            {
                Console.WriteLine((item.RegionId, item.RegionDescription.Trim()));
            }

            
        }
    }
}
