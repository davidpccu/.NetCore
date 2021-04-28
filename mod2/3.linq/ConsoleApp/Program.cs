using System;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "mary", "cindy", "alice", "janet", "amy" };

            var query = from s in names
                        // where s.StartsWith("a")
                        orderby s descending
                        select s;

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
        }
    }
}
