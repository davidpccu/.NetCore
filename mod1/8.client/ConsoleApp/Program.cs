using System;
using System.ComponentModel;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();
            account.PrintProgressing += Account_PrintProgressing;

            Console.WriteLine("交易明細列印開始...");
            account.PrintTransactions();
        }

        private static void Account_PrintProgressing(object sender, ProgressChangedEventArgs e)
        {
            Console.WriteLine($"目前進度:{e.ProgressPercentage}%");
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
