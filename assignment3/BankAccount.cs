using System;

namespace assignment3 {
    class BankAccount {

        public int AccountNumber { get; set; }
        public decimal Balance { get; protected set; }

        public void Deposit (decimal amount) {
            Balance = Balance + amount;
        }
        public void Withdraw (decimal amount) {
            if(Balance < amount)
            {
            throw new Exception(string.Format("You do not have enough money in your account"));
        }
            Balance = Balance - amount;
            
        }
        public decimal checkBalance () {
            return Balance;
        }

        public BankAccount (int accountNumber) {
            AccountNumber = accountNumber;
        }
        public BankAccount Clone () {
            var obj = (BankAccount) this.MemberwiseClone ();
            return obj;
        }

        public override bool Equals (object obj) {
            var item = obj as BankAccount;

            if (item == null) {
                return false;
            }
            return this.Balance.Equals (item.Balance);
        }

        public override int GetHashCode () {
            return Balance.GetHashCode ();
        }
    }
}