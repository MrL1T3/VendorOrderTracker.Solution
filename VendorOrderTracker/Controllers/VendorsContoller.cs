using Microsoft.AspNetCore.Mvc;
using VendorOrderTracker.Models;
using System.Collections.Generic;

namespace VendorOrderTracker.Controllers
{
  public class VendorsController : Controller
  {
    public ActionResult Index()
    {
      Vendor example = new Vendor("Example.", "This is a description.");
      Vendor exampleTwo = new Vendor("Another?", "I guess here's another description.");
      List<Vendor> vendors = new List<Vendor>();
      vendors.Add(example);
      vendors.Add(exampleTwo);
      return View(vendors);
    }
  }
}