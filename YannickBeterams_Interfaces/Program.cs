using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YannickBeterams_Interfaces.Interfaces;
using YannickBeterams_Interfaces.Models;

namespace YannickBeterams_Interfaces
{
    class Program
    {
        private static string code;
        private static string date;
        private static double amount;

        static void Main(string[] args)
        {
            ITransaction transaction = new Transaction(code = "0001", date = "30/12/2019", amount = 50 );
            transaction.ShowBankName();
            transaction.ShowTransaction();
            transaction.GetAmount();
            Console.WriteLine(transaction);
            Console.WriteLine("---------------------------------------");
            ITransaction transaction1 = new Transaction(code = "0002", date = "31/12/2019", amount = 376);
            transaction1.ShowBankName();
            transaction1.ShowTransaction();
            transaction1.GetAmount();
            Console.WriteLine(transaction1);

            Console.ReadLine();
        }
    }
}
