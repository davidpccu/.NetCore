using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<object> { 10, "hello", DateTime.Now, true, 'c', 20, "world" };

            //var query = from s in list.OfType<DateTime>()
            //            select s;

            var query = list.OfType<int>();

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
        }
    }
}
