/*
Name: Visual Bank Account
Authors: Stephen, Lucas, Tony, and Silas
Date: 2/28/25
Purpose: Create a banking system using Winforms.
 */

namespace VisualBankAccount
{
    public partial class BankAccount : Form
    {
        bool firstNameTyped = false;
        bool lastNameTyped = false;

        public BankAccount()
        {
            InitializeComponent();
            warningLabel.Hide();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                Next();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            Next();
        }

        private void Next()
        {
            firstNameTypeBox.BackColor = Color.White;
            lastNameTypeBox.BackColor = Color.White;
            string firstName = firstNameTypeBox.Text;
            string lastName = lastNameTypeBox.Text;
            Account account = new Account(firstName, lastName);
            bool signedIn = account.signIn();
            if (signedIn)
            {
                this.Hide();
                Bank bank = new Bank(firstName, lastName);
                bank.Show();
            }
            else
            {
                if (firstNameTypeBox.Text.Length <= 0)
                {
                    warningLabel.Show();
                    firstNameTypeBox.BackColor = Color.Red;
                }
                if (lastNameTypeBox.Text.Length <= 0)
                {
                    warningLabel.Show();
                    lastNameTypeBox.BackColor = Color.Red;
                }
            }
        }
    }
}
