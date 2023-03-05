using Microsoft.AspNetCore.Mvc;
using VendorOrderTracker.Models;
using System;

namespace VendorOrderTracker.Controllers
{
  public class VendorsController : Controller
  {
    public ActionResult Index()
    {
      return View(VendorOrderTracker.Models.Vendor.VendorList());
    }

    public ActionResult AddVendor()
    {
      Console.WriteLine("add vendor page");
      return View(new Vendor("untitled", ""));
    }

    [HttpPost]
    public ActionResult AddVendorForm(Vendor model)
    {
      Console.WriteLine("POST!");
      VendorOrderTracker.Models.Vendor.AddVendor(model);

      return RedirectToAction("Index");
    }
  }
}