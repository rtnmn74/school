using System;
using System.Diagnostics.Contracts;

namespace assignment3
{
    class BankAccount
    {
        /* Bank account feilds */
        public int AccountNumber { get; set; }
        public decimal Balance { get; protected set; }

        /* Method for a deposit transaction*/
        public decimal Deposit(decimal amount)
        {
            /* Precondition - Require deposit amount to be more than zero */
            Contract.Requires<ArgumentException>(amount > 0.00m, "Deposit must be greater than zero");
            /* Postcondition - Ensures the method returns a balance greater than or equal to zero */
            Contract.Ensures(Balance >= 0.00m);
            /* Postcondition - Ensures the method returns the Balance plus the amount */
            Contract.Ensures(Balance == Contract.OldValue(Balance) + amount);
            /* Add deposit amount to account balance to become the new account balance */
            Balance += amount;
            /* Return the new balance */
            return Balance;
        }

        /* Method for a withdrawal transaction*/
        public decimal Withdraw(decimal amount)
        {
            /* Precondition - Requires withdrawal amount to be more than account balance */
            Contract.Requires<ArgumentException>(amount < Balance, "Withdrawal can not be more than the balance");
            /* Precondition - Requires withdrawal amount to be more than zero */
            Contract.Requires<ArgumentException>(amount > 0.00m, "Withdrawal must be greater than zero");
            /* Postcondition - Ensures the method returns a balance greater that or equal to zero */
            Contract.Ensures(Balance >= 0.00m);
            /* Postcondition - Ensures the method returns the Balance minus the amount */
            Contract.Ensures(Balance == Contract.OldValue(Balance) - amount);
            /* Subtract withdrawal amount from account balance to become the new account balance*/
            Balance -= amount;
            /* Return the new Balance */
            return Balance;
        }

        /* Method to return the account balance */
        public decimal checkBalance()
        {
            /* Returns the account balance */
            return Balance;
        }
        /* Contructor for a new bank account */
        public BankAccount(int accountNumber)
        {
            /*Input accountNumber interger into AccountNumber field */
            AccountNumber = accountNumber;
        }
        /* Method that allows the ability to clone an an object  */
        public BankAccount Clone()
        {
            /* Constructor for object cloning  */
            var obj = (BankAccount)this.MemberwiseClone();
            /* Returns the cloned object  */
            return obj;
        }
        /* Overide for the Equals method to compare account balances between multiple constructed objects */
        public override bool Equals(object obj)
        {
            /* Precondition - Requires the object to not be null */
            Contract.Requires(obj != null);
            /* Define item as variable to represent the object */
            var item = obj as BankAccount;
            /* Return the balance comparison of the 2 objects */
            return this.Balance.Equals(item.Balance);
        }
        /* Override the GetHashCode method which is required to override the Equals method */
        public override int GetHashCode()
        {
            /* Return the balance in the overriden GetHashode method */
            return Balance.GetHashCode();
        }
    }
}
