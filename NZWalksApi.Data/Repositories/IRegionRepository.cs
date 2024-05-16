using NZWalksApi.Data.Entities;

namespace NZWalksApi.Data.Repositories
{
    public interface IRegionRepository
    {
        Task AddRegionAsync(RegionEntity regionEntity);
        Task DeleteRegionByIDAsync(int id);
        Task<IEnumerable<RegionEntity>> GetAllRegionsAsync();
        Task<RegionEntity> GetRegionByIDAsync(int id);
        Task UpdateRegionAsync(int id, RegionEntity regionEntity);
    }
}