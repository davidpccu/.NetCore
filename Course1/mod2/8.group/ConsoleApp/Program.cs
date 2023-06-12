using System;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] items = { "apple", "ball", "candy", "asus", "air", "bell" };
            //var query = from s in items
            //            group s by s[0];

            var query = items.GroupBy(s => s[0]);

            foreach (var g in query)
            {
                Console.WriteLine(g.Key);

                foreach (var item in g)
                {
                    Console.WriteLine( $"   {item}");
                }
            }
        }
    }
}
