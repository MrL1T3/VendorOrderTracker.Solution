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

    public static void AddOrder(Order o) {
      Vendor v = Vendor.FindVendorByID(o.VendorID);
      v.AddNewOrder(o);
    }
  }
}