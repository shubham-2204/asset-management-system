namespace AssetManagementSystem.Domain.Entities
{
    public abstract class Asset
    {
        public int SerialNumber { get; }
        public string Name { get; set; }

        protected Asset(int serialNumber, string name)
        {
            SerialNumber = serialNumber;
            Name = name;
        }

        public abstract void DisplayDetails();
    }
}