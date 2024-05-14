using NZWalksApi.Data.Entities;

namespace NZWalksApi.Data.Repositories
{
    public interface IRegionRepository
    {
        void AddRegion(RegionEntity regionEntity);
        void DeleteRegionByID(int id);
        IEnumerable<RegionEntity> GetAllRegions();
        RegionEntity GetRegionByID(int id);
        void UpdateRegion(int id, RegionEntity regionEntity);
    }
}