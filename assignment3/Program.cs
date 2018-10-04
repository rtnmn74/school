using System;

namespace assignment3 {
    class Program {
        static void Main (string[] args) {
            var account = new BankAccount ("John Smith", 1000);
            Console.WriteLine ($"Account {account.AccountNumber} was created for {account.AccountHolder} with {account.Balance} opening balance.");
        }
    }
}