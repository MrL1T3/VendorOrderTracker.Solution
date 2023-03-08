using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;
using System;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class OrdersTests
  {
    [TestMethod]
    public void OrderText_Equals_Example_True()
    {
      Order newOrder = new Order("Example", "", "", 1);
      Assert.AreEqual("Example", newOrder.OrderText);
    }
    [TestMethod]
    public void VendorID_Equals_One_True()
    {
      Order newOrder = new Order("Example", "", "", 1);
      Assert.AreEqual(1, newOrder.VendorID);
    }
    [TestMethod]
    public void AddOrder_Adds_New_Order()
    {
      Order o = new Order("example", "", "", 1);
      Vendor v = new Vendor("","");
      v.AddNewOrder(o);
      Assert.IsTrue(v.speOrders.Contains(o));
    }
    [TestMethod]
    public void OrderPrice_Equals_Six_Dollars_True()
    {
      Order newOrder = new Order("Example", "Six Dollars", "", 1);
      Assert.AreEqual("Six Dollars", newOrder.OrderPrice);
    }
    [TestMethod]
    public void OrderDate_Equals_02_13_10_True()
    {
      Order newOrder = new Order("", "", "02/13/10", 1);
      Assert.AreEqual("02/13/10", newOrder.OrderDate);
    }
  }
}