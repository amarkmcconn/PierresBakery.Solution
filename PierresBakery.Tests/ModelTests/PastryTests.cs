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
      newPastry.PastryPrice();
      Assert.AreEqual(2, newPastry.PastryOrderTotal);
    }
    [TestMethod]
    public void PastryPrice_FindsPriceForTwo_Int()
    {
      Pastry newPastry = new Pastry(2);
      newPastry.PastryPrice();
      Assert.AreEqual(4, newPastry.PastryOrderTotal);
    }
    [TestMethod]
    public void PastryPrice_FindsPriceForThree_Int()
    {
      Pastry newPastry = new Pastry(3);
      newPastry.PastryPrice();
      Assert.AreEqual(5, newPastry.PastryOrderTotal);
    }
    [TestMethod]
    public void PastryPrice_FindsPriceForFour_Int()
    {
      Pastry newPastry = new Pastry(4);
      newPastry.PastryPrice();
      Assert.AreEqual(7, newPastry.PastryOrderTotal);
    }
    [TestMethod]
    public void PastryPrice_FindsPriceForFive_Int()
    {
      Pastry newPastry = new Pastry(5);
      newPastry.PastryPrice();
      Assert.AreEqual(9, newPastry.PastryOrderTotal);
    }
  }
}