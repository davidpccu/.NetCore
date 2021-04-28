using System;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 3, 5, 7, 22 };

            // 1.
            var query = numbers.Where(i => i >6);

            // 2.
            //var query = numbers.Where(i => {
            //    return i > 6;
            //});

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
        }
        //static bool XXX(int i)
        //{
        //    return i > 6;
        //}
    }
}
