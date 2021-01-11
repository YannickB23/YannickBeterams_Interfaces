using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YannickBeterams_Interfaces.Interfaces;

namespace YannickBeterams_Interfaces.Models
{
    public class Transaction : Bank, ITransaction
    {
        private readonly string _code;
        private readonly string _date;
        private readonly double _amount;
        private double _commission;

        public Transaction(string code, string date, double amount)
        {
            _amount = amount;
            _date = date;
            _code = code;
        }
        public double GetAmount()
        {
            if (_amount > 100)
            {
                Console.WriteLine($"You will be charged with an extra commission: {_commission = _amount * 0.5/100}!");
                return _commission;
            }
            Console.WriteLine($"Your account will not be charged with an extra commission!");
            return _amount;
        }

        public string ShowBankName()
        {
            return BankName + Adress;
        }

        public void ShowTransaction()
        {
            Console.WriteLine(BankName +"\n"+ Adress +"\nTransaction: " + _code + "\nDate: " + _date + "\nAmount: " + _amount);
        }

    }
}
