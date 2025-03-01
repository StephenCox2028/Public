namespace VisualBankAccount
{
    partial class BankAccount
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            titleLabel = new Label();
            firstNameTypeBox = new TextBox();
            lastNameLabel = new Label();
            firstNameLabel = new Label();
            lastNameTypeBox = new TextBox();
            nextButton = new Button();
            warningLabel = new Label();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 20F);
            titleLabel.Location = new Point(154, 59);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(515, 54);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Welcome to SNHU Banking!";
            // 
            // firstNameTypeBox
            // 
            firstNameTypeBox.Font = new Font("Segoe UI", 12F);
            firstNameTypeBox.Location = new Point(156, 209);
            firstNameTypeBox.Name = "firstNameTypeBox";
            firstNameTypeBox.Size = new Size(511, 39);
            firstNameTypeBox.TabIndex = 1;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI", 15F);
            lastNameLabel.Location = new Point(158, 253);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(164, 41);
            lastNameLabel.TabIndex = 2;
            lastNameLabel.Text = "Last Name:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Segoe UI", 15F);
            firstNameLabel.Location = new Point(156, 158);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(167, 41);
            firstNameLabel.TabIndex = 2;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameTypeBox
            // 
            lastNameTypeBox.Font = new Font("Segoe UI", 12F);
            lastNameTypeBox.Location = new Point(158, 301);
            lastNameTypeBox.Name = "lastNameTypeBox";
            lastNameTypeBox.Size = new Size(511, 39);
            lastNameTypeBox.TabIndex = 3;
            // 
            // nextButton
            // 
            nextButton.Location = new Point(350, 404);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(112, 34);
            nextButton.TabIndex = 4;
            nextButton.Text = "Next";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // warningLabel
            // 
            warningLabel.AutoSize = true;
            warningLabel.Location = new Point(301, 113);
            warningLabel.Name = "warningLabel";
            warningLabel.Size = new Size(218, 25);
            warningLabel.TabIndex = 5;
            warningLabel.Text = "Please fill in all credentials.";
            // 
            // BankAccount
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(warningLabel);
            Controls.Add(nextButton);
            Controls.Add(lastNameTypeBox);
            Controls.Add(firstNameLabel);
            Controls.Add(lastNameLabel);
            Controls.Add(firstNameTypeBox);
            Controls.Add(titleLabel);
            Name = "BankAccount";
            Text = "Sign In";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private TextBox firstNameTypeBox;
        private Label lastNameLabel;
        private Label firstNameLabel;
        private TextBox lastNameTypeBox;
        private Button nextButton;
        private Label warningLabel;
    }
}
