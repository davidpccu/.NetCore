using System;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            var query = from n in numbers
                        select n;

            Console.WriteLine($"Aggregate:{query.Aggregate((i, j) => i * j)}");
            Console.WriteLine($"Average:{query.Average()}");
            Console.WriteLine($"Sum:{query.Sum()}");
            Console.WriteLine($"Count:{query.Count()}");
            Console.WriteLine($"Max:{query.Max()}");
            Console.WriteLine($"Min:{query.Min()}");
        }
    }
}
