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
      Bread newBread = new Bread(10,1);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
    [TestMethod]
    public void BaugettesPrice_FindsPrice_Int()
    {
      Bread newBread = newBread(5, 1);
      Assert.AreEqual(5, newBread.BreadPrice);
    }
  }
}