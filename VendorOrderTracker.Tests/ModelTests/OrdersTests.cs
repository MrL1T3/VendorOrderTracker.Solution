using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;
namespace VendorOrderTracker.Tests
{
  public class OrdersTests
  {
    [TestMethod]
    public void OrderText_Equals_Example_True()
    {
      Order newOrder = new Order("Example", 1);
      Assert.AreEqual("Example", newOrder.OrderText);
    }
    [TestMethod]
    public void VendorID_Equals_One_True()
    {
      Order newOrder = new Order("Example", 1);
      Assert.AreEqual(1, newOrder.VendorID);
    }
  }
}