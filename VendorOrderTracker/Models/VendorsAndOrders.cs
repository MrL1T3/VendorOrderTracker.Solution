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
  }
}