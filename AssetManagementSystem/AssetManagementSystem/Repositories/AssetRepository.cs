using AssetManagementSystem.Domain.Entities;
using System.Collections.Generic;

namespace AssetManagementSystem.Infrastructure
{
    public class AssetRepository
    {
        private readonly List<Asset> _assets;

        public AssetRepository()
        {
            _assets = new List<Asset>();
        }

        public void Add(Asset asset)
        {
            _assets.Add(asset);
        }

        public List<Asset> GetAll()
        {
            return _assets;
        }

        public Asset GetBySerialNumber(int serialNumber)
        {
            for (int i = 0; i < _assets.Count; i++)
            {
                if (_assets[i].SerialNumber == serialNumber)
                {
                    return _assets[i];
                }
            }

            return null;
        }

        public bool Remove(int serialNumber)
        {
            for (int i = 0; i < _assets.Count; i++)
            {
                if (_assets[i].SerialNumber == serialNumber)
                {
                    _assets.RemoveAt(i);
                    return true;
                }
            }

            return false;
        }
    }
}