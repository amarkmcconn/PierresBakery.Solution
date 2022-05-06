using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery;
using System;
using System.Collections.Generic;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void OrderTotal_GivesPriceForOrder_Int()
    {
      Bread inputBread = new Bread (1);
      Assert.AreEqual(5, inputBread.OrderTotal);
    }
  }
}