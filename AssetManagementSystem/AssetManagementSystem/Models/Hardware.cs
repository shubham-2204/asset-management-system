using System;

namespace AssetManagementSystem.Domain.Entities
{
    public class Hardware : Asset
    {
        public string Manufacturer { get; set; }

        public Hardware(int serialNumber, string name, string manufacturer)
            : base(serialNumber, name)
        {
            Manufacturer = manufacturer;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"{SerialNumber} {Name} {Manufacturer}");
        }
    }
}