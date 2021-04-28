using System;
using System.ComponentModel;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();
            //account.PrintProgressing += delegate(object sender, ProgressChangedEventArgs e)
            //{
            //    Console.WriteLine($"目前進度:{e.ProgressPercentage}%");
            //};

            //account.PrintProgressing += delegate
            //{
            //    Console.WriteLine("處理中，請稍後...");
            //};

            // 1.
            account.PrintProgressing += (object sender, ProgressChangedEventArgs e) =>
            {
                Console.WriteLine($"目前進度:{e.ProgressPercentage}%");
            };

            // 2.
            account.PrintProgressing += (sender, e) =>
            {
                Console.WriteLine($"目前進度:{e.ProgressPercentage}%");
            };

            // 3.
            account.PrintProgressing += (sender, e) => Console.WriteLine($"目前進度:{e.ProgressPercentage}%");


            Console.WriteLine("交易明細列印開始...");
            account.PrintTransactions();
        }
    }
    class Account
    {
        //1.
        public event EventHandler<ProgressChangedEventArgs> PrintProgressing;

        public void PrintTransactions()
        {
            for (int i = 1; i <= 10; i++)
            {
                //模擬查詢並列印交易明細...
                System.Threading.Thread.Sleep(300);

                //2.
                PrintProgressing?.Invoke(this, new ProgressChangedEventArgs(i * 10, null));

                //if(PrintProgressing != null)
                //{
                //    PrintProgressing(this, new ProgressChangedEventArgs(i * 10, null));
                //}

            }
            Console.WriteLine("交易明細列印完畢!");
        }
    }
}
