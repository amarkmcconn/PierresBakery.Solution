using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void OrderTotal_GivesPriceForOrder_Int()
    {
      Bread inputBread = new Bread (Baugette, 5);
      Assert.AreEqual(5, BreadPrice);
    }
  }
}