using System;
using System.Collections.Generic;

namespace PierresBakery
{
  public class Bread
  {
    public int BreadPrice { get; set;}
    public int BreadBaugettes { get; set;}
    public int OrderTotal { get; set;}
    public Bread (int breadPrice, int breadBaugettes)
    {
      BreadPrice = breadPrice;
      BreadBaugettes = breadBaugettes;
      OrderTotal = 0;
    }
    public int BaugettesPrice ()
    {
      // if (BreadBaugettes == 1) {
      //   OrderTotal += 5;
      // }
      // else
      // {

      // }
      // return OrderTotal;
    }
  }
}