using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Order
  {
    public string OrderText{get; set;}
    public Order()
    {
      OrderText = "example order";
    }
    public Order(string submittedOrder)
    {
      OrderText = submittedOrder;
    }
    private static List<Order> sOrders = new List<Order>();

    public static void AddOrder(Order o) {
      sOrders.Add(o);
    }
    
    public static List<Order> OrderList() {
      return sOrders;
    }
  }
}