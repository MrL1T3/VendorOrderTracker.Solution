using Microsoft.AspNetCore.Mvc;
using VendorOrderTracker.Models;
using System.Collections.Generic;

namespace VendorOrderTracker.Controllers
{
  public class VendorsController : Controller
  {
    public ActionResult Index()
    {
      Vendor example = new Vendor("Example", "This is a Description");
      List<Vendor> vendors = new List<Vendor>();
      vendors.Add(example);
      return View(vendors);
    }
  }
}