using Microsoft.AspNetCore.Mvc;
using VendorOrderTracker.Models;

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
      return View(new Vendor("untitled", ""));
    }
    [HttpPost]
    public ActionResult AddVendorForm(Vendor model)
    {
      VendorOrderTracker.Models.Vendor.AddVendor(model);
      return RedirectToAction("Index");
    }
  }
}