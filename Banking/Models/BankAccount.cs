using System;
using System.Collections.Generic;
using System.Text;

namespace Banking.Models
{
    public class BankAccount 
    {
        #region Fields

        private string _accountNumber;
        //private decimal _balance;
       

        #endregion

        #region Properties
        public decimal Balance { get; private set; }

        

        public string AccountNumber
        {
            get { return _accountNumber; }
            private set { _accountNumber = value; }
        }

        
        #endregion


        #region Constructor
        public BankAccount(string account)
        {
            AccountNumber = account;
            Balance = Decimal.Zero;
            
        }
        #endregion

        #region Methods
        public void Deposit(decimal amount)
        {
            Balance += amount;
            
        }

        public void Withdraw(decimal amount)
        {
            Balance -= amount;
            
        }

       
        #endregion

    }
}
