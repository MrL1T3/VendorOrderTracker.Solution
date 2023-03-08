using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Order
  {
    public int VendorID{get; set;}
    public string OrderText{get; set;}
    public string OrderPrice{get; set;}
    public Order(string submittedOrder, string submittedPrice, int newID)
    {
      VendorID = newID;
      OrderText = submittedOrder;
      OrderPrice = submittedPrice;
    }

    public static void AddOrder(Order o) {
      Vendor v = Vendor.FindVendorByID(o.VendorID);
      v.AddNewOrder(o);
    }
  }
}