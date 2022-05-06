using System;
using System.Collections.Generic;

namespace PierresBakery
{
  public class Pastry
  {
    public int PastriesAmount { get; set; }
    public int PastryOrderTotal { get; set; }
    public Pastry  (int pastryAmount)
    {
      PastriesAmount = pastryAmount;
      PastryOrderTotal = 0;
    }
    public int PastryPrice ()
    {
      if (PastriesAmount == 1) 
      {
        PastryOrderTotal += 2;
      }
      else if (PastriesAmount == 2)
      {
        PastryOrderTotal += 4;
      }
      else if (PastriesAmount == 3)
      {
        PastryOrderTotal += 5;
      }
      return PastryOrderTotal;
    }  
  }
} 