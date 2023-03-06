using Microsoft.AspNetCore.Mvc;
using VendorOrderTracker.Models;

namespace VendorOrderTracker.Controllers
{
  public class OrdersController : Controller
  {
    public ActionResult Index()
    {
      return View(VendorOrderTracker.Models.Order.OrderList());
    }
    public ActionResult AddOrder()
    {
      return View(new Order(""));
    }
    [HttpPost]
    public ActionResult AddOrderForm(Order model)
    {
      VendorOrderTracker.Models.Order.AddOrder(model);
      return RedirectToAction("Index");
    }
  }
}