using AssetManagementSystem.Domain.Entities;
using AssetManagementSystem.Presentation.Constants;

namespace AssetManagementSystem.Presentation
{
    public static class AssetValidationHelper
    {
        public static bool IsTypeMatch(int type, Asset asset)
        {
            if (type == AssetTypeValues.Book && asset is Book)
                return true;

            if (type == AssetTypeValues.Software && asset is SoftwareLicense)
                return true;

            if (type == AssetTypeValues.Hardware && asset is Hardware)
                return true;

            return false;
        }
    }
}