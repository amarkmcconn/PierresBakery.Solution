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
  }
} 