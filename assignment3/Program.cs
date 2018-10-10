using System;

namespace assignment3 {
    class Program {
        static void Main (string[] args) {
            var account1 = new BankAccount(15);
            account1.Deposit(150);
            account1.Withdraw(100);
            Console.WriteLine ($"Account {account1.AccountNumber} has ${account1.Balance} in the account.");
            var account2 = (BankAccount)account1.Clone();
            Console.WriteLine ($"Account {account2.AccountNumber} has ${account2.Balance} in the account.");
        }
    }   
}