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
    public void BaugettesPrice_FindsPrice_Int()
    {
      Bread newBread = new Bread(1);
      newBread.BaugettesPrice();
      Assert.AreEqual(5, newBread.OrderTotal);
    }
  }
}