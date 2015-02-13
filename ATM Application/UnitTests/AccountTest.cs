using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ATM_Application.UnitTests
{
  [TestFixture]
  class AccountTest
  {

    [Test]

    Account myMoney = new Account() { Balance = 1000 };

    public void CheckBalance()
    {
      decimal x, y;

      x = myMoney.Balance;
      y = 1000;

      Assert.AreEqual(x, y);
    }
    public void DepositFunds()
    {
      decimal x, y;

      x = myMoney.Balance;
      y = 100;

      Assert.AreEqual(x++, y);
    }

    [Test]

    public void WithdrawFunds()
    {

      decimal x, y;

      x = myMoney.Balance;
      y = 50;

      Assert.AreNotEqual(x--, y);
    }

  }
}


