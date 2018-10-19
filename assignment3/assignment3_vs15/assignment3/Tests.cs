using System;
using NUnit.Framework;

namespace assignment3
{
    [TestFixture]
    public class BankAccountTests
    {
        /* Test the deposit method by depositing 200 */
        public void depositTest()
        {
            /* Contruct new account with account number 1001 */
            BankAccount account1 = new BankAccount(1001);
            /* Deposit 200.90 */
            account1.Deposit(200.90m);
            /* Return account balance */
            var result = account1.checkBalance();
            /* Assert that the balance is 200.90 */
            Assert.That(result, Is.EqualTo(200.90m));
        }

        [TestCase]
        /* Test the deposit and withdraw methods together*/
        public void multipleTransactionTest()
        {
            /* Construct new account with account number 1200 */
            BankAccount account2 = new BankAccount(1200);
            /* Deposit 200.03 */
            account2.Deposit(200.03m);
            /* Deposit 100.00 */
            account2.Deposit(100.00m);
            /* Withdraw 100.01 */
            account2.Withdraw(100.02m);
            /* Withdraw 20.00 */
            account2.Withdraw(20.00m);
            /* Return account balance */
            var result = account2.checkBalance();
            /* Assert that the balance is 180.01 */
            Assert.That(result, Is.EqualTo(180.01m));
        }

        [TestCase]
        /* Test the equals override to compare multiple account balances when equal */
        public void balanceEqualsTest()
        {
            /* Contruct new account with account number 1300 */
            BankAccount account3 = new BankAccount(1300);
            /* Deposit 200.00 */
            account3.Deposit(200.00m);
            /* Withdraw 100.00 */
            account3.Withdraw(100.00m);
            /* Construct another new account with account number 1400 */
            BankAccount account4 = new BankAccount(1400);
            /* Deposit 200.00 */
            account4.Deposit(200.00m);
            /* Witdraw 100.00 */
            account4.Withdraw(100.00m);
            /* Return account balance */
            var result = account3.Equals(account4);
            /* Asser that the 2 account balances match */
            Assert.That(result, Is.True);
        }

        [TestCase]
        /* Test the equals override to compare multiple account balances when not equal*/
        public void balanceNotEqualsTest()
        {
            /* Contruct new account with account number 1300 */
            BankAccount account33 = new BankAccount(1300);
            /* Deposit 200.00 */
            account33.Deposit(200.00m);
            /* Withdraw 100.00 */
            account33.Withdraw(100.00m);
            /* Construct another new account with account number 1400 */
            BankAccount account44 = new BankAccount(1400);
            /* Deposit 300.00 */
            account44.Deposit(300.00m);
            /* Witdraw 100.00 */
            account44.Withdraw(100.00m);
            /* Return account balance */
            var result = account33.Equals(account44);
            /* Asser that the 2 account balances match */
            Assert.That(result, Is.False);
        }

        [TestCase]
        /* Test cloning an account using the clone method*/
        public void balanceCloneEqualsTest()
        {
            /* Contruct a new account with account number 1500 */
            BankAccount account5 = new BankAccount(1500);
            /* Deposit 200.00 */
            account5.Deposit(200.00m);
            /* Withdraw 100.00 */
            account5.Withdraw(100.00m);
            /* Construct a new account by cloning account5 */
            BankAccount account6 = (BankAccount)account5.Clone();
            /* Compare the balance of both accounts using the overriden equals method*/
            var result = account5.Equals(account6);
            /* Assert that the account and the account clone match */
            Assert.That(result, Is.True);
        }

        [TestCase]
        /* Test withdrawal amount more then the balance */
        public void withdrawalMoreThanBalaneTest()
        {
            /* Construct new account with account number 1600 */
            BankAccount account7 = new BankAccount(1600);
            /* Deposit 200.00 */
            account7.Deposit(200.00m);
            /* Assert that the method throws an exception when the withdrawal is more than the balance*/
            var ex = Assert.Throws<ArgumentException>(() => account7.Withdraw(201.00m));
            Assert.That(ex.Message, Is.EqualTo("Precondition failed: amount < Balance  Withdrawal can not be more than the balance\r\nParameter name: Withdrawal can not be more than the balance"));
        }
        [TestCase]
        /* Test withdraw amount with a negative amount*/
        public void withdrawNegativeAmountTest()
        {
            /* Contruct new account with account number 1900 */
            BankAccount account8 = new BankAccount(1900);
            /* Deposit 100.00 */
            account8.Deposit(100.00m);
            /* Assert that the method throws an exception when the withdrawal is a negative amount*/
            var ex = Assert.Throws<System.ArgumentException>(() => account8.Withdraw(-0.01m));
            Assert.That(ex.Message, Is.EqualTo("Precondition failed: amount > 0.00m  Withdrawal must be greater than zero\r\nParameter name: Withdrawal must be greater than zero"));
        }

        [TestCase]
        /* Test deposit amount with a negative amount*/
        public void depositNegativeAmountTest()
        {
            /* Contruct new account with account number 2000 */
            BankAccount account9 = new BankAccount(2000);
            /* Assert that the method throws and exception when the deposit is a negative amount */
            var ex = Assert.Throws<System.ArgumentException>(() => account9.Deposit(-0.01m));
            Assert.That(ex.Message, Is.EqualTo ("Precondition failed: amount > 0.00m  Deposit must be greater than zero\r\nParameter name: Deposit must be greater than zero"));

        }

}
}
