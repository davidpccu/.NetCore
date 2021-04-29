using ConsoleApp.Data;
using ConsoleApp.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string cnStr = "Server=.\\SQLExpress;Database=Northwind;Trusted_Connection=True;";
            using var cn = new SqlConnection(cnStr);

            cn.Open();

            var cmd = new SqlCommand("insert into region values (@id, @name)", cn);
            cmd.Parameters.Add(new SqlParameter("@id", 8));
            cmd.Parameters.AddWithValue("@name", "ABC");

            int affected = cmd.ExecuteNonQuery();
            Console.WriteLine("Records affected: " + affected);
        }
    }
}
