using Microsoft.AspNetCore.Mvc;

namespace VendorOrderTracker.Controllers
{
  public class VendorFormController : Controller
  {
    public ActionResult Index()
    {
      return View();
    }
  }
}
