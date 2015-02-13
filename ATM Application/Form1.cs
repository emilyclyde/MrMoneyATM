using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ATM_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void welcomeLabel_Click(object sender, EventArgs e)
        {

        }

        private void ShowLogin()
        {
            loginLabel.Visible = true;
            accountlabel.Visible = true;
            PINLabel.Visible = true;
            accountTextBox.Visible = true;
            PINTextBox.Visible = true;
            loginButton.Visible = true;
        }

        private void HideLogin()
        {
            loginLabel.Visible = false;
            accountlabel.Visible = false;
            PINLabel.Visible = false;
            accountTextBox.Visible = false;
            PINTextBox.Visible = false;
            loginButton.Visible = false;
        }

        private void ShowMenu()
        {
            menuLabel.Visible = true;
            checkBalanceButton.Visible = true;
            WithdrawalButton.Visible = true;
            depositButton.Visible = true;
        }

        private void HideMenu()
        {
            menuLabel.Visible = false;
            checkBalanceButton.Visible = false;
            WithdrawalButton.Visible = false;
            depositButton.Visible = false;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            HideLogin();

            //*** place login code here *********
        }

        private void checkBalanceButton_Click(object sender, EventArgs e)
        {
            HideMenu();
            welcomeLabel.Text = "Check Balance";

            //*** place Check Balance code here *********
        }

        private void WithdrawalButton_Click(object sender, EventArgs e)
        {
            HideMenu();
            welcomeLabel.Text = "Withdrawl";

            //*** place Withdrawal code here *********
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            HideMenu();
            welcomeLabel.Text = "Deposit";

            //*** place Deposit code here *********
        }

      private void addToBalance(int account, int money)
        {
          

        }
    }
}
