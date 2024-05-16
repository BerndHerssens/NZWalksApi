using NZWalksApi.Business.Models;

namespace NZWalksApi.Business.Services
{
    public interface IRegionService
    {
        Task AddRegionAsync(Region region);
        Task DeleteRegionByIdAsync(int id);
        Task<IEnumerable<Region>> GetAllRegionsAsync();
        Task<IEnumerable<Region>> GetAllRegionsWithWalksAsync();
        Task<Region> GetRegionAsync(int id);
        Task UpdateRegionAsync(int id, Region region);
    }
}