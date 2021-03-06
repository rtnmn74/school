using System;
using NUnit.Framework;

namespace assignment3 {
    [TestFixture]
    public class BankAccountTests {
        [TestCase]
        /* Test the withdraw method by withdawing 0*/
        public void withDrawZeroTest () {
            /* Contruct new account with account number 1000 */
            BankAccount account0 = new BankAccount (1000);
            /* Deposit 100.00 */
            account0.Deposit (100.00m);
            /* Withdraw 0.00 */
            account0.Withdraw (0.00m);
            /* Return account balance */
            var result = account0.checkBalance ();
            /* Assert that the balance is 100.00*/
            Assert.That (result, Is.EqualTo (100.00m));
        }
        [TestCase]
        /* Test the deposit method by depositing 200 */
        public void depositTest () {
            /* Contruct new account with account number 1001 */
            BankAccount account1 = new BankAccount (1001);
            /* Deposit 200.90 */
            account1.Deposit (200.90m);
            /* Return account balance */
            var result = account1.checkBalance ();
            /* Assert that the balance is 200.90 */
            Assert.That (result, Is.EqualTo (200.90m));
        }
        
        [TestCase]
        /* Test the deposit and withdraw methods together*/
        public void combinedMethodTest () {
            /* Construct new account with account number 1200 */
            BankAccount account2 = new BankAccount (1200);
            /* Deposit 200.03 */
            account2.Deposit (200.03m);
            /* Withdraw 100.01 */
            account2.Withdraw (100.02m);
            /* Return account balance */
            var result = account2.checkBalance ();
            /* Assert that the balance is 100.01 */
            Assert.That (result, Is.EqualTo (100.01m));
        }

        [TestCase]
        /* Test the equals override to compare multiple account balances */
        public void balanceEqualsTest () {
            /* Contruct new account with account number 1300 */
            BankAccount account3 = new BankAccount (1300);
            /* Deposit 200.00 */
            account3.Deposit (200.00m);
            /* Withdraw 100.00 */
            account3.Withdraw (100.00m);
            /* Construct another new account with account number 1400 */
            BankAccount account4 = new BankAccount (1400);
            /* Deposit 200.00 */
            account4.Deposit (200.00m);
            /* Witdraw 100.00 */
            account4.Withdraw (100.00m);
            /* Return account balance */
            var result = account3.Equals (account4);
            /* Asser that the 2 account balances match */
            Assert.That (result, Is.True);
        }

        [TestCase]
        /* Test cloning an account using the clone method*/
        public void balanceCloneEqualsTest () {
            /* Contruct a new account with account number 1500 */
            BankAccount account5 = new BankAccount (1500);
            /* Deposit 200.00 */
            account5.Deposit (200.00m);
            /* Withdraw 100.00 */
            account5.Withdraw (100.00m);
            /* Construct a new account by cloning account5 */
            BankAccount account6 = (BankAccount)account5.Clone ();
            /* Compare the balance of both accounts using the overriden equals method*/
            var result = account5.Equals (account6);
            /* Assert that the account and the account clone match */
            Assert.That (result, Is.True);
        }
        [TestCase]
        /* Test when a withdrawal is more then the balance */
        public void withdrawalMoreThanDepositTest () {
            /* Construct new account with account number 1600 */
            BankAccount account7 = new BankAccount (1600);
            /* Deposit 200.00 */
            account7.Deposit (200.00m);
            /* Assert that the method throws the exception message when more than the deposit amount is withdrawn */
            var ex = Assert.Throws<System.Exception> (() => account7.Withdraw (201.00m));
            Assert.That (ex.Message, Is.EqualTo ("Withdrawal declined. You do not have enough money in your account"));
        }
        [TestCase]
        /* Test the withdraw method returns zero when withdawing a negative amount*/
        public void withdrawNegativeAmountTest () {
            /* Contruct new account with account number 1900 */
            BankAccount account8 = new BankAccount (1900);
            /* Deposit 1.00 */
            account8.Deposit (1.00m);
            /* Withdraw negative 0.01 */
            account8.Withdraw (-0.01m);
            /* Return balance */
            var result = account8.checkBalance ();
            /* Assert that the balance is 1.00, since no deposit was 1.00 and withdrawal ammount defaults to zero with a negative amount*/
            Assert.That (result, Is.EqualTo (1.00m));
        }
        [TestCase]
        /* Test the deposit method returns zero by depositing negative amount*/
        public void depositNegativeAmountTest () {
            /* Contruct new account with account number 2000 */
            BankAccount account9 = new BankAccount (2000);
            /* Deposit negative 0.01 */
            account9.Deposit (-0.01m);
            /* Return balance */
            var result = account9.checkBalance ();
            /* Assert that the balance is 0.00 */
            Assert.That (result, Is.EqualTo (0.00m));
        }
    }
}