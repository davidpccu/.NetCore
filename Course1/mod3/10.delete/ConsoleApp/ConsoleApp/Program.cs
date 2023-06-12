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

            Console.WriteLine("===========================================");
            //Console.WriteLine(context.ChangeTracker.Entries().Count());
            //foreach (var item in context.ChangeTracker.Entries())
            //{
            //    Console.WriteLine(item.State);
            //}

            var r = context.Regions.Find(6);

            if (r != null)
            {
                context.Remove(r);
                context.SaveChanges();
            }

            foreach (var item in context.Regions.AsNoTracking())
            {
                Console.WriteLine((item.RegionId, item.RegionDescription.Trim()));
            }

            
        }
    }
}
