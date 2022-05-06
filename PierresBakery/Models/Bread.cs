using System;
using System.Collections.Generic;

namespace PierresBakery
{
  public class Bread
  {
    public int BreadBaugettes { get; set; }
    public int BreadOrderTotal { get; set; }
    public Bread  (int breadBaugettes)
    {
      BreadBaugettes = breadBaugettes;
      BreadOrderTotal = 0;
    }
    public int BaugettesPrice ()
    {
      if (BreadBaugettes == 1) 
      {
        BreadOrderTotal += 5;
      }
      else if (BreadBaugettes == 2) 
      {
        BreadOrderTotal += 10;
      }
      else if (BreadBaugettes % 3 == 0) 
      {
        BreadOrderTotal = (BreadBaugettes / 3 * 10);
      }
      return BreadOrderTotal;
    }
  }
}