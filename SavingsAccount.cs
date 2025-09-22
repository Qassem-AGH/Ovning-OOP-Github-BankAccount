using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_OOP_Github_BankAccount
{
    public class SavingsAccount : BankAccount
    {
        public double InterestRate { get; set; }

        public void ApplyInterest()
        {
            Deposit(GetBalance() * InterestRate);
        }
    }

}
