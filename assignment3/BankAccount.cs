using System;

namespace assignment3 {
    class BankAccount : ICloneable {
 
        public int AccountNumber { get; set; }
        public decimal Balance { get; protected set; }

        public void Deposit (decimal amount) {
         Balance = Balance + amount;
        }
        public void Withdraw (decimal amount) {
         Balance = Balance - amount;  
        }
        public decimal ReturnBalance () {
            return Balance;
        }

        public BankAccount (int accountNumber) {
            AccountNumber = accountNumber;
        }
        public object Clone () {
            return new BankAccount(AccountNumber);
        }

    //    public override bool Equals (object obj) {
    //        if ((obj == null) || !GetType ().Equals (obj.GetType ())) {
    //            return false;
    //        } else {
    //            BankAccount otherBalance = (BankAccount) obj;
    //            return (Balance == otherBalance.Balance);
    //        }

    //    }

    //    public override int GetHashCode () {
    //        return Balance.GetHashCode ();
    //    
    }
}