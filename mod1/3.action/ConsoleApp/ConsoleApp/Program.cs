using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int, int> compute = Add;
 
            compute(20, 4);

            static void Add(int i, int j)
            {
                Console.WriteLine(i + j);
            }
            static void Sub(int i, int j)
            {
                Console.WriteLine(i - j);
            }
            static void Mul(int i, int j)
            {
                Console.WriteLine(i * j);
            }
            static void Div(int i, int j)
            {
                Console.WriteLine(i / j);
            }
        }
    }
}
