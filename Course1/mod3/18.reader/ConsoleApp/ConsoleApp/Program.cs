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
            var cmd = new SqlCommand("select * from region;select * from employees;select * from Shippers", cn);

            cn.Open();
            using var dr = cmd.ExecuteReader();


            while (dr.Read())
            {
                Console.WriteLine((dr["regionid"], dr[1].ToString().Trim()));
            }
            Console.WriteLine("====================================");

            do
            {
                while (dr.Read())
                {
                    Console.WriteLine((dr[0], dr[1].ToString().Trim()));
                }
                Console.WriteLine("====================================");
            } while (dr.NextResult());
        }
    }
}
