using Microsoft.AspNetCore.Mvc;
using VendorOrderTracker.Models;
using System;

namespace VendorOrderTracker.Controllers
{
  public class OrdersController : Controller
  {
    public ActionResult Index()
    {
      return View(VendorOrderTracker.Models.Order.OrderList());
    }
    public ActionResult AddOrder(int id)
    {
      ViewData["id"] = id;
      Order order = new Order("", 0);

      return View(order);
    }
    [HttpPost]
    //  [Route("Orders/AddOrderForm/{id?}")]
    public ActionResult AddOrderForm(int id, Order model)
    {
      Console.WriteLine("new order's vendor ID is " + id);
      Console.WriteLine("new order is: " + model);
      model.VendorID = id;
      VendorOrderTracker.Models.Order.AddOrder(model);
      return RedirectToAction("Vendor", "Vendors", new{id = model.VendorID});
    }
  }
}