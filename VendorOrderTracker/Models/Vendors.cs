using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Vendor
  {
    public string VendorName{get; set;}
    public string VendorDesc{get; set;}

    public Vendor()
    {
      VendorName = "untitled";
      VendorDesc = "";
    }

    public Vendor(string NewVendor, string NewDesc)
    {
      VendorName = NewVendor;
      VendorDesc = NewDesc;
    }

    private static List<Vendor> sVendors = new List<Vendor>();

    public static void AddVendor(Vendor v) {
      sVendors.Add(v);
    }
    
    public static List<Vendor> VendorList() {
      return sVendors;
    }

  }
}