using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using PierresBakery;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(1);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
    [TestMethod]
    public void BaugettesPrice_FindsPriceForOne_Int()
    {
      Bread newBread = new Bread(1);
      newBread.BaugettesPrice();
      Assert.AreEqual(5, newBread.BreadOrderTotal);
    }
    [TestMethod]
    public void BaugettesPrice_FindsPriceForTwo_Int()
    {
      Bread newBread = new Bread(2);
      newBread.BaugettesPrice();
      Assert.AreEqual(10, newBread.BreadOrderTotal);
    }
    [TestMethod]
    public void BaugettesPrice_FindsPriceForThree_Int()
    {
      Bread newBread = new Bread(3);
      newBread.BaugettesPrice();
      Assert.AreEqual(10, newBread.BreadOrderTotal);
    }
  }
}