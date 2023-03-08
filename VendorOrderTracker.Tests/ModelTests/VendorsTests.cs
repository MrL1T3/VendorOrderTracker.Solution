using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class VendorsTests
  {
    [Ignore]
    [TestMethod]
    public void vendorName_Equals_John_True()
    {
      Vendor first = new Vendor("John", "");
      Assert.AreEqual("John", first.VendorName);
    }
    [TestMethod]
    public void VendorDesc_Equals_SellsGlassware_True()
    {
      Vendor first = new Vendor("John", "John sells glassware products");
      Assert.AreEqual("John sells glassware products", first.VendorDesc);
    }
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
