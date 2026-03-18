namespace AssetManagementSystem.Presentation.Constants
{
    public static class DisplayFormats
    {
        // Section Headers
        public const string BooksHeader =
            "\n==================== BOOKS ====================\n";

        public const string HardwareHeader =
            "\n=================== HARDWARE ===================\n";

        public const string SoftwareHeader =
            "\n=============== SOFTWARE LICENSE ===============\n";

        // Column Formats
        public const string BookRowFormat =
            "{0,-10} {1,-20} {2,-20} {3,-15}";

        public const string HardwareRowFormat =
            "{0,-10} {1,-20} {2,-20}";

        public const string SoftwareRowFormat =
            "{0,-10} {1,-20} {2,-20} {3,-15}";

        // Divider Lengths
        public const int BookDivider = 65;
        public const int HardwareDivider = 55;
        public const int SoftwareDivider = 70;

        // Column Titles
        public const string SerialNo = "Serial No";
        public const string Name = "Name";
        public const string Author = "Author";
        public const string PublishDate = "Date Of Publish";
        public const string Manufacturer = "Manufacturer";
        public const string Vendor = "Vendor Name";
        public const string ExpiryDate = "Expiry Date";
    }
}