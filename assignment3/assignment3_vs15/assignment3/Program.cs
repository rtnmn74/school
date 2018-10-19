using System;

namespace assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            var account1 = new BankAccount(15);
            account1.Deposit(1.00m);
            account1.Deposit(272.00m);
            account1.Withdraw(271.00m);
            System.Diagnostics.Debug.WriteLine($"Account {account1.AccountNumber} has ${account1.Balance} in the account.");
            var account2 = (BankAccount)account1.Clone();
            System.Diagnostics.Debug.WriteLine($"Account {account2.AccountNumber} has ${account2.Balance} in the account.");
        }
    }
}
