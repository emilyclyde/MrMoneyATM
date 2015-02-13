using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Application
{
  class Customer
  {
    public int CustomerID { get; set; }
    public int AccountNumber { get; set; }
    public int PIN { get; set; }
    
    public bool IsPinMatch(int p)
    {
      return p==PIN;
    }
    
    public bool IsAccountNumMatch(int a)
    {
      return a==AccountNumber;
    }

    public bool IsCustomerMatch(int c)
    {
      return c == CustomerID;
    }
    }
  }



  

