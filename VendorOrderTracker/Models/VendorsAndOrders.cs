namespace VendorOrderTracker.Models
{
  public class Vendor
  {
    public string VendorName{get; set;}
    public Vendor(string NewVendor)
    {
      VendorName = NewVendor;
    }
  }
}