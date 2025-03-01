/*
Name: Visual Bank Account
Authors: Stephen, Lucas, Tony, and Silas
Date: 2/28/25
Purpose: Create a banking system using Winforms.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualBankAccount
{
    internal class BankManager
    {
        private decimal mTotal;

        public BankManager() 
        {
            
        }
        public BankManager(decimal amount) 
        {
            mTotal = amount;
        }
        public decimal Deposit(decimal amount) 
        {
            if (amount > 0) 
            {
                mTotal += amount;
                return mTotal;
            }
            else 
            {
                return -1;
            }
        }

        public decimal Withdraw(decimal amount) 
        {
            if (amount > 0 && amount <= mTotal) 
            {
                mTotal -= amount;
                return mTotal;
            }
            else 
            {
                return -1;
            }
        }
    }
}
