using System;

namespace assignment3 {
    class BankAccount : ICloneable {
        private int accountNumber;
        private decimal balance;
        private decimal depositAmount;
        private decimal withdrawalAmount;

        public int AccountNumber { get => accountNumber; set => accountNumber = value; }
        public decimal Balance { get => balance; set => balance = value; }
        public decimal DepositAmount { get => depositAmount; set => depositAmount = value; }
        public decimal WithdrawalAmount { get => withdrawalAmount; set => withdrawalAmount = value; }

        public decimal Deposit (decimal depositAmount) {

            return Balance += depositAmount;
        }

        public decimal Withdrawal (decimal withdrawlAmount) {

            return Balance -= withdrawlAmount;
        }

        public decimal CheckingBalance (decimal depositAmount, decimal withdrawalAmount) {
            return Balance + depositAmount - withdrawalAmount;
        }

        public BankAccount (int number, decimal depositAmount, decimal withdrawalAmount) {
            this.AccountNumber = number;
            Deposit (depositAmount);
            Withdrawal (withdrawalAmount);
            CheckingBalance (depositAmount, withdrawalAmount);

        }

        public object Clone () {
            return new BankAccount (this.AccountNumber, this.depositAmount, this.withdrawalAmount);
        }

        public override bool Equals (object obj) {
            if ((obj == null) || !this.GetType ().Equals (obj.GetType ())) {
                return false;
            } else {
                BankAccount otherBalance = (BankAccount) obj;
                return (balance == otherBalance.balance);
            }

        }

        public override int GetHashCode () {
            return this.balance.GetHashCode ();
        }
    }
}