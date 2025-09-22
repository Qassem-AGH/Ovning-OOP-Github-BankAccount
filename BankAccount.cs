using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_OOP_Github_BankAccount
{
    // BankAccount.cs
    public class BankAccount
    {
        private double Balance;
        public string AccountHolder { get; set; }

        public void Deposit(double amount)
        {
            if (amount > 0) Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance) Balance -= amount;
        }

        public double GetBalance()
        {
            return Balance;
        }

        public virtual void ShowAccountType()
        {
            Console.WriteLine("Standard Bank Account");
        }

    }

}
