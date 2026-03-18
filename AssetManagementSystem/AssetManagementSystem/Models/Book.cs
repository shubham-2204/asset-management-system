using System;

namespace AssetManagementSystem.Domain.Entities
{
    public class Book : Asset
    {
        public string Author { get; set; }
        public DateTime DateOfPublish { get; set; }

        public Book(int serialNumber, string name, string author, DateTime dateOfPublish)
            : base(serialNumber, name)
        {
            Author = author;
            DateOfPublish = dateOfPublish;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"{SerialNumber} {Name} {Author} {DateOfPublish:dd-MM-yyyy}");
        }
    }
}