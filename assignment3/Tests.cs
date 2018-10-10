using System;
using NUnit.Framework;

namespace assignment3 {
    [TestFixture]
    public class BankaccountTests {
        [TestCase]
        public void whenWithdrawalCorrect () {
            BankAccount account = new BankAccount (11);
            account.Deposit(200);
            account.Withdraw(100);
            var result = account.ReturnBalance ();
            /* The balance should be 100 */
            Assert.That (result, Is.EqualTo(100));
        }
    }
}