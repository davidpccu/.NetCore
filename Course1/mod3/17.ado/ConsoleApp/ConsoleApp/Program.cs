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
            var da = new SqlDataAdapter("select * from region", cn);

            DataTable myTable = new DataTable();
            da.Fill(myTable);

            foreach (DataRow item in myTable.Rows)
            {
                Console.WriteLine((item["regionid"], item[1].ToString().Trim()));
            }
        }
    }
}
