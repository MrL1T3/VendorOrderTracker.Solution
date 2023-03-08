using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Order
  {
    public int VendorID{get; set;}
    public string OrderText{get; set;}
    public string OrderPrice{get; set;}
    public string OrderDate{get; set;}
    public Order(string submittedOrder, string submittedPrice, string submittedDate, int newID)
    {
      VendorID = newID;
      OrderText = submittedOrder;
      OrderPrice = submittedPrice;
      OrderDate = submittedDate;
    }

    public static void AddOrder(Order o) {
      Vendor v = Vendor.FindVendorByID(o.VendorID);
      v.AddNewOrder(o);
    }
  }
}