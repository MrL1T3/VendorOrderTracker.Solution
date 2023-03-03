using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Vendor
  {
    public string VendorName{get; set;}
    public string VendorDesc{get; set;}
    public Vendor(string NewVendor, string NewDesc)
    {
      VendorName = NewVendor;
      VendorDesc = NewDesc;
    }
    public static List<Vendor> sVendors = new List<Vendor> {
      new Vendor("Example", "")
    };
  }
}