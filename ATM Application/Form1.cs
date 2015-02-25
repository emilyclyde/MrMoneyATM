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
    List<Account> accounts = new List<Account>();
    Account thisAccount = new Account();
    List<Customer> customers = new List<Customer>();
    Customer thisCustomer = new Customer();

    public Form1()
    {
      InitializeComponent();
    }


    private void HideWelcome()
    {
      welcomeLabel.Visible = false;
      startButton.Visible = false;
    }

    private void ShowWelcome()
    {
      welcomeLabel.Visible = true;
      startButton.Visible = true;
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
      exitButton.Visible = true;
    }

    private void HideMenu()
    {
      menuLabel.Visible = false;
      checkBalanceButton.Visible = false;
      WithdrawalButton.Visible = false;
      depositButton.Visible = false;
      exitButton.Visible = false;
    }

    private void ShowAccountLabels()
    {
      accountResultLabel.Visible = true;
      balanceResultLabel.Visible = true;
      balanceEnterButton.Visible = true;
    }

    private void ShowDepositWithdrawal()
    {
      withdrawalEnterButton.Visible = true;
      depositEnterButton.Visible = true;
      depositWithdrawalLabel.Visible = true;
      depositWithdrawalTextBox.Visible = true;
    }

    private void HideDepositWithdrawal()
    {
      withdrawalEnterButton.Visible = false;
      depositEnterButton.Visible = false;
      depositWithdrawalLabel.Visible = false;
      depositWithdrawalTextBox.Visible = false;
    }
    private void HideAccountLabels()
    {
      accountResultLabel.Visible = false;
      balanceResultLabel.Visible = false;
      balanceEnterButton.Visible = false;
    }


    private void loginButton_Click(object sender, EventArgs e)
    {
      HideLogin();
      bool pINMatch;
      bool accountMatch;
      bool loginPassed = false;

      //*** place login code here *********

      foreach (Customer c in customers)
      {
        pINMatch = c.IsPinMatch(int.Parse(PINTextBox.Text));
        accountMatch = c.IsAccountNumMatch(int.Parse(accountTextBox.Text));

        if (pINMatch && accountMatch)
        {

          foreach (Account a in accounts)
            if (c.AccountNumber == a.AccountNumber)
              thisAccount = a;
          loginPassed = true;
        }
      }
      //loginPassed = true; //for testing only remove
      if (loginPassed)
      {
        HideLogin();
        ShowMenu();
        accessDeniedLabel.Visible = false;
      }
      else
      {
        accountTextBox.Text = "";
        PINTextBox.Text = "";
        ShowLogin();
        accessDeniedLabel.Visible = true;
      }

    }

    private void checkBalanceButton_Click(object sender, EventArgs e)
    {
      HideMenu();
      //*** place Check Balance code here *********

      ShowAccountLabels();

      accountResultLabel.Text = "The Balance for Account " + thisAccount.AccountNumber.ToString();
      balanceResultLabel.Text = "is : $" + thisAccount.ShowBalance();
    }

    private void WithdrawalButton_Click(object sender, EventArgs e)
    {
      HideMenu();
      ShowDepositWithdrawal();
      depositEnterButton.Visible = false;
      depositWithdrawalLabel.Text = "Enter the amount you want to withdrawl.";
      depositWithdrawalTextBox.Text = "";

    }

    private void depositButton_Click(object sender, EventArgs e)
    {
      HideMenu();
      ShowDepositWithdrawal();
      depositWithdrawalTextBox.Text = "";
      withdrawalEnterButton.Visible = false;
      depositWithdrawalLabel.Text = "Enter the amount you want to Deposit.";

      //*** place Deposit code here *********
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      HideLogin();
      HideMenu();
      HideAccountLabels();
      HideDepositWithdrawal();
      ShowWelcome();

    }


    private void MrMoneyInitializer()
    {
      Account account1 = new Account();
      account1.AccountNumber = 12345;
      account1.Balance = 1000.00m;
      accounts.Add(account1);

      Account account2 = new Account();
      account2.AccountNumber = 54321;
      account2.Balance = 300.50m;
      accounts.Add(account2);

      Account account3 = new Account();
      account3.AccountNumber = 11111;
      account3.Balance = 23700.00m;
      accounts.Add(account3);

      Account account4 = new Account();
      account4.AccountNumber = 22222;
      account4.Balance = 1000.00m;
      accounts.Add(account4);

      Account account5 = new Account();
      account5.AccountNumber = 333333;
      account5.Balance = 7720.00m;
      accounts.Add(account5);

      Account account6 = new Account();
      account6.AccountNumber = 44444;
      account6.Balance = 10.80m;
      accounts.Add(account6);

      Account account7 = new Account();
      account7.AccountNumber = 55555;
      account7.Balance = 273.00m;
      accounts.Add(account7);



      Customer customer1 = new Customer();
      customer1.CustomerID = 1;
      customer1.AccountNumber = 12345;
      customer1.PIN = 1234;
      customers.Add(customer1);

      Customer customer2 = new Customer();
      customer2.CustomerID = 1;
      customer2.AccountNumber = 12345;
      customer2.PIN = 1122;
      customers.Add(customer2);

      Customer customer3 = new Customer();
      customer3.CustomerID = 1;
      customer3.AccountNumber = 54321;
      customer3.PIN = 2233;
      customers.Add(customer3);

      Customer customer4 = new Customer();
      customer4.CustomerID = 1;
      customer4.AccountNumber = 11111;
      customer4.PIN = 7899;
      customers.Add(customer4);

      Customer customer5 = new Customer();
      customer5.CustomerID = 1;
      customer5.AccountNumber = 22222;
      customer5.PIN = 2223;
      customers.Add(customer5);

      Customer customer6 = new Customer();
      customer6.CustomerID = 1;
      customer6.AccountNumber = 22222;
      customer6.PIN = 0007;
      customers.Add(customer6);

      Customer customer7 = new Customer();
      customer7.CustomerID = 1;
      customer7.AccountNumber = 33333;
      customer7.PIN = 2222;
      customers.Add(customer7);

      Customer customer8 = new Customer();
      customer8.CustomerID = 1;
      customer8.AccountNumber = 33333;
      customer8.PIN = 5671;
      customers.Add(customer8);

      Customer customer9 = new Customer();
      customer9.CustomerID = 1;
      customer9.AccountNumber = 33333;
      customer9.PIN = 7443;
      customers.Add(customer9);

      Customer customer10 = new Customer();
      customer10.CustomerID = 1;
      customer10.AccountNumber = 44444;
      customer10.PIN = 3748;
      customers.Add(customer10);

      Customer customer11 = new Customer();
      customer11.CustomerID = 1;
      customer11.AccountNumber = 55555;
      customer11.PIN = 7373;
      customers.Add(customer11);



    }

    private void startButton_Click(object sender, EventArgs e)
    {
      MrMoneyInitializer();
      HideWelcome();
      ShowLogin();
    }

    private void depositEnterButton_Click(object sender, EventArgs e)
    {

      thisAccount.AddToBalance(decimal.Parse(depositWithdrawalTextBox.Text));
      HideDepositWithdrawal();
      depositWithdrawalLabel.Visible = true;
      depositWithdrawalLabel.Text = "Your new Account Balance for" + thisAccount.AccountNumber.ToString() + "is : $" + thisAccount.Balance.ToString();

      //menuEnterButton.Visible = true;

    }

    private void exitButton_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void balanceEnterButton_Click(object sender, EventArgs e)
    {
      ShowMenu();
      HideAccountLabels();

    }

    private void depositEnterButton_Click_1(object sender, EventArgs e)
    {
      decimal DepositAmount = 0;
      try
      {
         DepositAmount = decimal.Parse(depositWithdrawalTextBox.Text);
      }
      catch
      {
        MessageBox.Show("Enter a valid number");
        depositWithdrawalTextBox.Text = "";
        return;
      }
      HideDepositWithdrawal();


      thisAccount.AddToBalance(DepositAmount);
      accountResultLabel.Text = " After Depositing $" + DepositAmount;
      balanceResultLabel.Text = "Your new Ballance for Account:" + thisAccount.AccountNumber + " is $" + thisAccount.Balance;
      ShowAccountLabels();
    }


    private void withdrawalEnterButton_Click(object sender, EventArgs e)
    {
      decimal WithdrawalAmount=0;

      try
      {
        WithdrawalAmount = decimal.Parse(depositWithdrawalTextBox.Text);
      }
      catch
      {
        MessageBox.Show("Enter a valid number");
        depositWithdrawalTextBox.Text = "";
        return;
      }


      HideDepositWithdrawal();
     
        if (WithdrawalAmount > thisAccount.Balance)
        {
          accountResultLabel.Text = " Insufficient Funds ";
          balanceResultLabel.Text = "Your Ballance for Account:" + thisAccount.AccountNumber + " is only $" + thisAccount.Balance;

          ShowAccountLabels();
        }
        else
        {
          thisAccount.SubFromBalance(WithdrawalAmount);
          accountResultLabel.Text = " After Withdrawaling $" + WithdrawalAmount;
          balanceResultLabel.Text = "Your new Ballance for Account:" + thisAccount.AccountNumber + " is $" + thisAccount.Balance;
          ShowAccountLabels();
        }
      }
     
    

    private void balanceResultLabel_Click(object sender, EventArgs e)
    {

    }
  }
}
