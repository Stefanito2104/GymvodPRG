using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPlayground
{
    internal class BankAccount
    {
        public int accountNumber;
        public double balance;
        public string holderName, currency;
        public BankAccount(int accountNumber, string holderName, string currency, double balance)
        {
            this.accountNumber = accountNumber;
            this.holderName = holderName;
            this.currency = currency;
            this.balance = balance;
        }
        public void Deposit()
        {
            Console.Write("Zadej množství: ");
            double money = double.Parse(Console.ReadLine());
            balance = balance + money;
            Console.Write("Nový zůstatek: ");
            balance = double.Parse(Console.ReadLine());
        }
    }
}
