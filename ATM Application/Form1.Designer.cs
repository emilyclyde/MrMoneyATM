namespace ATM_Application
{
    partial class Form1
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.menuLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.accountlabel = new System.Windows.Forms.Label();
            this.PINLabel = new System.Windows.Forms.Label();
            this.accountTextBox = new System.Windows.Forms.TextBox();
            this.PINTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.checkBalanceButton = new System.Windows.Forms.Button();
            this.WithdrawalButton = new System.Windows.Forms.Button();
            this.depositButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.accessDeniedLabel = new System.Windows.Forms.Label();
            this.accountResultLabel = new System.Windows.Forms.Label();
            this.balanceResultLabel = new System.Windows.Forms.Label();
            this.depositWithdrawalLabel = new System.Windows.Forms.Label();
            this.depositWithdrawalTextBox = new System.Windows.Forms.TextBox();
            this.withdrawalEnterButton = new System.Windows.Forms.Button();
            this.depositEnterButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.balanceEnterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.welcomeLabel.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(70, 105);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(490, 39);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome to Mr. Money!";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuLabel
            // 
            this.menuLabel.AutoSize = true;
            this.menuLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuLabel.Location = new System.Drawing.Point(203, 56);
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.Size = new System.Drawing.Size(225, 23);
            this.menuLabel.TabIndex = 0;
            this.menuLabel.Text = "What would you like to do?";
            this.menuLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.Location = new System.Drawing.Point(142, 218);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(347, 23);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Please enter your account number and PIN";
            this.loginLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // accountlabel
            // 
            this.accountlabel.AutoSize = true;
            this.accountlabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountlabel.Location = new System.Drawing.Point(241, 259);
            this.accountlabel.Name = "accountlabel";
            this.accountlabel.Size = new System.Drawing.Size(149, 23);
            this.accountlabel.TabIndex = 0;
            this.accountlabel.Text = "Account Number:";
            this.accountlabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // PINLabel
            // 
            this.PINLabel.AutoSize = true;
            this.PINLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PINLabel.Location = new System.Drawing.Point(294, 313);
            this.PINLabel.Name = "PINLabel";
            this.PINLabel.Size = new System.Drawing.Size(43, 23);
            this.PINLabel.TabIndex = 0;
            this.PINLabel.Text = "PIN:";
            this.PINLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // accountTextBox
            // 
            this.accountTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountTextBox.Location = new System.Drawing.Point(182, 254);
            this.accountTextBox.Name = "accountTextBox";
            this.accountTextBox.Size = new System.Drawing.Size(266, 27);
            this.accountTextBox.TabIndex = 1;
            // 
            // PINTextBox
            // 
            this.PINTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PINTextBox.Location = new System.Drawing.Point(182, 313);
            this.PINTextBox.Name = "PINTextBox";
            this.PINTextBox.Size = new System.Drawing.Size(266, 27);
            this.PINTextBox.TabIndex = 1;
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(248, 388);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(134, 61);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Enter";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // checkBalanceButton
            // 
            this.checkBalanceButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBalanceButton.Location = new System.Drawing.Point(204, 98);
            this.checkBalanceButton.Name = "checkBalanceButton";
            this.checkBalanceButton.Size = new System.Drawing.Size(222, 46);
            this.checkBalanceButton.TabIndex = 3;
            this.checkBalanceButton.Text = "Check Balance";
            this.checkBalanceButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.checkBalanceButton.UseVisualStyleBackColor = true;
            this.checkBalanceButton.Click += new System.EventHandler(this.checkBalanceButton_Click);
            // 
            // WithdrawalButton
            // 
            this.WithdrawalButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WithdrawalButton.Location = new System.Drawing.Point(204, 159);
            this.WithdrawalButton.Name = "WithdrawalButton";
            this.WithdrawalButton.Size = new System.Drawing.Size(222, 46);
            this.WithdrawalButton.TabIndex = 3;
            this.WithdrawalButton.Text = "Make a Withdrawal";
            this.WithdrawalButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.WithdrawalButton.UseVisualStyleBackColor = true;
            this.WithdrawalButton.Click += new System.EventHandler(this.WithdrawalButton_Click);
            // 
            // depositButton
            // 
            this.depositButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositButton.Location = new System.Drawing.Point(204, 228);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(222, 46);
            this.depositButton.TabIndex = 3;
            this.depositButton.Text = "Deposit";
            this.depositButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.depositButton.UseVisualStyleBackColor = true;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(225, 159);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(180, 56);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // accessDeniedLabel
            // 
            this.accessDeniedLabel.AutoSize = true;
            this.accessDeniedLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accessDeniedLabel.ForeColor = System.Drawing.Color.Red;
            this.accessDeniedLabel.Location = new System.Drawing.Point(206, 343);
            this.accessDeniedLabel.Name = "accessDeniedLabel";
            this.accessDeniedLabel.Size = new System.Drawing.Size(218, 26);
            this.accessDeniedLabel.TabIndex = 5;
            this.accessDeniedLabel.Text = "*** ACCESS DENIED ***";
            this.accessDeniedLabel.Visible = false;
            // 
            // accountResultLabel
            // 
            this.accountResultLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountResultLabel.ForeColor = System.Drawing.Color.Blue;
            this.accountResultLabel.Location = new System.Drawing.Point(50, 117);
            this.accountResultLabel.Name = "accountResultLabel";
            this.accountResultLabel.Size = new System.Drawing.Size(530, 39);
            this.accountResultLabel.TabIndex = 6;
            this.accountResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.accountResultLabel.Visible = false;
            // 
            // balanceResultLabel
            // 
            this.balanceResultLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceResultLabel.ForeColor = System.Drawing.Color.Blue;
            this.balanceResultLabel.Location = new System.Drawing.Point(27, 169);
            this.balanceResultLabel.Name = "balanceResultLabel";
            this.balanceResultLabel.Size = new System.Drawing.Size(576, 39);
            this.balanceResultLabel.TabIndex = 6;
            this.balanceResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.balanceResultLabel.Visible = false;
            this.balanceResultLabel.Click += new System.EventHandler(this.balanceResultLabel_Click);
            // 
            // depositWithdrawalLabel
            // 
            this.depositWithdrawalLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositWithdrawalLabel.Location = new System.Drawing.Point(95, 204);
            this.depositWithdrawalLabel.Name = "depositWithdrawalLabel";
            this.depositWithdrawalLabel.Size = new System.Drawing.Size(441, 37);
            this.depositWithdrawalLabel.TabIndex = 7;
            this.depositWithdrawalLabel.Text = "DepositWithdrawl";
            this.depositWithdrawalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // depositWithdrawalTextBox
            // 
            this.depositWithdrawalTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositWithdrawalTextBox.Location = new System.Drawing.Point(193, 254);
            this.depositWithdrawalTextBox.Name = "depositWithdrawalTextBox";
            this.depositWithdrawalTextBox.Size = new System.Drawing.Size(245, 27);
            this.depositWithdrawalTextBox.TabIndex = 8;
            // 
            // withdrawalEnterButton
            // 
            this.withdrawalEnterButton.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrawalEnterButton.Location = new System.Drawing.Point(248, 311);
            this.withdrawalEnterButton.Name = "withdrawalEnterButton";
            this.withdrawalEnterButton.Size = new System.Drawing.Size(134, 58);
            this.withdrawalEnterButton.TabIndex = 9;
            this.withdrawalEnterButton.Text = " Enter";
            this.withdrawalEnterButton.UseVisualStyleBackColor = true;
            this.withdrawalEnterButton.Click += new System.EventHandler(this.withdrawalEnterButton_Click);
            // 
            // depositEnterButton
            // 
            this.depositEnterButton.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositEnterButton.Location = new System.Drawing.Point(248, 313);
            this.depositEnterButton.Name = "depositEnterButton";
            this.depositEnterButton.Size = new System.Drawing.Size(134, 58);
            this.depositEnterButton.TabIndex = 9;
            this.depositEnterButton.Text = " Enter";
            this.depositEnterButton.UseVisualStyleBackColor = true;
            this.depositEnterButton.Click += new System.EventHandler(this.depositEnterButton_Click_1);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(239, 299);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(152, 37);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // balanceEnterButton
            // 
            this.balanceEnterButton.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceEnterButton.Location = new System.Drawing.Point(248, 239);
            this.balanceEnterButton.Name = "balanceEnterButton";
            this.balanceEnterButton.Size = new System.Drawing.Size(134, 57);
            this.balanceEnterButton.TabIndex = 11;
            this.balanceEnterButton.Text = "OK";
            this.balanceEnterButton.UseVisualStyleBackColor = true;
            this.balanceEnterButton.Click += new System.EventHandler(this.balanceEnterButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 582);
            this.Controls.Add(this.balanceEnterButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.depositEnterButton);
            this.Controls.Add(this.withdrawalEnterButton);
            this.Controls.Add(this.depositWithdrawalTextBox);
            this.Controls.Add(this.depositWithdrawalLabel);
            this.Controls.Add(this.balanceResultLabel);
            this.Controls.Add(this.accountResultLabel);
            this.Controls.Add(this.accessDeniedLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.depositButton);
            this.Controls.Add(this.WithdrawalButton);
            this.Controls.Add(this.checkBalanceButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.PINTextBox);
            this.Controls.Add(this.accountTextBox);
            this.Controls.Add(this.PINLabel);
            this.Controls.Add(this.accountlabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.menuLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "Form1";
            this.Text = "Mr.Money";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label menuLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label accountlabel;
        private System.Windows.Forms.Label PINLabel;
        private System.Windows.Forms.TextBox accountTextBox;
        private System.Windows.Forms.TextBox PINTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button checkBalanceButton;
        private System.Windows.Forms.Button WithdrawalButton;
        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label accessDeniedLabel;
        private System.Windows.Forms.Label accountResultLabel;
        private System.Windows.Forms.Label balanceResultLabel;
        private System.Windows.Forms.Label depositWithdrawalLabel;
        private System.Windows.Forms.TextBox depositWithdrawalTextBox;
        private System.Windows.Forms.Button withdrawalEnterButton;
        private System.Windows.Forms.Button depositEnterButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button balanceEnterButton;
    }
}

