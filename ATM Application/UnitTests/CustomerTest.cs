using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ATM_Application.UnitTests
{
  [TestFixture]
  class CustomerTest
  {
    [Test]

    Account myAccount = new Account() { AccountNumber = 123, Balance = 1000 };

    public void PinMatch()
    {
      int x, y;

      x = myAccount.AccountNumber;
      y = 123;

      Assert.AreEqual(x, y);
    }

    [Test]

    public void PinDoesNotMatch()
    {
      int x, y;

      x = myAccount.AccountNumber;
      y = 456;

      Assert.AreNotEqual(x, y);
    }


  }
}