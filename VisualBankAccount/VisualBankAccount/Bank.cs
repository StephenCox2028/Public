/*
Name: Visual Bank Account
Authors: Stephen, Lucas, Tony, and Silas
Date: 2/28/25
Purpose: Create a banking system using Winforms.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VisualBankAccount
{
    public partial class Bank : Form
    {
        private string firstName;
        private string lastName;
        BankManager manage = new BankManager(1000);
        public Bank(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            InitializeComponent();
            userName.Text = "Welcome: " + firstName + " " + lastName;
            depositNumberButton.BackColor = Color.White;
            withdrawButton.BackColor = Color.White;
            warningBank.Hide();
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            decimal depositAmount = Convert.ToDecimal(depositNumberButton.Text);
            decimal total = manage.Deposit(depositAmount);
            if (total != -1)
            {
                totalMoney.Text = "$" + total;
                warningBank.Hide();
                depositNumberButton.BackColor = Color.White;
            }
            else
            {
                depositNumberButton.BackColor = Color.Red;
                warningBank.Show();
            }
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            decimal withdrawAmount = Convert.ToDecimal(withdrawNumberButton.Text);
            decimal total = manage.Withdraw(withdrawAmount);
            if (total != -1)
            {
                totalMoney.Text = "$" + total;
                warningBank.Hide();
                withdrawNumberButton.BackColor = Color.White;
            }
            else
            {
                withdrawNumberButton.BackColor = Color.Red;
                warningBank.Show();
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            BankAccount SignIn = new BankAccount();
            SignIn.Show();
        }
    }
}
