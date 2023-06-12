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

            var r = new Region
            {
                RegionId = 5,
                RegionDescription = "demo"
            };

            context.Regions.Add(r);
            context.SaveChanges();

            foreach (var item in context.Regions)
            {
                Console.WriteLine((item.RegionId, item.RegionDescription.Trim()));
            }
        }
    }
}
