using System;
using NUnit.Framework;

namespace assignment3 {
    [TestFixture]
    public class BankaccountTests {
        [TestCase]
        public void withdrawalCorrect () {
            BankAccount account = new BankAccount (11);
            account.Deposit (200);
            account.Withdraw (100);
            var result = account.ReturnBalance ();
            /* The balance is 100 */
            Assert.That (result, Is.EqualTo (100));
        }

        [TestCase]
        public void balanceEquals () {
            BankAccount account1 = new BankAccount (11);
            account1.Deposit (200);
            account1.Withdraw (100);
            BankAccount account2 = new BankAccount (12);
            account2.Deposit (200);
            account2.Withdraw (100);
            var result = account1.Equals (account2);
            /* The result is true */
            Assert.That (result, Is.True);
        }

        [TestCase]
        public void balanceCloneEquals () {
            BankAccount account1 = new BankAccount (11);
            account1.Deposit (200);
            account1.Withdraw (100);
            BankAccount account2 = (BankAccount)account1.Clone ();
            var result = account1.Equals (account2);
            /* The result is true */
            Assert.That (result, Is.True);
        }

    }
}