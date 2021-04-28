using System;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "mary", "cindy", "alice", "janet", "amy" };

            //var query = from n in names
            //            select n;

            //var query = names.Where(s => s.StartsWith("a"));
            //var query = names.OrderByDescending(s => s);
            var query = names.OrderByDescending(s => s.Length).ThenBy(s => s);

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
        }
    }
}
