using Microsoft.AspNetCore.Mvc;
using VendorOrderTracker.Models;
using System;

namespace VendorOrderTracker.Controllers
{
  public class VendorsController : Controller
  {
    // TODO:  [Route("Home/Index/{id?}")]
    public ActionResult Index(int? id)
    {
      if(id != null) {
        Console.WriteLine("You entered id:" + id);
      } else {
        Console.WriteLine("no id in route");
      }
      

      return View(VendorOrderTracker.Models.Vendor.VendorList());
    }

    [Route("Vendor/{id?}")]
    public ActionResult Vendor(int id) {
      Vendor v = VendorOrderTracker.Models.Vendor.FindVendorByID(id);
      if(v == null) {
        // TODO: return 404;
        return NotFound();
      }
      return View(v);
    }

    public ActionResult AddVendor()
    {
      return View(new Vendor("", ""));
    }
    [HttpPost]
    public ActionResult AddVendorForm(Vendor model)
    {
      VendorOrderTracker.Models.Vendor.AddVendor(model);
      // TODO: instructions say go back to home page.
      return RedirectToAction("Index", "Home");
    }
  }
}