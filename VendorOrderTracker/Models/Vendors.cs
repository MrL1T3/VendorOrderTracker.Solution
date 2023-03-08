using System.Collections.Generic;
using System;

namespace VendorOrderTracker.Models
{
  public class Vendor
  {
    private static int sNextID = 0;
    public int VendorID{get;}
    public string VendorName{get; set;}
    public string VendorDesc{get; set;}
    private List<Order> speOrders = new List<Order>();
    public void AddNewOrder(Order o) {
      speOrders.Add(o);
    }
    // TODO: need a way to fetch list of orders.

    public Vendor()
    {
      VendorID = ++sNextID;
      VendorName = "";
      VendorDesc = "";
    }
    public Vendor(string NewVendor, string NewDesc)
    {
      VendorID = ++sNextID;
      VendorName = NewVendor;
      VendorDesc = NewDesc;
    }
    private static List<Vendor> sVendors = new List<Vendor>();
    public static void AddVendor(Vendor v) {
      // TODO: assign vendor ID here so doesn't increment more than once.
      sVendors.Add(v);
      Console.WriteLine("Added vendor with ID" + v.VendorID);
    }
    public static List<Vendor> VendorList() {
      return sVendors;
    }
    public static Vendor FindVendorByID(int id) {
      foreach(Vendor v in sVendors) {
        if(v.VendorID == id) {
          return v;
        }
      }
      return null;
    }
  }
}