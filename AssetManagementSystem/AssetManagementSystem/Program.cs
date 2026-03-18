using AssetManagementSystem.Application;
using AssetManagementSystem.Infrastructure;
using AssetManagementSystem.Presentation;

namespace AssetManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            AssetRepository repository = new AssetRepository();

            AssetService assetService = new AssetService(repository);
            AssetDisplayService displayService = new AssetDisplayService();
            AssetUpdateService updateService = new AssetUpdateService();

            ConsoleInputHandler inputHandler =
                new ConsoleInputHandler(assetService, displayService, updateService);
            
            ConsoleMenu consoleMenu = new ConsoleMenu(inputHandler);

            consoleMenu.RunMenu();
        }
    }
}