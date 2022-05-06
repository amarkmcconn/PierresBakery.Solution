using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using PierresBakery;

namespace PierresBakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
    [TestMethod]
    public void PastryPrice_FindsPriceForOne_Int()
    {
      Pastry newPastry = new Pastry(1);
      newBread.PastryPrice();
      Assert.AreEqual(2, newPastry.PastryOrderTotal);
    }
  }
}