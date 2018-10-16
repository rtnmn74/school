using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics.Contracts;

namespace assignment3
{
    class BankAccount
    {
        /* Bank account feilds */
        public int AccountNumber { get; set; }
        public decimal Balance { get; protected set; }

        /* Varialbe with a static minimum deposit amount greater than 1 cent */
        /* protected decimal minimumDeposit =>.01m;
         /* Variable with a static minimum withdrawal amount greater than 1 cent */
        /* protected decimal minimumWithdrawal =>.01m;


        /* Method for a deposit transaction*/
        public void Deposit(decimal amount)
        {
            /* Require deposit amount to be more than zero */
            Contract.Requires(amount > 0.00m);
            /* Add deposit amount to account balance to become the new account balance */
            Balance = Balance + amount;
            Contract.Ensures(Balance == Contract.OldValue(Balance) + amount);
        }
        /* Method for a withdrawal transaction*/
        public void Withdraw(decimal amount)
        {
            /* Throw exception if the account balance is less than the amount to be withdrawn */

            /* Require withdrawal amount to be more than zero */
            Contract.Requires(amount > 0.00m);
            Contract.Requires(amount < Balance);
            Balance = Balance - amount;
            /* Substract withdrawal amount of zero from the account balance */
            Contract.Ensures(Balance == Contract.OldValue(Balance) - amount);
            /* Subtract withdrawal amount from account balance to become the new account balance*/

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
            /* Define item as variable to represent the object */
            var item = obj as BankAccount;
            /* If object is null return false */
            if (item == null)
            {
                return false;
            }
            /* Otherwise compare objects balance */
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
