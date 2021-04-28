using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<DateTime> func = GetTime;
            Console.WriteLine(func());

            Func<string, string> func2 = SayHi;
            Console.WriteLine(SayHi("Owen"));

        }
        static DateTime GetTime()
        {
            return DateTime.Now;
        }
        static string SayHi(string name)
        {
            return $"Hi {name}";
        }
    }
}
