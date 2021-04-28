using System;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 3, 5, 7, 22 };

            var query = numbers.Where(XXX);

            foreach(var item in query)
            {
                Console.WriteLine(item);
            }
        }
        static bool XXX(int i)
        {
            return i > 6;
        }
    }
}
