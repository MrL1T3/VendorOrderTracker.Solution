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

    [Route("Vendor/{id?}")]
    public ActionResult Vendor(int id) {
      Vendor v = VendorOrderTracker.Models.Vendor.FindVendorByID(id);
      if(v == null) {
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
      return RedirectToAction("Index", "Home");
    }
  }
}