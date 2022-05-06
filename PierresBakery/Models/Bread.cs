using System;
using System.Collections.Generic;

namespace PierresBakery
{
  public class Bread
  {
    public int BreadBaugettes { get; set; }
    public int OrderTotal { get; set; }
    public Bread  (int breadBaugettes)
    {
      BreadBaugettes = breadBaugettes;
      OrderTotal = 0;
    }
    public int BaugettesPrice ()
    {
      int numberOfBaugettes = BreadBaugettes;
      if (numberOfBaugettes == 1) {
        OrderTotal += 5;
      }
      return OrderTotal;
    }
  }
}