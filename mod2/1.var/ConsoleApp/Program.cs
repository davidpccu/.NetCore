using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //var i = 10;
            //i = "20";
            //Console.WriteLine(i);

            //dynamic i = 10;
            //i = "20";
            //Console.WriteLine(i);
            //====================
            var book= new { Title = "c#", Price = 1000 };
            Console.WriteLine(book.GetType());
            Console.WriteLine( $"{ book.Title},{book.Price}");
            Console.WriteLine((book.Title,book.Price)); //c# tuple -> 不同類型
        }
    }
}
