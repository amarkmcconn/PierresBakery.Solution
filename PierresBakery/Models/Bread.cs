using System;
using System.Collections.Generic;

namespace PierresBakery
{
  public class Bread
  {
    public int BreadPrice { get; set;}
    public int BreadBaugettes { get; set;}
    public Bread (int breadPrice, int breadBaugettes)
    {
      BreadPrice = breadPrice;
      BreadBaugettes = breadBaugettes;
    }
    public int BaugettesPrice ()
    {
      return BreadPrice;
    }
  }
}