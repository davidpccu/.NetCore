using System;
using System.Linq;
using ConsoleApp.Data;
using ConsoleApp.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new NorthwindContext();
            var sql = "INSERT Region VALUES (@RegionId ,@RegionDescription)";
            var regionId = new SqlParameter("@RegionId", 7);
            var regionDescription = new SqlParameter("@regionDescription", "123");

            //int rowAffected = context.Database.ExecuteSqlCommand(sql, regionId, regionDescription);
            int rowAffected = context.Database.ExecuteSqlInterpolated($"INSERT Region VALUES ({regionId} ,{regionDescription})");


            Console.WriteLine("Row affected : " + rowAffected);

            foreach (var item in context.Regions)
            {
                Console.WriteLine((item.RegionId, item.RegionDescription.TrimEnd()));
            }
        }
    }
}
