using System;

namespace State
{
    /// <summary>
    /// State Design Pattern
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            Account account = new Account("Jim Johnson");

            account.Deposit(500.0);
            account.Deposit(300.0);
            account.Deposit(550.0);
            account.PayInterest();
            account.Withdraw(2000.00);
            account.Withdraw(1100.00);

            Console.ReadKey();
        }
    }
}
