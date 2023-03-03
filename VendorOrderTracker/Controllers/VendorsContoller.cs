using Microsoft.AspNetCore.Mvc;
using VendorOrderTracker.Models;
using System.Collections.Generic;

namespace VendorOrderTracker.Controllers
{
  public class VendorsController : Controller
  {
    public ActionResult Index()
    {
      Vendor example = new Vendor("Example", "");
      // System.Collections.Generic.List<Vendor> vendors = VendorOrderTracker.Models.Vendor.sVendors;
      List<Vendor> vendors = new List<Vendor>();
      vendors.Add(example);
      return View(vendors);
    }
  }
}