using System;

namespace assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount(15);
            account1.Deposit(0.00m);
            account1.Withdraw(271.00m);
            System.Diagnostics.Debug.WriteLine($"Account {account1.AccountNumber} has ${account1.Balance} in the account.");
            BankAccount account2 = (BankAccount)account1.Clone();
            System.Diagnostics.Debug.WriteLine($"Account {account2.AccountNumber} has ${account2.Balance} in the account.");
        }
    }
}
