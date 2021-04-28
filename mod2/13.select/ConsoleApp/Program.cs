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

            var query = from c in customers
                            // select c;
                            //select c.CustomerName;
                            //select new { c.CustomerID, c.CustomerName };
                            //select new { id = c.CustomerID, name=c.CustomerName };
                            //select ( c.CustomerID, c.CustomerName );
                            select ( id:c.CustomerID, name:c.CustomerName );

            foreach (var item in query)
            {
                //Console.WriteLine(item);
                //Console.WriteLine((item.CustomerID, item.CustomerName));
                //Console.WriteLine((item.id, item.name));
                //Console.WriteLine((item.CustomerID, item.CustomerName));
                Console.WriteLine((item.id, item.name));
            }
        }
    }
    class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string City { get; set; }

        public override string ToString() => (CustomerID, CustomerName, City).ToString();

    }
}
