using System;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 0 };

            //var query = numbers.Skip(2); //3,4,5,0
            //var query = numbers.SkipWhile(i => i < 4); //4,5,0
            //var query = numbers.Take(3); //1,2,3
            var query = numbers.TakeWhile(i => i < 4); //1,2,3
            //var query = numbers.Where(i => i < 4); //1,2,3,0

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
        }
    }
}
