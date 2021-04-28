using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer> {
              new Customer{ CustomerID = 1, CustomerName ="Mary" , City = "Berlin"},
              new Customer{ CustomerID = 2, CustomerName ="Ann" , City = "UK" },
              new Customer{ CustomerID = 3, CustomerName ="Lili" ,City = "UK",}
            };

            foreach (var item in customers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("=====================");

            var arr = customers.Select(s => s.CustomerName).ToArray();
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("=====================");

            var dict = customers.ToDictionary(s => s.CustomerID);
            foreach (var item in dict)
            {
                Console.WriteLine(item.Key + "  " + item.Value);
            }
            Console.WriteLine("=====================");
        }
    }
    class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string City { get; set; }

        //public override string ToString() => $"{CustomerID} {CustomerName} {City}";
        public override string ToString() => (CustomerID, CustomerName, City).ToString();

        //public override string ToString()
        //{
        //    return $"{CustomerID} {CustomerName} {City}";
        //}
    }
   
}
