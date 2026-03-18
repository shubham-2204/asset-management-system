namespace AssetManagementSystem.Presentation.Constants
{
    public static class AssetMessages
    {
        public const string DuplicateSerial = "Asset with this Serial Number already exists.";
        public const string InvalidAssetType = "Invalid asset type.";
        public const string AddedSuccess = "Asset added successfully.";
        public const string NoAssets = "No assets available.";
        public const string NotFound = "Asset not found.";
        public const string TypeMismatch = "Selected type does not match the asset type.";
        public const string UpdateSuccess = "Asset updated successfully.";
        public const string DeleteSuccess = "Asset deleted successfully.";
        public const string DeleteFailed = "Deletion failed.";

        public const string EnterSerial = "Enter Serial Number: ";
        public const string EnterSerialDelete = "Enter Serial Number to delete: ";
        public const string EnterName = "Enter Name: ";
        public const string EnterAuthor = "Enter Author: ";
        public const string EnterVendor = "Enter Vendor Name: ";
        public const string EnterManufacturer = "Enter Manufacturer: ";
        public const string EnterSearchName = "Enter Name to search: ";

        public const string WhatToUpdate = "What do you want to update?";

        public const string NameOption = "1. Name";
        public const string AuthorOption = "2. Author";
        public const string PublishDateOption = "3. Date Of Publish";
        public const string VendorOption = "2. Vendor Name";
        public const string ExpiryDateOption = "3. Expiry Date";
        public const string ManufacturerOption = "2. Manufacturer";

        public const string EnterNewName = "Enter New Name: ";
        public const string EnterNewAuthor = "Enter New Author: ";
        public const string EnterNewVendor = "Enter New Vendor Name: ";
        public const string EnterNewManufacturer = "Enter New Manufacturer: ";

        public const string EnterNewPublishDate = "Enter New Date Of Publish (dd-MM-yyyy): ";
        public const string EnterNewExpiryDate = "Enter New Expiry Date (dd-MM-yyyy): ";

        public const string InvalidDateFormat = "Invalid date format.";
    }
}