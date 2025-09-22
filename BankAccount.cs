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
        public string AccountHolder;
        public double Balance;

        public void ShowBalance()
        {
            Console.WriteLine($"Balance: {Balance} Kr");
        }
    }

}
