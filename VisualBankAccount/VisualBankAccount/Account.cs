using System;
using System.Collections.Generic;
using System.Linq;
/*
Name: Visual Bank Account
Authors: Stephen, Lucas, Tony, and Silas
Date: 2/28/25
Purpose: Create a banking system using Winforms.
 */

using System.Text;
using System.Threading.Tasks;

namespace VisualBankAccount
{
    internal class Account
    {
        private string mFirstName;
        private string mLastName;
        public Account() 
        {
            
        }
        public Account(string firstName, string lastName)
        {
            mFirstName = firstName;
            mLastName = lastName;
        }
        public bool signIn()
        {
            if ((mFirstName == null || mFirstName == "") || (mLastName == null || mLastName == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private string getFirstName() { return mFirstName; }
        private string getLastName() { return mLastName; }
    }
}
