using AssetManagementSystem.Domain.Entities;
using AssetManagementSystem.Presentation.Constants;
using System;

namespace AssetManagementSystem.Presentation
{
    public class AssetUpdateService
    {
        public void UpdateAssetByType(int type, Asset asset)
        {
            if (type == AssetTypeValues.Book)
                UpdateBook((Book)asset);
            else if (type == AssetTypeValues.Software)
                UpdateSoftware((SoftwareLicense)asset);
            else if (type == AssetTypeValues.Hardware)
                UpdateHardware((Hardware)asset);
        }

        private void UpdateBook(Book book)
        {
            Console.WriteLine(AssetMessages.WhatToUpdate);
            Console.WriteLine(AssetMessages.NameOption);
            Console.WriteLine(AssetMessages.AuthorOption);
            Console.WriteLine(AssetMessages.PublishDateOption);
            Console.Write(AssetTypeMenuTexts.EnterChoice);

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.Write(AssetMessages.EnterNewName);
                book.Name = Console.ReadLine();
            }
            else if (choice == 2)
            {
                Console.Write(AssetMessages.EnterNewAuthor);
                book.Author = Console.ReadLine();
            }
            else if (choice == 3)
            {
                DateTime publishDate = DateTime.MinValue;
                bool validDate = false;

                while (!validDate)
                {
                    Console.Write(AssetMessages.EnterNewPublishDate);
                    string input = Console.ReadLine();

                    validDate = DateTime.TryParseExact(
                        input,
                        DateFormats.StandardDate,
                        null,
                        System.Globalization.DateTimeStyles.None,
                        out publishDate);

                    if (!validDate)
                        Console.WriteLine(AssetMessages.InvalidDateFormat);
                }

                book.DateOfPublish = publishDate;
            }
            else
            {
                Console.WriteLine(UiMessages.InvalidChoice);
            }
        }

        private void UpdateSoftware(SoftwareLicense software)
        {
            Console.WriteLine(AssetMessages.WhatToUpdate);
            Console.WriteLine(AssetMessages.NameOption);
            Console.WriteLine(AssetMessages.VendorOption);
            Console.WriteLine(AssetMessages.ExpiryDateOption);
            Console.Write(AssetTypeMenuTexts.EnterChoice);

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.Write(AssetMessages.EnterNewName);
                software.Name = Console.ReadLine();
            }
            else if (choice == 2)
            {
                Console.Write(AssetMessages.EnterNewVendor);
                software.VendorName = Console.ReadLine();
            }
            else if (choice == 3)
            {
                DateTime expiryDate = DateTime.MinValue;
                bool validDate = false;

                while (!validDate)
                {
                    Console.Write(AssetMessages.EnterNewExpiryDate);
                    string input = Console.ReadLine();

                    validDate = DateTime.TryParseExact(
                        input,
                        DateFormats.StandardDate,
                        null,
                        System.Globalization.DateTimeStyles.None,
                        out expiryDate);

                    if (!validDate)
                        Console.WriteLine(AssetMessages.InvalidDateFormat);
                }

                software.ExpiryDate = expiryDate;
            }
            else
            {
                Console.WriteLine(UiMessages.InvalidChoice);
            }
        }

        private void UpdateHardware(Hardware hardware)
        {
            Console.WriteLine(AssetMessages.WhatToUpdate);
            Console.WriteLine(AssetMessages.NameOption);
            Console.WriteLine(AssetMessages.ManufacturerOption);
            Console.Write(AssetTypeMenuTexts.EnterChoice);

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.Write(AssetMessages.EnterNewName);
                hardware.Name = Console.ReadLine();
            }
            else if (choice == 2)
            {
                Console.Write(AssetMessages.EnterNewManufacturer);
                hardware.Manufacturer = Console.ReadLine();
            }
            else
            {
                Console.WriteLine(UiMessages.InvalidChoice);
            }
        }
    }
}