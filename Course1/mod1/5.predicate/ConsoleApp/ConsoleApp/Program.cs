using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> prd = CheckLength;
            Console.WriteLine(prd("AAAAAAAA"));
            Console.WriteLine(prd("BB"));
        }
        static bool CheckLength(string name)
        {
            if (name.Length > 3)
                return true;
            else
                return false;
        }
    }
}
