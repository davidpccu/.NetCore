using System;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 0, 1, 2, 3, 4, 5 };

            Console.WriteLine(numbers.ElementAt(3));
            Console.WriteLine(numbers.ElementAtOrDefault(3));
            Console.WriteLine(numbers.First());
            Console.WriteLine(numbers.FirstOrDefault());
            Console.WriteLine(numbers.Last());
            Console.WriteLine(numbers.LastOrDefault());
            Console.WriteLine("=============================");

            //default
            //Console.WriteLine(numbers.ElementAt(10)); //exception
            Console.WriteLine(numbers.ElementAtOrDefault(10)); //0
            Console.WriteLine("=============================");
            //single
            numbers = new int[] { 100 };
            Console.WriteLine(numbers.Single()); //100
            Console.WriteLine(numbers.SingleOrDefault()); //100

            //Console.WriteLine(numbers.Single(i=>i==7)); //exception
            Console.WriteLine(numbers.SingleOrDefault(i => i == 7)); //0
            Console.WriteLine("=============================");
            numbers = new int[] { 0, 1, 2, 3, 3, 4, 5 };
            //Console.WriteLine(numbers.SingleOrDefault(i=>i==3)); //exception 注意使用
            Console.WriteLine(numbers.FirstOrDefault(i => i == 3));
        }
    }
}
