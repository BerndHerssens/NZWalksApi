using NZWalksApi.Business.Models;

namespace NZWalksApi.Business.Services
{
    public interface IRegionService
    {
        void AddRegion(Region region);
        void DeleteRegionById(int id);
        IEnumerable<Region> GetAllRegions();
        Task<IEnumerable<Region>> GetAllRegionsWithWalksAsync();
        Region GetRegion(int id);
        void UpdateRegion(int id, Region region);
    }
}