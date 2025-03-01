namespace VisualBankAccount
{
    partial class Bank
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            totalMoney = new Label();
            userName = new Label();
            depositButton = new Button();
            withdrawButton = new Button();
            depositNumberButton = new NumericUpDown();
            withdrawNumberButton = new NumericUpDown();
            warningBank = new Label();
            backButton = new Button();
            ((System.ComponentModel.ISupportInitialize)depositNumberButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)withdrawNumberButton).BeginInit();
            SuspendLayout();
            // 
            // totalMoney
            // 
            totalMoney.AutoSize = true;
            totalMoney.Font = new Font("Segoe UI", 20F);
            totalMoney.Location = new Point(301, 137);
            totalMoney.Name = "totalMoney";
            totalMoney.Size = new Size(186, 54);
            totalMoney.TabIndex = 0;
            totalMoney.Text = "$1000.00";
            // 
            // userName
            // 
            userName.AutoSize = true;
            userName.Font = new Font("Segoe UI", 30F);
            userName.Location = new Point(67, 9);
            userName.Name = "userName";
            userName.Size = new Size(294, 81);
            userName.TabIndex = 1;
            userName.Text = "Welcome:";
            // 
            // depositButton
            // 
            depositButton.Location = new Point(224, 331);
            depositButton.Name = "depositButton";
            depositButton.Size = new Size(112, 34);
            depositButton.TabIndex = 2;
            depositButton.Text = "Deposit";
            depositButton.UseVisualStyleBackColor = true;
            depositButton.Click += depositButton_Click;
            // 
            // withdrawButton
            // 
            withdrawButton.Location = new Point(459, 331);
            withdrawButton.Name = "withdrawButton";
            withdrawButton.Size = new Size(112, 34);
            withdrawButton.TabIndex = 3;
            withdrawButton.Text = "Withdraw";
            withdrawButton.UseVisualStyleBackColor = true;
            withdrawButton.Click += withdrawButton_Click;
            // 
            // depositNumberButton
            // 
            depositNumberButton.DecimalPlaces = 2;
            depositNumberButton.Location = new Point(190, 294);
            depositNumberButton.Maximum = new decimal(new int[] { -1, -1, -1, 0 });
            depositNumberButton.Name = "depositNumberButton";
            depositNumberButton.Size = new Size(180, 31);
            depositNumberButton.TabIndex = 4;
            // 
            // withdrawNumberButton
            // 
            withdrawNumberButton.DecimalPlaces = 2;
            withdrawNumberButton.Location = new Point(429, 294);
            withdrawNumberButton.Maximum = new decimal(new int[] { -1, -1, -1, 0 });
            withdrawNumberButton.Name = "withdrawNumberButton";
            withdrawNumberButton.Size = new Size(180, 31);
            withdrawNumberButton.TabIndex = 5;
            // 
            // warningBank
            // 
            warningBank.Hide();
            warningBank.AutoSize = true;
            warningBank.ForeColor = Color.Red;
            warningBank.Location = new Point(294, 244);
            warningBank.Name = "warningBank";
            warningBank.Size = new Size(215, 25);
            warningBank.TabIndex = 6;
            warningBank.Text = "Please insert a valid value.";
            // 
            // backButton
            // 
            backButton.Location = new Point(346, 404);
            backButton.Name = "backButton";
            backButton.Size = new Size(112, 34);
            backButton.TabIndex = 7;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // Bank
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(backButton);
            Controls.Add(warningBank);
            Controls.Add(withdrawNumberButton);
            Controls.Add(depositNumberButton);
            Controls.Add(withdrawButton);
            Controls.Add(depositButton);
            Controls.Add(userName);
            Controls.Add(totalMoney);
            Name = "Bank";
            Text = "Banking";
            ((System.ComponentModel.ISupportInitialize)depositNumberButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)withdrawNumberButton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label totalMoney;
        private Label userName;
        private Button depositButton;
        private Button withdrawButton;
        private NumericUpDown depositNumberButton;
        private NumericUpDown withdrawNumberButton;
        private Label warningBank;
        private Button backButton;
    }
}