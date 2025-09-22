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
        private double balance;
        public string AccountHolder { get; set; }

        public void Deposit(double amount)
        {
            if (amount > 0) balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance) balance -= amount;
        }

        public double GetBalance()
        {
            return balance;
        }

        public virtual void ShowAccountType()
        {
            Console.WriteLine("Standard Bank Account");
        }

    }

}
