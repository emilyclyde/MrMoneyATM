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
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.welcomeLabel.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(194, 43);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(338, 39);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome to Mr. Money!";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.welcomeLabel.Click += new System.EventHandler(this.welcomeLabel_Click);
            // 
            // menuLabel
            // 
            this.menuLabel.AutoSize = true;
            this.menuLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuLabel.Location = new System.Drawing.Point(249, 147);
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
            this.loginLabel.Location = new System.Drawing.Point(185, 124);
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
            this.accountlabel.Location = new System.Drawing.Point(70, 230);
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
            this.PINLabel.Location = new System.Drawing.Point(176, 284);
            this.PINLabel.Name = "PINLabel";
            this.PINLabel.Size = new System.Drawing.Size(43, 23);
            this.PINLabel.TabIndex = 0;
            this.PINLabel.Text = "PIN:";
            this.PINLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // accountTextBox
            // 
            this.accountTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountTextBox.Location = new System.Drawing.Point(244, 225);
            this.accountTextBox.Name = "accountTextBox";
            this.accountTextBox.Size = new System.Drawing.Size(269, 27);
            this.accountTextBox.TabIndex = 1;
            // 
            // PINTextBox
            // 
            this.PINTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PINTextBox.Location = new System.Drawing.Point(243, 284);
            this.PINTextBox.Name = "PINTextBox";
            this.PINTextBox.Size = new System.Drawing.Size(269, 27);
            this.PINTextBox.TabIndex = 1;
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(300, 359);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(137, 61);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Enter";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // checkBalanceButton
            // 
            this.checkBalanceButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBalanceButton.Location = new System.Drawing.Point(253, 199);
            this.checkBalanceButton.Name = "checkBalanceButton";
            this.checkBalanceButton.Size = new System.Drawing.Size(225, 46);
            this.checkBalanceButton.TabIndex = 3;
            this.checkBalanceButton.Text = "Check Balance";
            this.checkBalanceButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.checkBalanceButton.UseVisualStyleBackColor = true;
            this.checkBalanceButton.Click += new System.EventHandler(this.checkBalanceButton_Click);
            // 
            // WithdrawalButton
            // 
            this.WithdrawalButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WithdrawalButton.Location = new System.Drawing.Point(253, 265);
            this.WithdrawalButton.Name = "WithdrawalButton";
            this.WithdrawalButton.Size = new System.Drawing.Size(225, 46);
            this.WithdrawalButton.TabIndex = 3;
            this.WithdrawalButton.Text = "Make a Withdrawal";
            this.WithdrawalButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.WithdrawalButton.UseVisualStyleBackColor = true;
            this.WithdrawalButton.Click += new System.EventHandler(this.WithdrawalButton_Click);
            // 
            // depositButton
            // 
            this.depositButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositButton.Location = new System.Drawing.Point(253, 328);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(225, 46);
            this.depositButton.TabIndex = 3;
            this.depositButton.Text = "Deposit";
            this.depositButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.depositButton.UseVisualStyleBackColor = true;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 582);
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
    }
}

