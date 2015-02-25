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


        public int ShowAccountNum()
        {
            return AccountNumber;
        }
        public decimal ShowBalance()
        {
            return Balance;
        }
        public void AddToBalance(decimal money)
        {
            if (money < 0)
                money = 0;
            else
                Balance += money;
        }

        public void SubFromBalance(decimal money)
        {
            if (money < 0)
                money = 0; // negative input = 0
            else if (money > Balance) //insufficient funds; no change to balance
                money = 0;

            Balance -= money;
        }


    }
}
