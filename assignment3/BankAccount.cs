using System;

namespace assignment3 {
    class BankAccount {
        /* Bank account feilds */
        public int AccountNumber { get; set; }
        public decimal Balance { get; protected set; }
        /* Varialbe with a static minimum deposit amount greater than 1 cent */
        protected decimal minimumDeposit =>.01m;
        /* Variable with a static minimum withdrawal amount greater than 1 cent */
        protected decimal minimumWithdrawal =>.01m;

        /* Method for a deposit transaction*/
        public void Deposit (decimal amount) {
            /* Assume deposit amount is zero if deposit amount is less than 1 cent */
            if (amount < minimumDeposit) {
                /* Add deposit amount of zero to account balance */
                Balance = Balance + 0;
            } else
                /* Add deposit amount to account balance */
                Balance = Balance + amount;
        }
        /* Method for a withdrawal transaction*/
        public void Withdraw (decimal amount) {
            /* Throw exception if the account balance is less than the amount to be withdrawn */
            if (Balance < amount) {
                throw new Exception (string.Format ("Withdrawal declined. You do not have enough money in your account"));
                /* Assume the withdrawal amount is zero if the withdrawal amount is less than 1 cent*/
            } else if (amount < minimumWithdrawal) {
                /* Substract withdrawal amount of zero from the account balance */
                Balance = Balance - 0;
            } else
                /* Subtract withdrawal amount from account balance */
                Balance = Balance - amount;
        }
        /* Method to return the account balance */
        public decimal checkBalance () {
            /* Returns the account balance */
            return Balance;
        }
        /* Contructor for a new bank account */
        public BankAccount (int accountNumber) {
            AccountNumber = accountNumber;
        }
        /* Method that allows the ability to clone an an object  */
        public BankAccount Clone () {
            /* Constructor for object cloning  */
            var obj = (BankAccount) this.MemberwiseClone ();
            /* Returns the cloned object  */
            return obj;
        }
        /* Overide for the Equals method to compare account balances between multiple constructed objects */
        public override bool Equals (object obj) {
            /* Define item as variable to represent the object */
            var item = obj as BankAccount;
            /* If object is null return false */
            if (item == null) {
                return false;
            }
            /* Otherwise compare objects balance */
            return this.Balance.Equals (item.Balance);
        }
        /* Override the GetHashCode method which is required to override the Equals method */
        public override int GetHashCode () {
            /* Return the balance in the overriden GetHashode method */
            return Balance.GetHashCode ();
        }
    }
}