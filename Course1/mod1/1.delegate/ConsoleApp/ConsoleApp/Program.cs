using System;

namespace ConsoleApp
{
    //1. 宣告
    delegate void Mydelegate(int x, int y);
    class Program
    {
        static void Main(string[] args)
        {
            //2. 傳統寫法
            //Mydelegate compute = new Mydelegate(Add);
            //3. 執行
            //compute.Invoke(20, 4);

            //========================
            //2. 新寫法
            Mydelegate compute = Add;
 
            //3. 執行
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
