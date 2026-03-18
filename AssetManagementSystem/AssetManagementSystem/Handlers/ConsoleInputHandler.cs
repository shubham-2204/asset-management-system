using AssetManagementSystem.Application;
using AssetManagementSystem.Domain.Entities;
using AssetManagementSystem.Presentation.Constants;
using System;
using System.Collections.Generic;

namespace AssetManagementSystem.Presentation
{
    public class ConsoleInputHandler
    {
        private readonly AssetService _assetService;
        private readonly AssetDisplayService _displayService;
        private readonly AssetUpdateService _updateService;

        public ConsoleInputHandler(
            AssetService manager,
            AssetDisplayService displayService,
            AssetUpdateService updateService)
        {
            _assetService = manager;
            _displayService = displayService;
            _updateService = updateService;
        }


        public void AddAsset()
        {
            Console.WriteLine(AssetTypeMenuTexts.SelectType);
            Console.WriteLine(AssetTypeMenuTexts.BookOption);
            Console.WriteLine(AssetTypeMenuTexts.SoftwareOption);
            Console.WriteLine(AssetTypeMenuTexts.HardwareOption);
            Console.Write(AssetTypeMenuTexts.EnterChoice);

            int type = int.Parse(Console.ReadLine());

            Console.Write(AssetMessages.EnterSerial);
            int serialNumber = int.Parse(Console.ReadLine());

            Console.Write(AssetMessages.EnterName);
            string name = Console.ReadLine();

            Asset asset = null;

            switch (type)
            {
                case AssetTypeValues.Book:
                    Console.Write(AssetMessages.EnterAuthor);
                    string author = Console.ReadLine();

                    Console.Write("Enter Date Of Publish (" + DateFormats.StandardDate + "): ");
                    DateTime publishDate = DateTime.ParseExact(
                        Console.ReadLine(),
                        DateFormats.StandardDate,
                        null);

                    asset = new Book(serialNumber, name, author, publishDate);
                    break;

                case AssetTypeValues.Software:
                    Console.Write(AssetMessages.EnterVendor);
                    string vendorName = Console.ReadLine();

                    Console.Write("Enter Expiry Date (" + DateFormats.StandardDate + "): ");
                    DateTime expiryDate = DateTime.ParseExact(
                        Console.ReadLine(),
                        DateFormats.StandardDate,
                        null);

                    asset = new SoftwareLicense(serialNumber, name, vendorName, expiryDate);
                    break;

                case AssetTypeValues.Hardware:
                    Console.Write(AssetMessages.EnterManufacturer);
                    string manufacturer = Console.ReadLine();

                    asset = new Hardware(serialNumber, name, manufacturer);
                    break;

                default:
                    Console.WriteLine(AssetMessages.InvalidAssetType);
                    return;
            }

            _assetService.AddAsset(asset);
            Console.WriteLine(AssetMessages.AddedSuccess);
        }

        public void ListAssets()
        {
            List<Asset> assets = _assetService.GetAllAssets();

            if (assets.Count == 0)
            {
                Console.WriteLine(AssetMessages.NoAssets);
                return;
            }

            _displayService.ShowAllAssets(assets);
        }

        public void SearchAsset()
        {
            Console.WriteLine(AssetTypeMenuTexts.SelectTypeSearch);
            Console.WriteLine(AssetTypeMenuTexts.BookOption);
            Console.WriteLine(AssetTypeMenuTexts.SoftwareOption);
            Console.WriteLine(AssetTypeMenuTexts.HardwareOption);
            Console.Write(AssetTypeMenuTexts.EnterChoice);

            int type = int.Parse(Console.ReadLine());

            Console.Write(AssetMessages.EnterSearchName);
            string name = Console.ReadLine();

            List<Asset> results = _assetService.SearchByTypeAndName(type, name);

            if (results.Count == 0)
            {
                Console.WriteLine(AssetMessages.NotFound);
                return;
            }

            _displayService.ShowSearchResults(type, results);
        }

        public void UpdateAsset()
        {
            Console.WriteLine(AssetTypeMenuTexts.SelectTypeUpdate);
            Console.WriteLine(AssetTypeMenuTexts.BookOption);
            Console.WriteLine(AssetTypeMenuTexts.SoftwareOption);
            Console.WriteLine(AssetTypeMenuTexts.HardwareOption);
            Console.Write(AssetTypeMenuTexts.EnterChoice);

            int type = int.Parse(Console.ReadLine());

            Console.Write(AssetMessages.EnterSerial);
            int serialNumber = int.Parse(Console.ReadLine());

            Asset asset = _assetService.GetBySerialNumber(serialNumber);

            if (asset == null)
            {
                Console.WriteLine(AssetMessages.NotFound);
                return;
            }

            if (!AssetValidationHelper.IsTypeMatch(type, asset))
            {
                Console.WriteLine(AssetMessages.TypeMismatch);
                return;
            }

            _updateService.UpdateAssetByType(type, asset);

            Console.WriteLine(AssetMessages.UpdateSuccess);
        }

        public void DeleteAsset()
        {
            Console.WriteLine(AssetTypeMenuTexts.SelectTypeDelete);
            Console.WriteLine(AssetTypeMenuTexts.BookOption);
            Console.WriteLine(AssetTypeMenuTexts.SoftwareOption);
            Console.WriteLine(AssetTypeMenuTexts.HardwareOption);
            Console.Write(AssetTypeMenuTexts.EnterChoice);

            int type = int.Parse(Console.ReadLine());

            Console.Write(AssetMessages.EnterSerialDelete);
            int serialNumber = int.Parse(Console.ReadLine());

            Asset asset = _assetService.GetBySerialNumber(serialNumber);

            if (asset == null)
            {
                Console.WriteLine(AssetMessages.NotFound);
                return;
            }

            if (!AssetValidationHelper.IsTypeMatch(type, asset))
            {
                Console.WriteLine(AssetMessages.TypeMismatch);
                return;
            }

            bool deleted = _assetService.DeleteAsset(serialNumber);

            if (deleted)
                Console.WriteLine(AssetMessages.DeleteSuccess);
            else
                Console.WriteLine(AssetMessages.DeleteFailed);
        }
    }
}