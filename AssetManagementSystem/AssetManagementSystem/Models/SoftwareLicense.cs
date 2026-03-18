using System;

namespace AssetManagementSystem.Domain.Entities
{
    public class SoftwareLicense : Asset
    {
        public string VendorName { get; set; }
        public DateTime ExpiryDate { get; set; }

        public SoftwareLicense(int serialNumber, string name, string vendorName, DateTime expiryDate)
            : base(serialNumber, name)
        {
            VendorName = vendorName;
            ExpiryDate = expiryDate;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"{SerialNumber} {Name} {VendorName} {ExpiryDate:dd-MM-yyyy}");
        }
    }
}