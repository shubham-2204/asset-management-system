using AssetManagementSystem.Application;
using AssetManagementSystem.Presentation.Constants;
using System;

namespace AssetManagementSystem.Presentation
{
    public class ConsoleMenu
{
    private readonly ConsoleInputHandler _inputHandler;

    public ConsoleMenu(ConsoleInputHandler inputHandler)
    {
        _inputHandler = inputHandler;
    }


        public void RunMenu()
        {
            while (true)
            {
                ShowMenu();
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case MenuOptions.Add:
                        _inputHandler.AddAsset();
                        break;

                    case MenuOptions.Search:
                        _inputHandler.SearchAsset();
                        break;

                    case MenuOptions.Update:
                        _inputHandler.UpdateAsset();
                        break;

                    case MenuOptions.Delete:
                        _inputHandler.DeleteAsset();
                        break;

                    case MenuOptions.List:
                        _inputHandler.ListAssets();
                        break;

                    case MenuOptions.Exit:
                        return;

                    default:
                        Console.WriteLine(UiMessages.InvalidChoice);
                        break;
                }
            }
        }

        private void ShowMenu()
        {
            Console.WriteLine(MenuTexts.Header);
            Console.WriteLine(MenuTexts.AddAsset);
            Console.WriteLine(MenuTexts.SearchAsset);
            Console.WriteLine(MenuTexts.UpdateAsset);
            Console.WriteLine(MenuTexts.DeleteAsset);
            Console.WriteLine(MenuTexts.ListAssets);
            Console.WriteLine(MenuTexts.Exit);
            Console.Write(MenuTexts.EnterChoice);
        }
    }
}