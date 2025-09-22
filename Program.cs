namespace Ovning_OOP_Github_BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            account.AccountHolder = "Qassem";
            account.Deposit(500);
            account.Withdraw(200);
            Console.WriteLine($"Kontoinnehavare: {account.AccountHolder}");
            Console.ReadLine();
            Console.WriteLine($"Saldo: {account.GetBalance()} Kr");


            SavingsAccount savings = new SavingsAccount();
            savings.AccountHolder = "Qassem";
            savings.Deposit(1000);
            savings.InterestRate = 0.05;
            savings.ApplyInterest();

            Console.WriteLine($"Saldo efter ränta: {savings.GetBalance()} Kr");

            Account account1 = new bankAccount();
            account1.AccountHolder = "Qassem";
            account1.CalculateFees();       


        }
    }
}
