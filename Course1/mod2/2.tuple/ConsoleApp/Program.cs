using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = "c#";
            int price = 1000;

            ////variable -> anonymous type
            //var book = new { title, price };
            ////book.title = "aaa"; //err
            //Console.WriteLine((book.title, book.price));
            //==============================

            //variable -> tuple
            var book = (title, price);
            book.title = "aaa";
            Console.WriteLine((book.title, book.price));

            //tuple->variable
            var (a, b) = book;
            Console.WriteLine((a, b));

            //==============================
            var book2 = (10, "ABC", 500);
            Console.WriteLine((book2.Item1 -9, book2.Item2, book2.Item3 + 50));

            var book3 = (id:10, title:"ABC", num:500);
            Console.WriteLine((book3.Item1 -9, book3.Item2, book3.Item3 +50));
        }
    }
}
