using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Order
  {
    public int VendorID{get; set;}
    public string OrderText{get; set;}
    public Order()
    {
      VendorID = 0;
      OrderText = "example order";
    }
    public Order(string submittedOrder, int newID)
    {
      VendorID = newID;
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