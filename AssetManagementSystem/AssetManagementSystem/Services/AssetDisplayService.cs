using AssetManagementSystem.Domain.Entities;
using AssetManagementSystem.Presentation.Constants;
using System;
using System.Collections.Generic;

namespace AssetManagementSystem.Presentation
{
    public class AssetDisplayService
    {
        public void ShowAllAssets(List<Asset> assets)
        {
            ShowBooks(assets);
            ShowHardware(assets);
            ShowSoftwareLicenses(assets);
        }

        public void ShowSearchResults(int type, List<Asset> assets)
        {
            DisplaySearchResults(type, assets);
        }

        private void ShowBooks(List<Asset> assets)
        {
            bool hasBooks = false;

            for (int i = 0; i < assets.Count; i++)
            {
                if (assets[i] is Book)
                {
                    if (!hasBooks)
                    {
                        Console.WriteLine(DisplayFormats.BooksHeader);

                        Console.WriteLine(DisplayFormats.BookRowFormat,
                            DisplayFormats.SerialNo,
                            DisplayFormats.Name,
                            DisplayFormats.Author,
                            DisplayFormats.PublishDate);

                        Console.WriteLine(new string('-',
                            DisplayFormats.BookDivider));

                        hasBooks = true;
                    }

                    Book book = (Book)assets[i];

                    Console.WriteLine(DisplayFormats.BookRowFormat,
                        book.SerialNumber,
                        book.Name,
                        book.Author,
                        book.DateOfPublish.ToString(DateFormats.StandardDate));
                }
            }

            if (hasBooks)
                Console.WriteLine();
        }

        private void ShowHardware(List<Asset> assets)
        {
            bool hasHardware = false;

            for (int i = 0; i < assets.Count; i++)
            {
                if (assets[i] is Hardware)
                {
                    if (!hasHardware)
                    {
                        Console.WriteLine(DisplayFormats.HardwareHeader);

                        Console.WriteLine(DisplayFormats.HardwareRowFormat,
                            DisplayFormats.SerialNo,
                            DisplayFormats.Name,
                            DisplayFormats.Manufacturer);

                        Console.WriteLine(new string('-',
                            DisplayFormats.HardwareDivider));

                        hasHardware = true;
                    }

                    Hardware hardware = (Hardware)assets[i];

                    Console.WriteLine(DisplayFormats.HardwareRowFormat,
                        hardware.SerialNumber,
                        hardware.Name,
                        hardware.Manufacturer);
                }
            }

            if (hasHardware)
                Console.WriteLine();
        }

        private void ShowSoftwareLicenses(List<Asset> assets)
        {
            bool hasSoftware = false;

            for (int i = 0; i < assets.Count; i++)
            {
                if (assets[i] is SoftwareLicense)
                {
                    if (!hasSoftware)
                    {
                        Console.WriteLine(DisplayFormats.SoftwareHeader);

                        Console.WriteLine(DisplayFormats.SoftwareRowFormat,
                            DisplayFormats.SerialNo,
                            DisplayFormats.Name,
                            DisplayFormats.Vendor,
                            DisplayFormats.ExpiryDate);

                        Console.WriteLine(new string('-',
                            DisplayFormats.SoftwareDivider));

                        hasSoftware = true;
                    }

                    SoftwareLicense software = (SoftwareLicense)assets[i];

                    Console.WriteLine(DisplayFormats.SoftwareRowFormat,
                        software.SerialNumber,
                        software.Name,
                        software.VendorName,
                        software.ExpiryDate.ToString(DateFormats.StandardDate));
                }
            }

            if (hasSoftware)
                Console.WriteLine();
        }

        private void DisplaySearchResults(int type, List<Asset> assets)
        {
            if (type == AssetTypeValues.Book)
            {
                Console.WriteLine(DisplayFormats.BooksHeader);

                Console.WriteLine(DisplayFormats.BookRowFormat,
                    DisplayFormats.SerialNo,
                    DisplayFormats.Name,
                    DisplayFormats.Author,
                    DisplayFormats.PublishDate);

                Console.WriteLine(new string('-',
                    DisplayFormats.BookDivider));

                for (int i = 0; i < assets.Count; i++)
                {
                    Book book = (Book)assets[i];

                    Console.WriteLine(DisplayFormats.BookRowFormat,
                        book.SerialNumber,
                        book.Name,
                        book.Author,
                        book.DateOfPublish.ToString(DateFormats.StandardDate));
                }
            }
            else if (type == AssetTypeValues.Software)
            {
                Console.WriteLine(DisplayFormats.SoftwareHeader);

                Console.WriteLine(DisplayFormats.SoftwareRowFormat,
                    DisplayFormats.SerialNo,
                    DisplayFormats.Name,
                    DisplayFormats.Vendor,
                    DisplayFormats.ExpiryDate);

                Console.WriteLine(new string('-',
                    DisplayFormats.SoftwareDivider));

                for (int i = 0; i < assets.Count; i++)
                {
                    SoftwareLicense software = (SoftwareLicense)assets[i];

                    Console.WriteLine(DisplayFormats.SoftwareRowFormat,
                        software.SerialNumber,
                        software.Name,
                        software.VendorName,
                        software.ExpiryDate.ToString(DateFormats.StandardDate));
                }
            }
            else if (type == AssetTypeValues.Hardware)
            {
                Console.WriteLine(DisplayFormats.HardwareHeader);

                Console.WriteLine(DisplayFormats.HardwareRowFormat,
                    DisplayFormats.SerialNo,
                    DisplayFormats.Name,
                    DisplayFormats.Manufacturer);

                Console.WriteLine(new string('-',
                    DisplayFormats.HardwareDivider));

                for (int i = 0; i < assets.Count; i++)
                {
                    Hardware hardware = (Hardware)assets[i];

                    Console.WriteLine(DisplayFormats.HardwareRowFormat,
                        hardware.SerialNumber,
                        hardware.Name,
                        hardware.Manufacturer);
                }
            }
        }
    }
}