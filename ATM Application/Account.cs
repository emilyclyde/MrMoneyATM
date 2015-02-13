using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_Application
{
  class Account
  {
    public int AccountNumber { get; set; }
    public decimal Balance { get; set; }

    
    public decimal ShowBalance()
    {
      return Balance;
    }

    public void AddToBalance(decimal money)
    {
      Balance += money;
    }

    public void SubFromBalance(decimal money)
    {
      if (money > Balance)
      {
        MessageBox.Show("Sorry insufficient funds!");
      }
      else
      {
        Balance -= money;
      }

    }
  }
}
