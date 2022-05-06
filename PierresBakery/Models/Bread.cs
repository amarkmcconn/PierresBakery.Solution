using System;
using System.Collections.Generic;

namespace PierresBakery
{
  public class Bread
  {
    
    public int OrderNum {get; set;}

    public Bread ( int amount)
    {
      OrderNum = amount;
    }
    public int OrderTotal ()
    {
      return 0;
    }
  }
}