using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;
using System;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class VendorsAndOrdersTests
  {
    [TestMethod]
    public void vendorName_EqualsJohn_True()
    {
      Vendor first = new Vendor("John");
      Assert.AreEqual("John", first.VendorName);
    }
  }
}
