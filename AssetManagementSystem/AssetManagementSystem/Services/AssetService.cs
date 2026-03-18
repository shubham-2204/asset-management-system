using AssetManagementSystem.Domain.Entities;
using AssetManagementSystem.Infrastructure;
using System;
using System.Collections.Generic;

namespace AssetManagementSystem.Application
{
    public class AssetService
    {
        private readonly AssetRepository _repository;

        public AssetService(AssetRepository repository)
        {
            _repository = repository;
        }

        public void AddAsset(Asset asset)
        {
            Asset existingAsset = _repository.GetBySerialNumber(asset.SerialNumber);

            if (existingAsset != null)
            {
                throw new Exception("Asset with this serial number already exists.");
            }

            _repository.Add(asset);
        }

        public List<Asset> GetAllAssets()
        {
            return _repository.GetAll();
        }

        public Asset GetBySerialNumber(int serialNumber)
        {
            return _repository.GetBySerialNumber(serialNumber);
        }

        public bool DeleteAsset(int serialNumber)
        {
            return _repository.Remove(serialNumber);
        }

        public bool SerialNumberExists(int serialNumber)
        {
            Asset asset = _repository.GetBySerialNumber(serialNumber);

            if (asset != null)
                return true;

            return false;
        }

        public List<Asset> SearchByTypeAndName(int type, string name)
        {
            List<Asset> result = new List<Asset>();
            List<Asset> allAssets = _repository.GetAll();

            for (int i = 0; i < allAssets.Count; i++)
            {
                Asset asset = allAssets[i];

                if (type == 1 && asset is Book)
                {
                    if (asset.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                        result.Add(asset);
                }
                else if (type == 2 && asset is SoftwareLicense)
                {
                    if (asset.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                        result.Add(asset);
                }
                else if (type == 3 && asset is Hardware)
                {
                    if (asset.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                        result.Add(asset);
                }
            }

            return result;
        }
    }
}