using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Bankkonto
{
    public class BankAccount
    {
        #region Fields
        private string name;
        private double balance;
        private bool locked;
        #endregion

        #region Properties
        public string Name {
            get { return name; }
            set { name = value; } 
        }

        public double Balance
        {
            get { return balance; }
        }
        #endregion

        #region Constructors
        public BankAccount(double balance)
        {
            this.balance = balance;
        }

        public BankAccount(string name, double balance)
        {
            this.name = name;
            this.balance = balance;
        }

        public BankAccount(string name, double balance, bool locked)
        {
            this.name = name;
            this.balance = balance;
            this.locked = locked;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Deposit money to bank account.
        /// </summary>
        /// <param name="amount">The amount of money being deposited.</param>
        public void Deposit(double amount)
        {
            if (!locked)
            {
                balance += amount;
                TransactionLog(actionDeposit: true, actionSuccess: true, amount: amount);
            } else
            {

                TransactionLog(actionDeposit: true, actionSuccess: false, amount: amount);
            }
        }

        /// <summary>
        /// Withdraw money from bank account. Checks if account has enough money to withdraw.
        /// </summary>
        /// <param name="amount">The amount of money the user wants to withdraw.</param>
        public void Withdraw(double amount)
        {
            if (!locked && balance >= amount)
            {
                balance -= amount;
                TransactionLog(actionDeposit: false, actionSuccess: true, amount: amount);
            } else
            {

                TransactionLog(actionDeposit: false, actionSuccess: false, amount: amount);
            }
        }

        /// <summary>
        /// Changes the value of locked, depending on what it was before.
        /// </summary>
        public void ChangeLockState()
        {
            // Set the value of locked, to either true or false, dependent on whatever it currently is.
            this.locked = locked ? locked = false : locked = true;
        }

        /// <summary>
        /// Get the values of the class in a string based information.
        /// </summary>
        /// <returns>Name of person associated, and the current balance.</returns>
        public override string ToString()
        {
            return "Name: "+ Name +", Balance: " + Balance;
        }

        /// <summary>
        /// Returns the current balance.
        /// </summary>
        /// <returns></returns>
        public double CheckBalance()
        {
            return Balance;
        }

        public void TransactionLog(bool actionDeposit, bool actionSuccess, double amount)
        {
            const string PATH_TO_TLOG = "transactionlog.txt";
            StreamWriter sw = new StreamWriter(PATH_TO_TLOG, true);
            
            // If user tried to deposit.
            if(actionDeposit)
            {
                sw.WriteLine("{1} - Deposit: {0}.", amount, this.name);
            } else
            { // User tried to withdraw

                if(actionSuccess)
                {
                    sw.WriteLine("{1} - Withdraw: {0}. Success.", amount, this.name);
                } else
                {
                    sw.WriteLine("{1} - Withdraw: {0}. Fail.", amount, this.name);
                }
            }

            sw.Close();
        }
        #endregion


    }
}
