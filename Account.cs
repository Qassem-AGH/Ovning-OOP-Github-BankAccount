using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_OOP_Github_BankAccount
{
    public abstract class Account
    {
        public string AccountHolder { get; set; }
        public abstract void CalculateFees();
    }

    public class bankAccount : Account
    {
        public override void CalculateFees()
        {
            Console.WriteLine("BankAccount fee: 50 Kr");
        }
    }

}
